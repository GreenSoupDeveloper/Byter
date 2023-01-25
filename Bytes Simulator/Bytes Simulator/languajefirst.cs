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

namespace Bytes_Simulator
{
    public partial class languajefirst : Form
    {
        public languajefirst()
        {
            InitializeComponent();
           
            File.Delete(@"C:\byter\firstlang.null");

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "English")
            {
                File.WriteAllText(@"C:\byter\byterconfig.txt", "language: english");

            }
            if (comboBox1.SelectedItem == "Español")
            {
                File.WriteAllText(@"C:\byter\byterconfig.txt", "language: español");

            }
            MessageBox.Show("To apply the changes, you have to reset Byter \n\nPara aplicar los cambios, debes reiniciar Byter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
