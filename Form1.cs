using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace images_steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program.steganography_form.MdiParent = this;
            
            openForm(Program.steganography_form);
            openForm(Program.unsteganography_form);
            Program.steganography_form.Focus();
           // Convert.ToUInt32(System.Text.Encoding.UTF8.GetBytes("A"));
        }

        private void openForm(Form child)
        {
            child.Dock = DockStyle.Fill;
            child.MdiParent = this;
           
           
            child.Show();
            child.Focus();
        }

    }
}
