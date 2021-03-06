﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace images_steganography
{
    public partial class Unsteganography_form : Form
    {

        private Bitmap hostImage = null;
        private Tuple<byte[], string> extractedData = null;

        #region UI
            public Unsteganography_form()
            {
                InitializeComponent();
                this.encryptionType.SelectedIndex = 0;
                this.encryptionType.SelectedIndexChanged += new EventHandler(encryptionType_changed);
            }

            private void selectHostImageButton_Click(object sender, EventArgs e)
            {
                if (selectHostImageDialog.ShowDialog() == DialogResult.OK)
                    hostImagePath.Text = selectHostImageDialog.FileName;
            }
    
            private void updatePreviews()
            {
                hostImagePreview.Image = hostImage;
                extractedImagePreview.Image = null;
                extractedTextPreview.Text = "";
                iconPreview.Image = null;
                dataTypeLabel.Text = "";

                if (extractedData != null)
                {
                    iconPreview.Image = Bitmap.FromHicon(Etier.IconHelper.IconReader.GetFileIcon("." + extractedData.Item2, Etier.IconHelper.IconReader.IconSize.Large, false).Handle);
                    dataTypeLabel.Text = extractedData.Item2.ToUpper();
                    string ext = extractedData.Item2.ToLower();
                    string[] imageExtensions = new String[] { "jpg", "jpeg", "jpe", "jfif", "png" };
                    bool isImage = Array.IndexOf(imageExtensions, ext) > -1;
                    if (isImage)
                    {
                        extractedImagePreview.Show();
                        extractedTextPreview.Hide();
                        using (var ms = new MemoryStream(extractedData.Item1))
                            extractedImagePreview.Image = Image.FromStream(ms);

                    }                        

                    bool isText = "txt".Equals(extractedData.Item2.ToLower());
                    if (isText)
                    {
                        extractedTextPreview.Show();
                        extractedTextPreview.Text = Encoding.UTF8.GetString(extractedData.Item1);
                        extractedImagePreview.Hide();
                    }

                    
                }else
                    extractedImagePreview.Image = null;
            }

            private void saveAsButton_Click(object sender, EventArgs e)
            {
                if (extractedData == null)
                    MessageBox.Show("There is no data to save. Please use options panel to extract the data from image.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    saveExtractedDataAs.Filter = extractedData.Item2.ToUpper() + " Files|*." + extractedData.Item2;
                    if (saveExtractedDataAs.ShowDialog() == DialogResult.OK)
                        System.IO.File.WriteAllBytes(saveExtractedDataAs.FileName, extractedData.Item1);
                }
            }

            private void encryptionType_changed(object sender, EventArgs e)
            {
                this.encryptionPassword.Enabled = (this.encryptionType.SelectedIndex > 0);
            }

            BackgroundWorker bw = new BackgroundWorker();
            private void optionsChanged(object sender, EventArgs e)
            {
                bw.WorkerSupportsCancellation = true;
                warningBox1.Hide();
                bw.CancelAsync();
                bw = new BackgroundWorker();
                bw.WorkerSupportsCancellation = true;
                bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
                bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
                bw.RunWorkerAsync(bw);
                loading.Show();
            }

            private void bw_DoWork(object sender, DoWorkEventArgs e)
            {
                if (hostImagePath.Text.Length == 0)
                {
                    hostImage = null;
                    extractedData = null;
                    return;
                }
                try
                {
                    using (var fs = new System.IO.FileStream(hostImagePath.Text, System.IO.FileMode.Open, FileAccess.Read))
                    {
                        var bmp = new Bitmap(fs);
                        hostImage = (Bitmap)bmp.Clone();
                    }

                    extractedData = null;

                    bool aesEncryption = false;
                    this.Invoke((MethodInvoker)delegate()
                    {
                        aesEncryption = encryptionType.SelectedIndex == 1;
                    });
                    int threadCount = 8;

                    extractedData = Steganography.extractData(new Bitmap(hostImagePath.Text),
                            redCheckbox.Checked,
                            greenCheckbox.Checked,
                            blueCheckbox.Checked,
                            alphaCheckbox.Checked,
                            (int)NumberOfBitsInput.Value,
                            aesEncryption,
                            encryptionPassword.Text,
                            threadCount);
                }
                catch (Exception ex)
                {
                    e.Result = ex;
                }
                e.Cancel = ((BackgroundWorker)e.Argument).CancellationPending;
            }

            private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                if (e.Cancelled)
                    return;

                if (e.Result != null && e.Result is Exception)
                {
                    warningBox1.Text = ((Exception)e.Result).Message;
                    warningBox1.Show();
                }
                updatePreviews();
                loading.Hide();
            }

            private void OpenExtractedFile_Click(object sender, EventArgs e)
            {
                if (extractedData == null)
                    MessageBox.Show("There is no data to open. Please use options panel to extract the data from image.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string path = Path.GetTempPath() + "/" + "steganography_." + extractedData.Item2;
                    File.WriteAllBytes(path, extractedData.Item1);
                    System.Diagnostics.Process.Start(path);
                }
            }
        #endregion


    }
}
