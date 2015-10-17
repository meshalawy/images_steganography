namespace images_steganography
{
    partial class Unsteganography_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unsteganography_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.extractedTextPreview = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.hostImagePreview = new System.Windows.Forms.PictureBox();
            this.extractedImagePreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hostImagePath = new System.Windows.Forms.Label();
            this.encryptionPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alphaCheckbox = new System.Windows.Forms.CheckBox();
            this.encryptionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfBitsInput = new System.Windows.Forms.NumericUpDown();
            this.selectHostImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.redCheckbox = new System.Windows.Forms.CheckBox();
            this.greenCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blueCheckbox = new System.Windows.Forms.CheckBox();
            this.OpenExtractedFile = new System.Windows.Forms.Button();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPreview = new System.Windows.Forms.PictureBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.selectHostImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveExtractedDataAs = new System.Windows.Forms.SaveFileDialog();
            this.warningBox1 = new DevComponents.DotNetBar.Controls.WarningBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostImagePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedImagePreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBitsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel1.Controls.Add(this.extractedTextPreview, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hostImagePreview, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.extractedImagePreview, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 305);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // extractedTextPreview
            // 
            this.extractedTextPreview.AcceptsReturn = true;
            this.extractedTextPreview.AcceptsTab = true;
            this.extractedTextPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedTextPreview.Location = new System.Drawing.Point(3, 43);
            this.extractedTextPreview.Multiline = true;
            this.extractedTextPreview.Name = "extractedTextPreview";
            this.extractedTextPreview.ReadOnly = true;
            this.extractedTextPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.extractedTextPreview.Size = new System.Drawing.Size(423, 239);
            this.extractedTextPreview.TabIndex = 26;
            this.extractedTextPreview.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loading);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 34);
            this.panel1.TabIndex = 4;
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(34, 32);
            this.loading.TabIndex = 30;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "معاينة البيانات المُستخرجة:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(432, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 34);
            this.panel4.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "الصورة المُضيفة:";
            // 
            // hostImagePreview
            // 
            this.hostImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hostImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hostImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostImagePreview.Location = new System.Drawing.Point(432, 43);
            this.hostImagePreview.Name = "hostImagePreview";
            this.hostImagePreview.Size = new System.Drawing.Size(422, 239);
            this.hostImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hostImagePreview.TabIndex = 0;
            this.hostImagePreview.TabStop = false;
            // 
            // extractedImagePreview
            // 
            this.extractedImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.extractedImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.extractedImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedImagePreview.Location = new System.Drawing.Point(432, 288);
            this.extractedImagePreview.Name = "extractedImagePreview";
            this.extractedImagePreview.Size = new System.Drawing.Size(422, 14);
            this.extractedImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.extractedImagePreview.TabIndex = 21;
            this.extractedImagePreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.hostImagePath);
            this.groupBox2.Controls.Add(this.encryptionPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.alphaCheckbox);
            this.groupBox2.Controls.Add(this.encryptionType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NumberOfBitsInput);
            this.groupBox2.Controls.Add(this.selectHostImageButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.redCheckbox);
            this.groupBox2.Controls.Add(this.greenCheckbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.blueCheckbox);
            this.groupBox2.Controls.Add(this.OpenExtractedFile);
            this.groupBox2.Controls.Add(this.dataTypeLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.iconPreview);
            this.groupBox2.Controls.Add(this.saveAsButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 240);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "خيارات";
            // 
            // hostImagePath
            // 
            this.hostImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hostImagePath.AutoEllipsis = true;
            this.hostImagePath.Location = new System.Drawing.Point(462, 24);
            this.hostImagePath.Name = "hostImagePath";
            this.hostImagePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hostImagePath.Size = new System.Drawing.Size(226, 23);
            this.hostImagePath.TabIndex = 40;
            this.hostImagePath.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "مفتاح التشفير:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "الصورة المُضيفة:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "الألوان المستخدمة:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // OpenExtractedFile
            // 
            this.OpenExtractedFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenExtractedFile.Image")));
            this.OpenExtractedFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenExtractedFile.Location = new System.Drawing.Point(122, 169);
            this.OpenExtractedFile.Name = "OpenExtractedFile";
            this.OpenExtractedFile.Size = new System.Drawing.Size(54, 23);
            this.OpenExtractedFile.TabIndex = 16;
            this.OpenExtractedFile.Text = "فتح";
            this.OpenExtractedFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenExtractedFile.UseVisualStyleBackColor = true;
            this.OpenExtractedFile.Click += new System.EventHandler(this.OpenExtractedFile_Click);
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTypeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.dataTypeLabel.Location = new System.Drawing.Point(39, 130);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(135, 36);
            this.dataTypeLabel.TabIndex = 25;
            this.dataTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "البيانات التي تم العثور عليها:";
            // 
            // iconPreview
            // 
            this.iconPreview.Location = new System.Drawing.Point(61, 60);
            this.iconPreview.Name = "iconPreview";
            this.iconPreview.Size = new System.Drawing.Size(90, 67);
            this.iconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPreview.TabIndex = 23;
            this.iconPreview.TabStop = false;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAsButton.Location = new System.Drawing.Point(39, 169);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(77, 23);
            this.saveAsButton.TabIndex = 17;
            this.saveAsButton.Text = "حفظ باسم";
            this.saveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // selectHostImageDialog
            // 
            this.selectHostImageDialog.Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.pn" +
    "g;";
            this.selectHostImageDialog.Title = "اختر الصورة المُضيفة:";
            // 
            // saveExtractedDataAs
            // 
            this.saveExtractedDataAs.DefaultExt = "JPG";
            this.saveExtractedDataAs.FileName = "File";
            this.saveExtractedDataAs.Filter = "JPG Images|(*.jpg)";
            this.saveExtractedDataAs.Title = "حفظ البيانات المُستخرجة باسم:";
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
            this.warningBox1.Size = new System.Drawing.Size(900, 33);
            this.warningBox1.TabIndex = 26;
            this.warningBox1.TabStop = false;
            this.warningBox1.Text = "<b>Warning Box</b> control with <i>text-markup</i> support.";
            this.warningBox1.Visible = false;
            // 
            // Unsteganography_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.warningBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Unsteganography_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استخراج البيانات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostImagePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedImagePreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBitsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectHostImageDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox hostImagePreview;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.SaveFileDialog saveExtractedDataAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox iconPreview;
        private System.Windows.Forms.PictureBox extractedImagePreview;
        private System.Windows.Forms.Label dataTypeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.WarningBox warningBox1;
        private System.Windows.Forms.TextBox extractedTextPreview;
        private System.Windows.Forms.Button OpenExtractedFile;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label hostImagePath;
        private System.Windows.Forms.TextBox encryptionPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox alphaCheckbox;
        private System.Windows.Forms.ComboBox encryptionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberOfBitsInput;
        private System.Windows.Forms.Button selectHostImageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox redCheckbox;
        private System.Windows.Forms.CheckBox greenCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox blueCheckbox;
        private System.Windows.Forms.Label label8;
    }
}

