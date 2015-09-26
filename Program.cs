using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace images_steganography
{
    static class Program
    {
        public static Steganography_form steganography_form;
        public static Unsteganography_form unsteganography_form;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            steganography_form = new Steganography_form();
            unsteganography_form = new Unsteganography_form();
            Application.Run(new mainForm());
        }
    }
}
