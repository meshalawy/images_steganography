namespace images_steganography
{
    partial class Steganography_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Steganography_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.modifiedImagePreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showOriginalImage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hostImagePreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.encryptionPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.fileOptionFilePath = new System.Windows.Forms.TextBox();
            this.importTextFromFileButton = new System.Windows.Forms.Button();
            this.textData = new System.Windows.Forms.TextBox();
            this.fileOption = new System.Windows.Forms.RadioButton();
            this.selectFileForFileOption = new System.Windows.Forms.Button();
            this.textOption = new System.Windows.Forms.RadioButton();
            this.alphaCheckbox = new System.Windows.Forms.CheckBox();
            this.encryptionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hostImagePath = new System.Windows.Forms.TextBox();
            this.NumberOfBitsInput = new System.Windows.Forms.NumericUpDown();
            this.selectHostImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.redCheckbox = new System.Windows.Forms.CheckBox();
            this.greenCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.blueCheckbox = new System.Windows.Forms.CheckBox();
            this.selectHostImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveModifiedImageAs = new System.Windows.Forms.SaveFileDialog();
            this.warningBox1 = new DevComponents.DotNetBar.Controls.WarningBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImagePreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostImagePreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBitsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.modifiedImagePreview, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hostImagePreview, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 320);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // modifiedImagePreview
            // 
            this.modifiedImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modifiedImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modifiedImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifiedImagePreview.Location = new System.Drawing.Point(431, 43);
            this.modifiedImagePreview.Name = "modifiedImagePreview";
            this.modifiedImagePreview.Size = new System.Drawing.Size(423, 274);
            this.modifiedImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modifiedImagePreview.TabIndex = 2;
            this.modifiedImagePreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveAsButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.showOriginalImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(431, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 34);
            this.panel1.TabIndex = 3;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAsButton.Location = new System.Drawing.Point(249, 8);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(71, 23);
            this.saveAsButton.TabIndex = 20;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resulted Image:";
            // 
            // showOriginalImage
            // 
            this.showOriginalImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showOriginalImage.Image = ((System.Drawing.Image)(resources.GetObject("showOriginalImage.Image")));
            this.showOriginalImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showOriginalImage.Location = new System.Drawing.Point(326, 8);
            this.showOriginalImage.Name = "showOriginalImage";
            this.showOriginalImage.Size = new System.Drawing.Size(94, 23);
            this.showOriginalImage.TabIndex = 19;
            this.showOriginalImage.Text = "Show Original";
            this.showOriginalImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showOriginalImage.UseVisualStyleBackColor = true;
            this.showOriginalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showOriginalImage_MouseDown);
            this.showOriginalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showOriginalImage_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 34);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Host Image:";
            // 
            // hostImagePreview
            // 
            this.hostImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hostImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hostImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostImagePreview.Location = new System.Drawing.Point(3, 43);
            this.hostImagePreview.Name = "hostImagePreview";
            this.hostImagePreview.Size = new System.Drawing.Size(422, 274);
            this.hostImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hostImagePreview.TabIndex = 0;
            this.hostImagePreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.encryptionPassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.alphaCheckbox);
            this.groupBox2.Controls.Add(this.encryptionType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hostImagePath);
            this.groupBox2.Controls.Add(this.NumberOfBitsInput);
            this.groupBox2.Controls.Add(this.selectHostImageButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.redCheckbox);
            this.groupBox2.Controls.Add(this.greenCheckbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.blueCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 224);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // encryptionPassword
            // 
            this.encryptionPassword.Enabled = false;
            this.encryptionPassword.Location = new System.Drawing.Point(105, 156);
            this.encryptionPassword.Name = "encryptionPassword";
            this.encryptionPassword.Size = new System.Drawing.Size(100, 20);
            this.encryptionPassword.TabIndex = 20;
            this.encryptionPassword.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Key:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.fileOptionFilePath);
            this.panel2.Controls.Add(this.importTextFromFileButton);
            this.panel2.Controls.Add(this.textData);
            this.panel2.Controls.Add(this.fileOption);
            this.panel2.Controls.Add(this.selectFileForFileOption);
            this.panel2.Controls.Add(this.textOption);
            this.panel2.Location = new System.Drawing.Point(471, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 194);
            this.panel2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data To Hide:";
            // 
            // fileOptionFilePath
            // 
            this.fileOptionFilePath.Location = new System.Drawing.Point(87, 22);
            this.fileOptionFilePath.Name = "fileOptionFilePath";
            this.fileOptionFilePath.ReadOnly = true;
            this.fileOptionFilePath.Size = new System.Drawing.Size(210, 20);
            this.fileOptionFilePath.TabIndex = 13;
            this.fileOptionFilePath.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // importTextFromFileButton
            // 
            this.importTextFromFileButton.Image = ((System.Drawing.Image)(resources.GetObject("importTextFromFileButton.Image")));
            this.importTextFromFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importTextFromFileButton.Location = new System.Drawing.Point(87, 59);
            this.importTextFromFileButton.Name = "importTextFromFileButton";
            this.importTextFromFileButton.Size = new System.Drawing.Size(126, 23);
            this.importTextFromFileButton.TabIndex = 12;
            this.importTextFromFileButton.Text = "Import From Text File";
            this.importTextFromFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importTextFromFileButton.UseVisualStyleBackColor = true;
            this.importTextFromFileButton.Click += new System.EventHandler(this.importTextFromFileButton_Click);
            // 
            // textData
            // 
            this.textData.AcceptsReturn = true;
            this.textData.AcceptsTab = true;
            this.textData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textData.Location = new System.Drawing.Point(6, 85);
            this.textData.Multiline = true;
            this.textData.Name = "textData";
            this.textData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textData.Size = new System.Drawing.Size(383, 99);
            this.textData.TabIndex = 2;
            this.textData.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // fileOption
            // 
            this.fileOption.AutoSize = true;
            this.fileOption.Location = new System.Drawing.Point(6, 23);
            this.fileOption.Name = "fileOption";
            this.fileOption.Size = new System.Drawing.Size(44, 17);
            this.fileOption.TabIndex = 1;
            this.fileOption.Text = "File:";
            this.fileOption.UseVisualStyleBackColor = true;
            this.fileOption.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // selectFileForFileOption
            // 
            this.selectFileForFileOption.Image = ((System.Drawing.Image)(resources.GetObject("selectFileForFileOption.Image")));
            this.selectFileForFileOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFileForFileOption.Location = new System.Drawing.Point(315, 20);
            this.selectFileForFileOption.Name = "selectFileForFileOption";
            this.selectFileForFileOption.Size = new System.Drawing.Size(69, 23);
            this.selectFileForFileOption.TabIndex = 14;
            this.selectFileForFileOption.Text = "Browse";
            this.selectFileForFileOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectFileForFileOption.UseVisualStyleBackColor = true;
            this.selectFileForFileOption.Click += new System.EventHandler(this.selectFileForFileOption_Click);
            // 
            // textOption
            // 
            this.textOption.AutoSize = true;
            this.textOption.Checked = true;
            this.textOption.Location = new System.Drawing.Point(6, 62);
            this.textOption.Name = "textOption";
            this.textOption.Size = new System.Drawing.Size(49, 17);
            this.textOption.TabIndex = 0;
            this.textOption.TabStop = true;
            this.textOption.Text = "Text:";
            this.textOption.UseVisualStyleBackColor = true;
            this.textOption.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // alphaCheckbox
            // 
            this.alphaCheckbox.AutoSize = true;
            this.alphaCheckbox.Checked = true;
            this.alphaCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaCheckbox.Location = new System.Drawing.Point(312, 55);
            this.alphaCheckbox.Name = "alphaCheckbox";
            this.alphaCheckbox.Size = new System.Drawing.Size(53, 17);
            this.alphaCheckbox.TabIndex = 18;
            this.alphaCheckbox.Text = "Alpha";
            this.alphaCheckbox.UseVisualStyleBackColor = true;
            this.alphaCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // encryptionType
            // 
            this.encryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptionType.FormattingEnabled = true;
            this.encryptionType.Items.AddRange(new object[] {
            "None",
            "Advanced Encryption Standard (AES)"});
            this.encryptionType.Location = new System.Drawing.Point(105, 118);
            this.encryptionType.Name = "encryptionType";
            this.encryptionType.Size = new System.Drawing.Size(210, 21);
            this.encryptionType.TabIndex = 17;
            this.encryptionType.SelectedIndexChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Encryption:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host Image:";
            // 
            // hostImagePath
            // 
            this.hostImagePath.Location = new System.Drawing.Point(105, 17);
            this.hostImagePath.Name = "hostImagePath";
            this.hostImagePath.ReadOnly = true;
            this.hostImagePath.Size = new System.Drawing.Size(210, 20);
            this.hostImagePath.TabIndex = 1;
            this.hostImagePath.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // NumberOfBitsInput
            // 
            this.NumberOfBitsInput.Location = new System.Drawing.Point(105, 85);
            this.NumberOfBitsInput.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumberOfBitsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfBitsInput.Name = "NumberOfBitsInput";
            this.NumberOfBitsInput.Size = new System.Drawing.Size(36, 20);
            this.NumberOfBitsInput.TabIndex = 11;
            this.NumberOfBitsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfBitsInput.ValueChanged += new System.EventHandler(this.optionsChanged);
            // 
            // selectHostImageButton
            // 
            this.selectHostImageButton.Image = ((System.Drawing.Image)(resources.GetObject("selectHostImageButton.Image")));
            this.selectHostImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectHostImageButton.Location = new System.Drawing.Point(321, 15);
            this.selectHostImageButton.Name = "selectHostImageButton";
            this.selectHostImageButton.Size = new System.Drawing.Size(69, 23);
            this.selectHostImageButton.TabIndex = 3;
            this.selectHostImageButton.Text = "Browse";
            this.selectHostImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectHostImageButton.UseVisualStyleBackColor = true;
            this.selectHostImageButton.Click += new System.EventHandler(this.selectHostImageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bits Per Pixel:";
            // 
            // redCheckbox
            // 
            this.redCheckbox.AutoSize = true;
            this.redCheckbox.Checked = true;
            this.redCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redCheckbox.Location = new System.Drawing.Point(105, 55);
            this.redCheckbox.Name = "redCheckbox";
            this.redCheckbox.Size = new System.Drawing.Size(46, 17);
            this.redCheckbox.TabIndex = 4;
            this.redCheckbox.Text = "Red";
            this.redCheckbox.UseVisualStyleBackColor = true;
            this.redCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // greenCheckbox
            // 
            this.greenCheckbox.AutoSize = true;
            this.greenCheckbox.Checked = true;
            this.greenCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenCheckbox.Location = new System.Drawing.Point(174, 55);
            this.greenCheckbox.Name = "greenCheckbox";
            this.greenCheckbox.Size = new System.Drawing.Size(55, 17);
            this.greenCheckbox.TabIndex = 5;
            this.greenCheckbox.Text = "Green";
            this.greenCheckbox.UseVisualStyleBackColor = true;
            this.greenCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Colors To Use:";
            // 
            // blueCheckbox
            // 
            this.blueCheckbox.AutoSize = true;
            this.blueCheckbox.Checked = true;
            this.blueCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueCheckbox.Location = new System.Drawing.Point(248, 55);
            this.blueCheckbox.Name = "blueCheckbox";
            this.blueCheckbox.Size = new System.Drawing.Size(47, 17);
            this.blueCheckbox.TabIndex = 6;
            this.blueCheckbox.Text = "Blue";
            this.blueCheckbox.UseVisualStyleBackColor = true;
            this.blueCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // selectHostImageDialog
            // 
            this.selectHostImageDialog.Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.pn" +
    "g;";
            this.selectHostImageDialog.Title = "Select The Host Image:";
            // 
            // selectDataFileDialog
            // 
            this.selectDataFileDialog.Filter = "All Files|*.*";
            this.selectDataFileDialog.Title = "Select File To Hide In The Image:";
            // 
            // selectTextFileDialog
            // 
            this.selectTextFileDialog.Filter = "Text Files|*.txt";
            this.selectTextFileDialog.Title = "Select Text File To Import:";
            // 
            // saveModifiedImageAs
            // 
            this.saveModifiedImageAs.DefaultExt = "JPG";
            this.saveModifiedImageAs.FileName = "Image";
            this.saveModifiedImageAs.Title = "Save Steganographied Image As:";
            // 
            // warningBox1
            // 
            this.warningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.warningBox1.CloseButtonVisible = false;
            this.warningBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.warningBox1.Image = ((System.Drawing.Image)(resources.GetObject("warningBox1.Image")));
            this.warningBox1.Location = new System.Drawing.Point(0, 0);
            this.warningBox1.Name = "warningBox1";
            this.warningBox1.OptionsButtonVisible = false;
            this.warningBox1.Size = new System.Drawing.Size(900, 33);
            this.warningBox1.TabIndex = 27;
            this.warningBox1.Text = "<b>Warning Box</b> control with <i>text-markup</i> support.";
            this.warningBox1.Visible = false;
            // 
            // Steganography_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.warningBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Steganography_form";
            this.Text = "Hide Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImagePreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostImagePreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBitsInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectHostImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostImagePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox blueCheckbox;
        private System.Windows.Forms.CheckBox greenCheckbox;
        private System.Windows.Forms.CheckBox redCheckbox;
        private System.Windows.Forms.NumericUpDown NumberOfBitsInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.RadioButton fileOption;
        private System.Windows.Forms.RadioButton textOption;
        private System.Windows.Forms.Button importTextFromFileButton;
        private System.Windows.Forms.Button selectFileForFileOption;
        private System.Windows.Forms.TextBox fileOptionFilePath;
        private System.Windows.Forms.OpenFileDialog selectHostImageDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox encryptionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hostImagePreview;
        private System.Windows.Forms.PictureBox modifiedImagePreview;
        private System.Windows.Forms.CheckBox alphaCheckbox;
        private System.Windows.Forms.OpenFileDialog selectDataFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showOriginalImage;
        private System.Windows.Forms.OpenFileDialog selectTextFileDialog;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.SaveFileDialog saveModifiedImageAs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.WarningBox warningBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox encryptionPassword;
    }
}

