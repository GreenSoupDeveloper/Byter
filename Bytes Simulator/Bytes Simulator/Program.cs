using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace Bytes_Simulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(@"C:\byter"))
            {
                Directory.CreateDirectory(@"C:\byter");
                File.Create(@"C:\byter\byterconfig.txt");

                File.Create(@"C:\byter\byterbetafunconfig.txt");
                File.Create(@"C:\byter\firstlang.null");
                MessageBox.Show("Now, open the program again\n\nAhora, abre el programa otra vez", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                Application.Exit();
                Application.Exit();

                Application.Exit();
                Application.Exit(); Application.Exit();
                Application.Exit();
                Application.Exit();
                Application.Exit();

                Application.Exit();
                Application.Exit();

            }

            if (File.Exists(@"C:\byter\firstlang.null"))
            {
                Application.Run(new languajefirst());


            }

            if (Directory.Exists(@"C:\byter") && !File.Exists(@"C:\byter\firstlang.null"))
            {
                Application.Run(new Form1());
            }
           
        }
    }
}
