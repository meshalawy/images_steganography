using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace images_steganography
{
    public partial class Steganography_form : Form
    {

        private Bitmap hostImage = null;
        private Bitmap modifiedImage = null;

        #region UI
            public Steganography_form()
            {
                InitializeComponent();
                this.encryptionType.SelectedIndex = 0;
                this.encryptionType.SelectedIndexChanged += new EventHandler(encryptionType_changed);
            }

            private void textOption_CheckedChanged(object sender, EventArgs e)
            {
                textData.Enabled = textOption.Checked;
            }

            private void selectHostImageButton_Click(object sender, EventArgs e)
            {
                if (selectHostImageDialog.ShowDialog() == DialogResult.OK)
                    hostImagePath.Text = selectHostImageDialog.FileName;
            }

            private void selectFileForFileOption_Click(object sender, EventArgs e)
            {
                if (selectDataFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileOption.Checked = true;
                    fileOptionFilePath.Text = selectDataFileDialog.FileName;
                }
            }

            private void updatePreviews()
            {
                hostImagePreview.Image = hostImage;
                modifiedImagePreview.Image = modifiedImage;
            }

            private void showOriginalImage_MouseDown(object sender, MouseEventArgs e)
            {
                modifiedImagePreview.Image = hostImage;
            }

            private void showOriginalImage_MouseUp(object sender, MouseEventArgs e)
            {
                modifiedImagePreview.Image = modifiedImage;
            }

            private void textData_textChanged(object sender, EventArgs e)
            {
                textOption.Checked = true;
            }

            private void importTextFromFileButton_Click(object sender, EventArgs e)
            {
                if (selectTextFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textOption.Checked = true;
                    textData.Text = System.IO.File.ReadAllText(selectTextFileDialog.FileName);
                    
                }
            }

            private void saveAsButton_Click(object sender, EventArgs e)
            {
                if (modifiedImage == null)
                    MessageBox.Show("There is no image to save. Please use options panel to generate the steganographied image.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string ext = System.IO.Path.GetExtension(hostImagePath.Text).Substring(1);
                    saveModifiedImageAs.Filter = ext.ToUpper() + " Files|*." + ext;
                    if (saveModifiedImageAs.ShowDialog() == DialogResult.OK)
                        modifiedImage.Save(saveModifiedImageAs.FileName, System.Drawing.Imaging.ImageFormat.Png);
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
                    modifiedImage = null;
                    return;
                }

                hostImage = new Bitmap(hostImagePath.Text);
                byte[] data = new byte[0];
                string ext = "";
                if (fileOption.Checked && fileOptionFilePath.Text.Length > 0)
                {
                    data = System.IO.File.ReadAllBytes(fileOptionFilePath.Text);
                    ext = System.IO.Path.GetExtension(fileOptionFilePath.Text).Substring(1);
                }
                else
                {
                    data = Encoding.UTF8.GetBytes(textData.Text);
                    ext = "txt";

                }
                modifiedImage = null;
                try
                {
                    bool aesEncryption = false;
                    this.Invoke((MethodInvoker)delegate()
                    {
                        aesEncryption = encryptionType.SelectedIndex == 1;
                    });

                    modifiedImage = Steganography.hideData(hostImage,
                        data,
                        ext,
                        redCheckbox.Checked,
                        greenCheckbox.Checked,
                        blueCheckbox.Checked,
                        alphaCheckbox.Checked,
                        (int)NumberOfBitsInput.Value,
                        aesEncryption,
                        encryptionPassword.Text);
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
        #endregion

    }
}
