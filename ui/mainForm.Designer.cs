namespace images_steganography
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectLogoDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Text = "ribbonTabItem2";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Text = "ribbonTabItem1";
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = false;
            this.tabStrip1.CloseButtonVisible = true;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabStrip1.Location = new System.Drawing.Point(0, 689);
            this.tabStrip1.MdiForm = this;
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = this.tabItem1;
            this.tabStrip1.Size = new System.Drawing.Size(934, 23);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.RoundHeader;
            this.tabStrip1.TabIndex = 1;
            this.tabStrip1.Tabs.Add(this.tabItem1);
            this.tabStrip1.Text = "tabStrip1";
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(934, 90);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 7;
            this.logoPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.logoPictureBox, "انقر نقراً مزدوجاً لتغيير صورة الشعار");
            this.logoPictureBox.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // selectLogoDialog
            // 
            this.selectLogoDialog.Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.pn" +
    "g;";
            this.selectLogoDialog.Title = "اختر صورة لتعيينها كشعار:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 712);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 750);
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog selectLogoDialog;

    }
}