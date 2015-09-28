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
            this.loading = new System.Windows.Forms.PictureBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showOriginalImage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hostImagePreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.threadsCountLabel = new System.Windows.Forms.Label();
            this.threadsSlider = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.hostImagePath = new System.Windows.Forms.Label();
            this.encryptionPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileOptionFilePath = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.importTextFromFileButton = new System.Windows.Forms.Button();
            this.textData = new System.Windows.Forms.TextBox();
            this.fileOption = new System.Windows.Forms.RadioButton();
            this.selectFileForFileOption = new System.Windows.Forms.Button();
            this.textOption = new System.Windows.Forms.RadioButton();
            this.alphaCheckbox = new System.Windows.Forms.CheckBox();
            this.encryptionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostImagePreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsSlider)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعاينة";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 305);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // modifiedImagePreview
            // 
            this.modifiedImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modifiedImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modifiedImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifiedImagePreview.Location = new System.Drawing.Point(3, 43);
            this.modifiedImagePreview.Name = "modifiedImagePreview";
            this.modifiedImagePreview.Size = new System.Drawing.Size(423, 259);
            this.modifiedImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modifiedImagePreview.TabIndex = 2;
            this.modifiedImagePreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loading);
            this.panel1.Controls.Add(this.saveAsButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.showOriginalImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 34);
            this.panel1.TabIndex = 3;
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(179, 1);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(34, 33);
            this.loading.TabIndex = 21;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAsButton.Location = new System.Drawing.Point(96, 8);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(77, 23);
            this.saveAsButton.TabIndex = 2;
            this.saveAsButton.Text = "حفظ باسم";
            this.saveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "الصورة الناتجة:";
            // 
            // showOriginalImage
            // 
            this.showOriginalImage.Image = ((System.Drawing.Image)(resources.GetObject("showOriginalImage.Image")));
            this.showOriginalImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showOriginalImage.Location = new System.Drawing.Point(6, 8);
            this.showOriginalImage.Name = "showOriginalImage";
            this.showOriginalImage.Size = new System.Drawing.Size(84, 23);
            this.showOriginalImage.TabIndex = 3;
            this.showOriginalImage.Text = "أظهر الأصل";
            this.showOriginalImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showOriginalImage.UseVisualStyleBackColor = true;
            this.showOriginalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showOriginalImage_MouseDown);
            this.showOriginalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showOriginalImage_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(432, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 34);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "الصورة المُضيفة:";
            // 
            // hostImagePreview
            // 
            this.hostImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hostImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hostImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostImagePreview.Location = new System.Drawing.Point(432, 43);
            this.hostImagePreview.Name = "hostImagePreview";
            this.hostImagePreview.Size = new System.Drawing.Size(422, 259);
            this.hostImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hostImagePreview.TabIndex = 0;
            this.hostImagePreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.threadsCountLabel);
            this.groupBox2.Controls.Add(this.threadsSlider);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.hostImagePath);
            this.groupBox2.Controls.Add(this.encryptionPassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.alphaCheckbox);
            this.groupBox2.Controls.Add(this.encryptionType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NumberOfBitsInput);
            this.groupBox2.Controls.Add(this.selectHostImageButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.redCheckbox);
            this.groupBox2.Controls.Add(this.greenCheckbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.blueCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(878, 239);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "خيارات";
            // 
            // threadsCountLabel
            // 
            this.threadsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.threadsCountLabel.AutoSize = true;
            this.threadsCountLabel.Location = new System.Drawing.Point(720, 198);
            this.threadsCountLabel.Name = "threadsCountLabel";
            this.threadsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.threadsCountLabel.TabIndex = 24;
            this.threadsCountLabel.Text = "8";
            // 
            // threadsSlider
            // 
            this.threadsSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.threadsSlider.BackColor = System.Drawing.Color.White;
            this.threadsSlider.Location = new System.Drawing.Point(553, 190);
            this.threadsSlider.Maximum = 16;
            this.threadsSlider.Minimum = 1;
            this.threadsSlider.Name = "threadsSlider";
            this.threadsSlider.Size = new System.Drawing.Size(160, 45);
            this.threadsSlider.TabIndex = 23;
            this.threadsSlider.Value = 8;
            this.threadsSlider.Scroll += new System.EventHandler(this.threadsSlider_Scroll);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "عدد المسارات (Threads) :";
            // 
            // hostImagePath
            // 
            this.hostImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hostImagePath.AutoEllipsis = true;
            this.hostImagePath.Location = new System.Drawing.Point(462, 24);
            this.hostImagePath.Name = "hostImagePath";
            this.hostImagePath.Size = new System.Drawing.Size(226, 23);
            this.hostImagePath.TabIndex = 21;
            this.hostImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hostImagePath.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // encryptionPassword
            // 
            this.encryptionPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptionPassword.Enabled = false;
            this.encryptionPassword.Location = new System.Drawing.Point(663, 161);
            this.encryptionPassword.Name = "encryptionPassword";
            this.encryptionPassword.Size = new System.Drawing.Size(100, 20);
            this.encryptionPassword.TabIndex = 12;
            this.encryptionPassword.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "مفتاح التشفير:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.fileOptionFilePath);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.importTextFromFileButton);
            this.panel2.Controls.Add(this.textData);
            this.panel2.Controls.Add(this.fileOption);
            this.panel2.Controls.Add(this.selectFileForFileOption);
            this.panel2.Controls.Add(this.textOption);
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 194);
            this.panel2.TabIndex = 13;
            // 
            // fileOptionFilePath
            // 
            this.fileOptionFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileOptionFilePath.AutoEllipsis = true;
            this.fileOptionFilePath.Location = new System.Drawing.Point(6, 33);
            this.fileOptionFilePath.Name = "fileOptionFilePath";
            this.fileOptionFilePath.Size = new System.Drawing.Size(239, 23);
            this.fileOptionFilePath.TabIndex = 22;
            this.fileOptionFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileOptionFilePath.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "البيانات المطلوب إخفاءها:";
            // 
            // importTextFromFileButton
            // 
            this.importTextFromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importTextFromFileButton.Image = ((System.Drawing.Image)(resources.GetObject("importTextFromFileButton.Image")));
            this.importTextFromFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importTextFromFileButton.Location = new System.Drawing.Point(194, 56);
            this.importTextFromFileButton.Name = "importTextFromFileButton";
            this.importTextFromFileButton.Size = new System.Drawing.Size(126, 23);
            this.importTextFromFileButton.TabIndex = 18;
            this.importTextFromFileButton.Text = "استيراد من ملف نَصَي";
            this.importTextFromFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.textData.TabIndex = 19;
            this.textData.TextChanged += new System.EventHandler(this.optionsChanged);
            // 
            // fileOption
            // 
            this.fileOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileOption.AutoSize = true;
            this.fileOption.Location = new System.Drawing.Point(344, 33);
            this.fileOption.Name = "fileOption";
            this.fileOption.Size = new System.Drawing.Size(45, 17);
            this.fileOption.TabIndex = 15;
            this.fileOption.TabStop = true;
            this.fileOption.Text = "ملف:";
            this.fileOption.UseVisualStyleBackColor = true;
            this.fileOption.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // selectFileForFileOption
            // 
            this.selectFileForFileOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileForFileOption.Image = ((System.Drawing.Image)(resources.GetObject("selectFileForFileOption.Image")));
            this.selectFileForFileOption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectFileForFileOption.Location = new System.Drawing.Point(245, 30);
            this.selectFileForFileOption.Name = "selectFileForFileOption";
            this.selectFileForFileOption.Size = new System.Drawing.Size(75, 23);
            this.selectFileForFileOption.TabIndex = 16;
            this.selectFileForFileOption.Text = "استعراض";
            this.selectFileForFileOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFileForFileOption.UseVisualStyleBackColor = true;
            this.selectFileForFileOption.Click += new System.EventHandler(this.selectFileForFileOption_Click);
            // 
            // textOption
            // 
            this.textOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textOption.AutoSize = true;
            this.textOption.Checked = true;
            this.textOption.Location = new System.Drawing.Point(346, 59);
            this.textOption.Name = "textOption";
            this.textOption.Size = new System.Drawing.Size(43, 17);
            this.textOption.TabIndex = 17;
            this.textOption.TabStop = true;
            this.textOption.Text = "نَص:";
            this.textOption.UseVisualStyleBackColor = true;
            this.textOption.CheckedChanged += new System.EventHandler(this.textOption_CheckedChanged);
            // 
            // alphaCheckbox
            // 
            this.alphaCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaCheckbox.AutoSize = true;
            this.alphaCheckbox.Checked = true;
            this.alphaCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaCheckbox.Location = new System.Drawing.Point(462, 60);
            this.alphaCheckbox.Name = "alphaCheckbox";
            this.alphaCheckbox.Size = new System.Drawing.Size(91, 17);
            this.alphaCheckbox.TabIndex = 6;
            this.alphaCheckbox.Text = "ألفا (الشفافية)";
            this.alphaCheckbox.UseVisualStyleBackColor = true;
            this.alphaCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // encryptionType
            // 
            this.encryptionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptionType.FormattingEnabled = true;
            this.encryptionType.ItemHeight = 13;
            this.encryptionType.Items.AddRange(new object[] {
            "بدون",
            "المعيار المتقدم للتشفير (AES)"});
            this.encryptionType.Location = new System.Drawing.Point(553, 123);
            this.encryptionType.Name = "encryptionType";
            this.encryptionType.Size = new System.Drawing.Size(210, 21);
            this.encryptionType.TabIndex = 10;
            this.encryptionType.SelectedIndexChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "التشفير:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصورة المُضيفة:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumberOfBitsInput
            // 
            this.NumberOfBitsInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfBitsInput.Location = new System.Drawing.Point(727, 90);
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
            this.NumberOfBitsInput.TabIndex = 8;
            this.NumberOfBitsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfBitsInput.ValueChanged += new System.EventHandler(this.optionsChanged);
            // 
            // selectHostImageButton
            // 
            this.selectHostImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectHostImageButton.Image = ((System.Drawing.Image)(resources.GetObject("selectHostImageButton.Image")));
            this.selectHostImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectHostImageButton.Location = new System.Drawing.Point(689, 20);
            this.selectHostImageButton.Name = "selectHostImageButton";
            this.selectHostImageButton.Size = new System.Drawing.Size(75, 23);
            this.selectHostImageButton.TabIndex = 1;
            this.selectHostImageButton.Text = "استعراض";
            this.selectHostImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectHostImageButton.UseVisualStyleBackColor = true;
            this.selectHostImageButton.Click += new System.EventHandler(this.selectHostImageButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "بت/بكسل:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redCheckbox
            // 
            this.redCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redCheckbox.AutoSize = true;
            this.redCheckbox.Checked = true;
            this.redCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redCheckbox.Location = new System.Drawing.Point(574, 60);
            this.redCheckbox.Name = "redCheckbox";
            this.redCheckbox.Size = new System.Drawing.Size(48, 17);
            this.redCheckbox.TabIndex = 5;
            this.redCheckbox.Text = "أحمر";
            this.redCheckbox.UseVisualStyleBackColor = true;
            this.redCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // greenCheckbox
            // 
            this.greenCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.greenCheckbox.AutoSize = true;
            this.greenCheckbox.Checked = true;
            this.greenCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenCheckbox.Location = new System.Drawing.Point(643, 60);
            this.greenCheckbox.Name = "greenCheckbox";
            this.greenCheckbox.Size = new System.Drawing.Size(52, 17);
            this.greenCheckbox.TabIndex = 4;
            this.greenCheckbox.Text = "أخضر";
            this.greenCheckbox.UseVisualStyleBackColor = true;
            this.greenCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "الألوان المستخدمة:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueCheckbox
            // 
            this.blueCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueCheckbox.AutoSize = true;
            this.blueCheckbox.Checked = true;
            this.blueCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueCheckbox.Location = new System.Drawing.Point(716, 60);
            this.blueCheckbox.Name = "blueCheckbox";
            this.blueCheckbox.Size = new System.Drawing.Size(49, 17);
            this.blueCheckbox.TabIndex = 3;
            this.blueCheckbox.Text = "أزرق";
            this.blueCheckbox.UseVisualStyleBackColor = true;
            this.blueCheckbox.CheckedChanged += new System.EventHandler(this.optionsChanged);
            // 
            // selectHostImageDialog
            // 
            this.selectHostImageDialog.Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.pn" +
    "g;";
            this.selectHostImageDialog.Title = "اختر الصورة المُضيفة:";
            // 
            // selectDataFileDialog
            // 
            this.selectDataFileDialog.Filter = "All Files|*.*";
            this.selectDataFileDialog.Title = "اختر ملفاُ لإخفائه داخل الصورة:";
            // 
            // selectTextFileDialog
            // 
            this.selectTextFileDialog.Filter = "Text Files|*.txt";
            this.selectTextFileDialog.Title = "اختر ملفاُ نصياً لاستيراده:";
            // 
            // saveModifiedImageAs
            // 
            this.saveModifiedImageAs.DefaultExt = "JPG";
            this.saveModifiedImageAs.FileName = "Image";
            this.saveModifiedImageAs.Title = "حفظ الصورة الناتجة:";
            // 
            // warningBox1
            // 
            this.warningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(249)))));
            this.warningBox1.CloseButtonVisible = false;
            this.warningBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.warningBox1.Image = ((System.Drawing.Image)(resources.GetObject("warningBox1.Image")));
            this.warningBox1.Location = new System.Drawing.Point(0, 0);
            this.warningBox1.Name = "warningBox1";
            this.warningBox1.OptionsButtonVisible = false;
            this.warningBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.warningBox1.Size = new System.Drawing.Size(900, 33);
            this.warningBox1.TabIndex = 27;
            this.warningBox1.TabStop = false;
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
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اخفاء البيانات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImagePreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostImagePreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsSlider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBitsInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectHostImageButton;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label hostImagePath;
        private System.Windows.Forms.Label fileOptionFilePath;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.TrackBar threadsSlider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label threadsCountLabel;
    }
}

