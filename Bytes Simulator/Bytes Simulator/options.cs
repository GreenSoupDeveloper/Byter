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
    public partial class options : Form
    {
        public string expfuncbox;
        public options()
        {
            InitializeComponent();
            #region languages
            if (File.ReadAllText(@"C:\byter\byterconfig.txt") == "language: english")
            {
                label1.Text = "Language: ";
                groupBox1.Text = "Options";
                checkBox1.Text = "Experimental Functions";
                label2.Text = "The Experimental functions are Beta addings that \n"+
 "are'nt finished, that are going to be included in later \n" +
"versions of Byter";
                expfuncbox = "To apply the changes, you have to reset Byter";
                label3.Text = "You need to restart Byter to apply the changes";
            }
            if (File.ReadAllText(@"C:\byter\byterconfig.txt") == "language: español")
            {
                label1.Text = "Idioma: ";
                groupBox1.Text = "Opciones";
                checkBox1.Text = "Funciones Experimentales";
                label2.Text = "Las Funciones Experimentales son añadidos Beta que \n" +
"no estan terminados, que van a ser incluidos en futuras \n" +
"versiones de Byter";
                expfuncbox = "Para aplicar los cambios, debes reiniciar Byter";
                label3.Text = "Debes reiniciar Byter para aplicar los cambios";


            }
            if (File.ReadAllText(@"C:\byter\byterbetafunconfig.txt") == "experimental functions: true")
            {
                checkBox1.Checked = true;
            }
            if (File.ReadAllText(@"C:\byter\byterbetafunconfig.txt") == "experimental functions: false")
            {
                checkBox1.Checked = false;

            }
            #endregion
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Form1 mainform = new Form1();


            if (comboBox1.SelectedItem == "English")
            {
                File.WriteAllText(@"C:\byter\byterconfig.txt", "language: english");
                MessageBox.Show("To apply the changes, you have to reset Byter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (comboBox1.SelectedItem == "Español")
            {
                File.WriteAllText(@"C:\byter\byterconfig.txt", "language: español");
                MessageBox.Show("Para aplicar los cambios, debes reiniciar Byter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)           
        {
           //MessageBox.Show(expfuncbox, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (checkBox1.Checked == true)
            {
                File.WriteAllText(@"C:\byter\byterbetafunconfig.txt", "experimental functions: true");
            }
            if (checkBox1.Checked == false)
            {
                File.WriteAllText(@"C:\byter\byterbetafunconfig.txt", "experimental functions: false");
            }
           
        }
     
    }
}
