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
using Bytes_Simulator;

namespace Bytes_Simulator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            #region languages
            if (File.ReadAllText(@"C:\byter\byterconfig.txt") == "language: english")
            {
                label5.Text = "By: GreenSoupDeveloper";
                label3.Text = "Thanks for using Byter! hope you're enjoying it";
                linkLabel1.Text = "My GitHub: https://github.com/GreenSoupDeveloper";
            }
            if (File.ReadAllText(@"C:\byter\byterconfig.txt") == "language: español")
            {

                label5.Text = "Por: GreenSoupDeveloper";
                label3.Text = "Gracias por usar Byter! espero que lo estes disfrutando :)";
                linkLabel1.Text = "Mi GitHub: https://github.com/GreenSoupDeveloper";

            }
            #endregion
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
