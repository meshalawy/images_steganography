using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace images_steganography
{
    public partial class mainForm : Form
    {
        private static String LOGO_FILE_NAME = "logo";
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting the logo
            try
            {
                Bitmap logo = new Bitmap(LOGO_FILE_NAME);
                logoPictureBox.Image = logo;
            }
            catch (Exception) { }//do nothing

            openForm(Program.steganography_form);
            openForm(Program.unsteganography_form);
            Program.steganography_form.Focus();
        }

        private void openForm(Form child)
        {
            child.Dock = DockStyle.Fill;
            child.MdiParent = this;
           
           
            child.Show();
            child.Focus();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (selectLogoDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newImage = new Bitmap(selectLogoDialog.FileName);
                    logoPictureBox.Image = newImage;
                    newImage.Save(LOGO_FILE_NAME);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "تعذر تحميل الصورة من الملف المحدد ، قد لا يمثل الملف المحدد صورة صالحة أو قد يكون الملف معطوباً", "صورة غير صالحة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
        }

    }
}
