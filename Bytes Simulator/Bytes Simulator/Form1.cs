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
    public partial class Form1 : Form
    {
        public static int number8 = 0;
        public static int number7 = 0;
        public static int number6 = 0;
        public static int number5 = 0;
        public static int number4 = 0;
        public static int number3 = 0;
        public static int number2 = 0;
        public static int number1 = 0;

        #region 8bytes
        public static int number8y8 = 0;
        public static int number8y7 = 0;
        public static int number8y6 = 0;
        public static int number8y5 = 0;
        public static int number8y4 = 0;
        public static int number8y3 = 0;
        public static int number8y2 = 0;
        public static int number8y1 = 0;

        public static int number7y8 = 0;
        public static int number7y7 = 0;
        public static int number7y6 = 0;
        public static int number7y5 = 0;
        public static int number7y4 = 0;
        public static int number7y3 = 0;
        public static int number7y2 = 0;
        public static int number7y1 = 0;

        public static int number6y8 = 0;
        public static int number6y7 = 0;
        public static int number6y6 = 0;
        public static int number6y5 = 0;
        public static int number6y4 = 0;
        public static int number6y3 = 0;
        public static int number6y2 = 0;
        public static int number6y1 = 0;

        public static int number5y8 = 0;
        public static int number5y7 = 0;
        public static int number5y6 = 0;
        public static int number5y5 = 0;
        public static int number5y4 = 0;
        public static int number5y3 = 0;
        public static int number5y2 = 0;
        public static int number5y1 = 0;

        public static int number4y8 = 0;
        public static int number4y7 = 0;
        public static int number4y6 = 0;
        public static int number4y5 = 0;
        public static int number4y4 = 0;
        public static int number4y3 = 0;
        public static int number4y2 = 0;
        public static int number4y1 = 0;

        public static int number3y8 = 0;
        public static int number3y7 = 0;
        public static int number3y6 = 0;
        public static int number3y5 = 0;
        public static int number3y4 = 0;
        public static int number3y3 = 0;
        public static int number3y2 = 0;
        public static int number3y1 = 0;

        public static int number2y8 = 0;
        public static int number2y7 = 0;
        public static int number2y6 = 0;
        public static int number2y5 = 0;
        public static int number2y4 = 0;
        public static int number2y3 = 0;
        public static int number2y2 = 0;
        public static int number2y1 = 0;

        public static int number1y8 = 0;
        public static int number1y7 = 0;
        public static int number1y6 = 0;
        public static int number1y5 = 0;
        public static int number1y4 = 0;
        public static int number1y3 = 0;
        public static int number1y2 = 0;
        public static int number1y1 = 0;
        #endregion

        public static string binaryletterresult;

        

        public Form1()
        {
            InitializeComponent();
           
            
            #region languages
            if (Directory.Exists(@"C:\byter"))
            {
                if (File.ReadAllText(@"C:\byter\byterconfig.txt") == "language: english")
                {
                    groupBox2.Text = "ASCII To...";
                    asciitobinbox.Text = "ASCII To Binary";
                    asciitohexbox.Text = "ASCII To Hexadecimal";
                    optionsToolStripMenuItem.Text = "Options";
                    aboutToolStripMenuItem.Text = "About...";
                    button1.Text = "Clear";
                    label1.Text = "Type any character to have the Binary code of the character";
                    label6.Text = "Character";
                    label5.Text = "Binary";
                    binaryletterbutton.Text = "Result";
                    label7.Text = "Character";
                    hexletterbutton.Text = "Result";
                    labeldraw.Text = "Drawing";
                    clear8bytesburron.Text = "Clear";
                    label10.Text = "Type any character to have the HEX code of the character";
                }
                if (File.ReadAllText(@"C:\byter\byterconfig.txt") == "language: español")
                {
                    clear8bytesburron.Text = "Limpiar";
                    labeldraw.Text = "Dibujo";
                    groupBox2.Text = "ASCII a...";
                    asciitobinbox.Text = "ASCII a Binario";
                    asciitohexbox.Text = "ASCII a Hexadecimal";
                    aboutToolStripMenuItem.Text = "Acerca de...";
                    optionsToolStripMenuItem.Text = "Opciones";
                    button1.Text = "Limpiar";
                    label1.Text = "Escribe cualquier caracter para obtener el codigo Binario del caracter";
                    label6.Text = "Caracter";
                    label5.Text = "Binario";
                    binaryletterbutton.Text = "Resultado";
                    label7.Text = "Caracter";
                    hexletterbutton.Text = "Resultado";
                    label10.Text = "Escribe cualquier caracter para obtener el codigo HEX del caracter";

                }
                
            }



            #endregion
            #region expfunc

            if (File.ReadAllText(@"C:\byter\byterbetafunconfig.txt") == "experimental functions: true")
            {
              //  asciitohexbox.Visible = true;
               //s tabControl1.TabPages.Add("ASCII Table");
            }
            if (File.ReadAllText(@"C:\byter\byterbetafunconfig.txt") == "experimental functions: false")
            {
              //  asciitohexbox.Visible = false;
            //  tabControl1.TabPages.Remove(tabPage3);
            }
            #endregion



        }

        #region byte sandbox part
        private void button1y8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "1";
            if (textBox8.Text == "1")
            {
                text1y8.Text = "128";
                number8 = 128;
            }
            
        }

        private void button0y8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "0";
            if (textBox8.Text == "0")
            {
                text1y8.Text = "";
                number8 = 0;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1y8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0y7_Click(object sender, EventArgs e)
        {
           textBox7.Text = "0";
            if (textBox7.Text == "0")
            {
                text1y7.Text = "";
                number7 = 0;
            }
        }

        private void button1y7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "1";
            if (textBox7.Text == "1")
            {
                text1y7.Text = "64";
                number7 = 64;
            }
        }

        private void button0y6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "0";
            if (textBox6.Text == "0")
            {
                text1y6.Text = "";
                number6 = 0;
            }
        }

        private void button1y6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "1";
            if (textBox6.Text == "1")
            {
                text1y6.Text = "32";
                number6 = 32;
            }
        }

        private void button1y5_Click(object sender, EventArgs e)
        {

            textBox5.Text = "1";
            if (textBox5.Text == "1")
            {
                text1y5.Text = "16";
                number5 = 16;
            }
        }

        private void button0y5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
            if (textBox5.Text == "0")
            {
                text1y5.Text = "";
                number5 = 0;
            }
        }

        private void button0y4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "0";
            if (textBox4.Text == "0")
            {
                text1y4.Text = "";
                number4 = 0;
            }
        }

        private void button1y4_Click(object sender, EventArgs e)
        {

            textBox4.Text = "1";
            if (textBox4.Text == "1")
            {
                text1y4.Text = "8";
                number4 = 8;
            }
        }

        private void button0y3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            if (textBox3.Text == "0")
            {
                text1y3.Text = "";
                number3 = 0;
            }
        }

        private void button1y3_Click(object sender, EventArgs e)
        {

            textBox3.Text = "1";
            if (textBox3.Text == "1")
            {
                text1y3.Text = "4";
                number3 = 4;
            }
        }

        private void button1y2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
            if (textBox2.Text == "1")
            {
                text1y2.Text = "2";
                number2 = 2;
            }
        }

        private void button0y2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            if (textBox2.Text == "0")
            {
                text1y2.Text = "";
                number2 = 0;
            }
        }

        private void button1y1_Click(object sender, EventArgs e)
        {
            textBox11.Text = "1";
            if (textBox11.Text == "1")
            {
                text1y1.Text = "1";
                number1 = 1;
            }
        }

        private void button0y1_Click(object sender, EventArgs e)
        {
            textBox11.Text = "0";
            if (textBox11.Text == "0")
            {
                text1y1.Text = "";
                number1 = 0;
            }
        }

        
        private void resultbutton_Click(object sender, EventArgs e)
        {
            var resultint = number8 + number7 + number6 + number5 + number4 + number3 + number2 + number1;
            result.Text = resultint.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        #region misc
        public void reset()
        {
        number8 = 0;
        number7 = 0;
       number6 = 0;
       number5 = 0;
       number4 = 0;
     number3 = 0;
       number2 = 0;
        number1 = 0;
            textBox8.Text = "0";
            textBox7.Text = "0";
            textBox6.Text = "0";
            textBox5.Text = "0";
            textBox4.Text = "0";
            textBox3.Text = "0";
            textBox2.Text = "0";
            textBox11.Text = "0";

            text1y1.Text = "";
            text1y2.Text = "";
            text1y3.Text = "";
            text1y4.Text = "";
            text1y5.Text = "";
            text1y6.Text = "";
            text1y7.Text = "";
            text1y8.Text = "";

            result.Text = "";


        }

        public void tab1visible()
        {
            textBox8.Visible = true;
            textBox7.Visible = true;
            textBox6.Visible = true;
            textBox5.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox11.Visible = true;

            text1y1.Visible = true;
            text1y2.Visible = true;
            text1y3.Visible = true;
            text1y4.Visible = true;
            text1y5.Visible = true;
            text1y6.Visible = true;
            text1y7.Visible = true;
            text1y8.Visible = true;

            button0y1.Visible = true;
            button0y2.Visible = true;
            button0y3.Visible = true;
            button0y4.Visible = true;
            button0y5.Visible = true;
            button0y6.Visible = true;
            button0y7.Visible = true;
            button0y8.Visible = true;

            button1y1.Visible = true;
            button1y2.Visible = true;
            button1y3.Visible = true;
            button1y4.Visible = true;
            button1y5.Visible = true;
            button1y6.Visible = true;
            button1y7.Visible = true;
            button1y8.Visible = true;

            result.Visible = true;
        }
        public void tab2visible()
        {
        
        textBox8.Visible = false;
            textBox7.Visible = false;
            textBox6.Visible = false;
            textBox5.Visible = false;
            textBox4.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox11.Visible = false;

            text1y1.Visible = false;
            text1y2.Visible = false;
            text1y3.Visible = false;
            text1y4.Visible = false;
            text1y5.Visible = false;
            text1y6.Visible = false;
            text1y7.Visible = false;
            text1y8.Visible = false;

            button0y1.Visible = false;
            button0y2.Visible = false;
            button0y3.Visible = false;
            button0y4.Visible = false;
            button0y5.Visible = false;
            button0y6.Visible = false;
            button0y7.Visible = false;
            button0y8.Visible = false;

            button1y1.Visible = false;
            button1y2.Visible = false;
            button1y3.Visible = false;
            button1y4.Visible = false;
            button1y5.Visible = false;
            button1y6.Visible = false;
            button1y7.Visible = false;
            button1y8.Visible = false;

            result.Visible = false;

        }

        #endregion
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            reset();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           // tab1visible();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //tab2visible();
        }

        private void letterinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region letter2binaryshit
       
        //the letter to binary thing
        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            #region lowercase
            if (binaryletterinput.Text == "ñ")
            {
                binaryletterequal.Text = "11110001";
            }
            if (binaryletterinput.Text == "a")
            {
                binaryletterequal.Text = "01100001";
            }
            if (binaryletterinput.Text == "b")
            {
                binaryletterequal.Text = "01100010";
            }
            if (binaryletterinput.Text == "c")
            {
                binaryletterequal.Text = "01100011";
            }
            if (binaryletterinput.Text == "d")
            {
                binaryletterequal.Text = "01100100";
            }
            if (binaryletterinput.Text == "e")
            {
                binaryletterequal.Text = "01100101";
            }
            if (binaryletterinput.Text == "f")
            {
                binaryletterequal.Text = "01100110";
            }
            if (binaryletterinput.Text == "g")
            {
                binaryletterequal.Text = "01100111";
            }
            if (binaryletterinput.Text == "h")
            {
                binaryletterequal.Text = "01101000";
            }
            if (binaryletterinput.Text == "i")
            {
                binaryletterequal.Text = "01101001";
            }
            if (binaryletterinput.Text == "j")
            {
                binaryletterequal.Text = "01101010";
            }
            if (binaryletterinput.Text == "k")
            {
                binaryletterequal.Text = "01101011";
            }
            if (binaryletterinput.Text == "l")
            {
                binaryletterequal.Text = "01101100";
            }
            if (binaryletterinput.Text == "m")
            {
                binaryletterequal.Text = "01101101";
            }
            if (binaryletterinput.Text == "n")
            {
                binaryletterequal.Text = "01101110";
            }
            if (binaryletterinput.Text == "o")
            {
                binaryletterequal.Text = "01101111";
            }
            if (binaryletterinput.Text == "p")
            {
                binaryletterequal.Text = "01110000";
            }
            if (binaryletterinput.Text == "q")
            {
                binaryletterequal.Text = "01110001";
            }
            if (binaryletterinput.Text == "r")
            {
                binaryletterequal.Text = "01110010";
            }
            if (binaryletterinput.Text == "s")
            {
                binaryletterequal.Text = "01110011";
            }
            if (binaryletterinput.Text == "t")
            {
                binaryletterequal.Text = "01110100";
            }
            if (binaryletterinput.Text == "u")
            {
                binaryletterequal.Text = "01110101";
            }
            if (binaryletterinput.Text == "v")
            {
                binaryletterequal.Text = "01110110";
            }
            if (binaryletterinput.Text == "w")
            {
                binaryletterequal.Text = "01110111";
            }
            if (binaryletterinput.Text == "x")
            {
                binaryletterequal.Text = "01111000";
            }
            if (binaryletterinput.Text == "y")
            {
                binaryletterequal.Text = "01111001";
            }
            if (binaryletterinput.Text == "z")
            {
                binaryletterequal.Text = "01111010";
            }
            #endregion
            #region uppercase
            if (binaryletterinput.Text == "Ñ")
            {
                binaryletterequal.Text = "11010001";
            }
            if (binaryletterinput.Text == "A")
            {
                binaryletterequal.Text = "01000001";
            }
            if (binaryletterinput.Text == "B")
            {
                binaryletterequal.Text = "01000010";
            }
            if (binaryletterinput.Text == "C")
            {
                binaryletterequal.Text = "01000011";
            }
            if (binaryletterinput.Text == "D")
            {
                binaryletterequal.Text = "01000100";
            }
            if (binaryletterinput.Text == "E")
            {
                binaryletterequal.Text = "01000101";
            }
            if (binaryletterinput.Text == "F")
            {
                binaryletterequal.Text = "01000110";
            }
            if (binaryletterinput.Text == "G")
            {
                binaryletterequal.Text = "01000111";
            }
            if (binaryletterinput.Text == "H")
            {
                binaryletterequal.Text = "01001000";
            }
            if (binaryletterinput.Text == "I")
            {
                binaryletterequal.Text = "01001001";
            }
            if (binaryletterinput.Text == "J")
            {
                binaryletterequal.Text = "01001010";
            }
            if (binaryletterinput.Text == "K")
            {
                binaryletterequal.Text = "01001011";
            }
            if (binaryletterinput.Text == "L")
            {
                binaryletterequal.Text = "01001100";
            }
            if (binaryletterinput.Text == "M")
            {
                binaryletterequal.Text = "01001101";
            }
            if (binaryletterinput.Text == "N")
            {
                binaryletterequal.Text = "01001110";
            }
            if (binaryletterinput.Text == "O")
            {
                binaryletterequal.Text = "01001111";
            }
            if (binaryletterinput.Text == "P")
            {
                binaryletterequal.Text = "01010000";
            }
            if (binaryletterinput.Text == "Q")
            {
                binaryletterequal.Text = "01010001";
            }
            if (binaryletterinput.Text == "R")
            {
                binaryletterequal.Text = "01010010";
            }
            if (binaryletterinput.Text == "S")
            {
                binaryletterequal.Text = "01010011";
            }
            if (binaryletterinput.Text == "T")
            {
                binaryletterequal.Text = "01010100";
            }
            if (binaryletterinput.Text == "U")
            {
                binaryletterequal.Text = "01010101";
            }
            if (binaryletterinput.Text == "V")
            {
                binaryletterequal.Text = "01010110";
            }
            if (binaryletterinput.Text == "W")
            {
                binaryletterequal.Text = "01010111";
            }
            if (binaryletterinput.Text == "X")
            {
                binaryletterequal.Text = "01011000";
            }
            if (binaryletterinput.Text == "Y")
            {
                binaryletterequal.Text = "01011001";
            }
            if (binaryletterinput.Text == "Z")
            {
                binaryletterequal.Text = "01011010";
            }
            #endregion
            #region misc
            if (binaryletterinput.Text == "!")
            {
                binaryletterequal.Text = "00100001";
            }
            if (binaryletterinput.Text == "#")
            {
                binaryletterequal.Text = "00100011";
            }
            if (binaryletterinput.Text == "$")
            {
                binaryletterequal.Text = "00100100";
            }
            if (binaryletterinput.Text == "%")
            {
                binaryletterequal.Text = "00100101";
            }
            if (binaryletterinput.Text == "&")
            {
                binaryletterequal.Text = "00100110";
            }
            if (binaryletterinput.Text == "'")
            {
                binaryletterequal.Text = "00100111";
            }
            if (binaryletterinput.Text == "(")
            {
                binaryletterequal.Text = "00101000";
            }
            if (binaryletterinput.Text == ")")
            {
                binaryletterequal.Text = "00101001";
            }
            if (binaryletterinput.Text == "*")
            {
                binaryletterequal.Text = "00101010";
            }
            if (binaryletterinput.Text == "+")
            {
                binaryletterequal.Text = "00101011";
            }
            if (binaryletterinput.Text == ",")
            {
                binaryletterequal.Text = "00101100";
            }
            if (binaryletterinput.Text == "-")
            {
                binaryletterequal.Text = "00101101";
            }
            if (binaryletterinput.Text == ".")
            {
                binaryletterequal.Text = "00101110";
            }
            if (binaryletterinput.Text == "/")
            {
                binaryletterequal.Text = "00101111";
            }
            if (binaryletterinput.Text == ":")
            {
                binaryletterequal.Text = "00111010";
            }
            if (binaryletterinput.Text == ";")
            {
                binaryletterequal.Text = "00111011";
            }
            if (binaryletterinput.Text == "<")
            {
                binaryletterequal.Text = "00111100";
            }
            if (binaryletterinput.Text == "=")
            {
                binaryletterequal.Text = "00111101";
            }
            if (binaryletterinput.Text == ">")
            {
                binaryletterequal.Text = "00111110";
            }
            if (binaryletterinput.Text == "?")
            {
                binaryletterequal.Text = "00111111";
            }
            if (binaryletterinput.Text == "@")
            {
                binaryletterequal.Text = "01000000";
            }
            if (binaryletterinput.Text == "[")
            {
                binaryletterequal.Text = "01011011";
            }
            if (binaryletterinput.Text == "]")
            {
                binaryletterequal.Text = "01011101";
            }
            if (binaryletterinput.Text == @"\")
            {
                binaryletterequal.Text = "01011100";
            }
            if (binaryletterinput.Text == "^")
            {
                binaryletterequal.Text = "01011110";
            }
            if (binaryletterinput.Text == "_")
            {
                binaryletterequal.Text = "01011111";
            }
            if (binaryletterinput.Text == "`")
            {
                binaryletterequal.Text = "01100000";
            }
            if (binaryletterinput.Text == "{")
            {
                binaryletterequal.Text = "01111011";
            }
            if (binaryletterinput.Text == "}")
            {
                binaryletterequal.Text = "01111101";
            }
            if (binaryletterinput.Text == "|")
            {
                binaryletterequal.Text = "01111100";
            }
            if (binaryletterinput.Text == "~")
            {
                binaryletterequal.Text = "01111110";
            }





            if (binaryletterinput.Text == "")
            {
                MessageBox.Show("Please, type something", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            #region random
            if (binaryletterinput.Text == "DEL")
            {
                binaryletterequal.Text = "01111111";
            }
            if (binaryletterinput.Text == " ")
            {
                binaryletterequal.Text = "00100000";
            }
            if (binaryletterinput.Text == "NUL")
            {
                binaryletterequal.Text = "00000000";
            }
            if (binaryletterinput.Text == "SOH")
            {
                binaryletterequal.Text = "00000001";
            }
            if (binaryletterinput.Text == "STX")
            {
                binaryletterequal.Text = "00000010";
            }
            if (binaryletterinput.Text == "ETX")
            {
                binaryletterequal.Text = "00000011";
            }
            if (binaryletterinput.Text == "EOT")
            {
                binaryletterequal.Text = "00000100";
            }
            if (binaryletterinput.Text == "ENQ")
            {
                binaryletterequal.Text = "00000101";
            }
            if (binaryletterinput.Text == "ACK")
            {
                binaryletterequal.Text = "00000110";
            }
            if (binaryletterinput.Text == "BEL")
            {
                binaryletterequal.Text = "00000111";
            }
            if (binaryletterinput.Text == "BS")
            {
                binaryletterequal.Text = "00001000";
            }
            if (binaryletterinput.Text == "HT")
            {
                binaryletterequal.Text = "00001001";
            }
            if (binaryletterinput.Text == "LF")
            {
                binaryletterequal.Text = "00001010";
            }
            if (binaryletterinput.Text == "VT")
            {
                binaryletterequal.Text = "00001011";
            }
            if (binaryletterinput.Text == "FF")
            {
                binaryletterequal.Text = "00001100";
            }
            if (binaryletterinput.Text == "CR")
            {
                binaryletterequal.Text = "00001101";
            }
            if (binaryletterinput.Text == "SO")
            {
                binaryletterequal.Text = "00001110";
            }
            if (binaryletterinput.Text == "SI")
            {
                binaryletterequal.Text = "00001111";
            }
            if (binaryletterinput.Text == "DLE")
            {
                binaryletterequal.Text = "00010000";
            }
            if (binaryletterinput.Text == "DC1")
            {
                binaryletterequal.Text = "00010001";
            }
            if (binaryletterinput.Text == "DC2")
            {
                binaryletterequal.Text = "00010010";
            }
            if (binaryletterinput.Text == "DC3")
            {
                binaryletterequal.Text = "00010011";
            }
            if (binaryletterinput.Text == "DC4")
            {
                binaryletterequal.Text = "00010100";
            }
            if (binaryletterinput.Text == "NAK")
            {
                binaryletterequal.Text = "00010101";
            }
            if (binaryletterinput.Text == "SYN")
            {
                binaryletterequal.Text = "00010110";
            }
            if (binaryletterinput.Text == "ETB")
            {
                binaryletterequal.Text = "00010111";
            }
            if (binaryletterinput.Text == "CAN")
            {
                binaryletterequal.Text = "00011000";
            }
            if (binaryletterinput.Text == "EM")
            {
                binaryletterequal.Text = "00011001";
            }
            if (binaryletterinput.Text == "SUB")
            {
                binaryletterequal.Text = "00011010";
            }
            if (binaryletterinput.Text == "ESC")
            {
                binaryletterequal.Text = "00011011";
            }
            if (binaryletterinput.Text == "FS")
            {
                binaryletterequal.Text = "00011100";
            }
            if (binaryletterinput.Text == "GS")
            {
                binaryletterequal.Text = "00011101";
            }
            if (binaryletterinput.Text == "RS")
            {
                binaryletterequal.Text = "00011110";
            }
            if (binaryletterinput.Text == "US")
            {
                binaryletterequal.Text = "00011111";
            }

            #endregion
            #region numbers
            if (binaryletterinput.Text == "0")
            {
                binaryletterequal.Text = "00110000";
            }
            if (binaryletterinput.Text == "1")
            {
                binaryletterequal.Text = "00110001";
            }
            if (binaryletterinput.Text == "2")
            {
                binaryletterequal.Text = "00110010";
            }
            if (binaryletterinput.Text == "3")
            {
                binaryletterequal.Text = "00110011";
            }
            if (binaryletterinput.Text == "4")
            {
                binaryletterequal.Text = "00110100";
            }
            if (binaryletterinput.Text == "5")
            {
                binaryletterequal.Text = "00110101";
            }
            if (binaryletterinput.Text == "6")
            {
                binaryletterequal.Text = "00110110";
            }
            if (binaryletterinput.Text == "7")
            {
                binaryletterequal.Text = "00110111";
            }
            if (binaryletterinput.Text == "8")
            {
                binaryletterequal.Text = "00111000";
            }
            if (binaryletterinput.Text == "9")
            {
                binaryletterequal.Text = "00111001";
            }
            #endregion
        }

        #endregion
        #region letter2hexshit
        private void hexletterbutton_Click(object sender, EventArgs e)
        {//the letter to hex thing
            reset();
            #region lowercase
            if (hexletterinput.Text == "ñ")
            {
                hexletterequal.Text = "F1";
            }

            if (hexletterinput.Text == "a")
            {
                hexletterequal.Text = "61";
            }
            if (hexletterinput.Text == "b")
            {
                hexletterequal.Text = "62";
            }
            if (hexletterinput.Text == "c")
            {
                hexletterequal.Text = "63";
            }
            if (hexletterinput.Text == "d")
            {
                hexletterequal.Text = "64";
            }
            if (hexletterinput.Text == "e")
            {
                hexletterequal.Text = "65";
            }
            if (hexletterinput.Text == "f")
            {
                hexletterequal.Text = "66";
            }
            if (hexletterinput.Text == "g")
            {
                hexletterequal.Text = "67";
            }
            if (hexletterinput.Text == "h")
            {
                hexletterequal.Text = "68";
            }
            if (hexletterinput.Text == "i")
            {
                hexletterequal.Text = "69";
            }
            if (hexletterinput.Text == "j")
            {
                hexletterequal.Text = "6A";
            }
            if (hexletterinput.Text == "k")
            {
                hexletterequal.Text = "6B";
            }
            if (hexletterinput.Text == "l")
            {
                hexletterequal.Text = "6C";
            }
            if (hexletterinput.Text == "m")
            {
                hexletterequal.Text = "6D";
            }
            if (hexletterinput.Text == "n")
            {
                hexletterequal.Text = "6E";
            }
            if (hexletterinput.Text == "o")
            {
                hexletterequal.Text = "6F";
            }
            if (hexletterinput.Text == "p")
            {
                hexletterequal.Text = "70";
            }
            if (hexletterinput.Text == "q")
            {
                hexletterequal.Text = "71";
            }
            if (hexletterinput.Text == "r")
            {
                hexletterequal.Text = "72";
            }
            if (hexletterinput.Text == "s")
            {
                hexletterequal.Text = "73";
            }
            if (hexletterinput.Text == "t")
            {
                hexletterequal.Text = "74";
            }
            if (hexletterinput.Text == "u")
            {
                hexletterequal.Text = "75";
            }
            if (hexletterinput.Text == "v")
            {
                hexletterequal.Text = "76";
            }
            if (hexletterinput.Text == "w")
            {
                hexletterequal.Text = "77";
            }
            if (hexletterinput.Text == "x")
            {
                hexletterequal.Text = "78";
            }
            if (hexletterinput.Text == "y")
            {
                hexletterequal.Text = "79";
            }
            if (hexletterinput.Text == "z")
            {
                hexletterequal.Text = "7A";
            }
            #endregion
            #region uppercase
            if (hexletterinput.Text == "Ñ")
            {
                hexletterequal.Text = "D1";
            }

            if (hexletterinput.Text == "A")
            {
                hexletterequal.Text = "41";
            }
            if (hexletterinput.Text == "B")
            {
                hexletterequal.Text = "42";
            }
            if (hexletterinput.Text == "C")
            {
                hexletterequal.Text = "43";
            }
            if (hexletterinput.Text == "D")
            {
                hexletterequal.Text = "44";
            }
            if (hexletterinput.Text == "E")
            {
                hexletterequal.Text = "45";
            }
            if (hexletterinput.Text == "F")
            {
                hexletterequal.Text = "46";
            }
            if (hexletterinput.Text == "G")
            {
                hexletterequal.Text = "47";
            }
            if (hexletterinput.Text == "H")
            {
                hexletterequal.Text = "48";
            }
            if (hexletterinput.Text == "I")
            {
                hexletterequal.Text = "49";
            }
            if (hexletterinput.Text == "J")
            {
                hexletterequal.Text = "4A";
            }
            if (hexletterinput.Text == "K")
            {
                hexletterequal.Text = "4B";
            }
            if (hexletterinput.Text == "L")
            {
                hexletterequal.Text = "4C";
            }
            if (hexletterinput.Text == "M")
            {
                hexletterequal.Text = "4D";
            }
            if (hexletterinput.Text == "N")
            {
                hexletterequal.Text = "4E";
            }
            if (hexletterinput.Text == "O")
            {
                hexletterequal.Text = "4F";
            }
            if (hexletterinput.Text == "P")
            {
                hexletterequal.Text = "50";
            }
            if (hexletterinput.Text == "Q")
            {
                hexletterequal.Text = "51";
            }
            if (hexletterinput.Text == "R")
            {
                hexletterequal.Text = "52";
            }
            if (hexletterinput.Text == "S")
            {
                hexletterequal.Text = "53";
            }
            if (hexletterinput.Text == "T")
            {
                hexletterequal.Text = "54";
            }
            if (hexletterinput.Text == "U")
            {
                hexletterequal.Text = "55";
            }
            if (hexletterinput.Text == "V")
            {
                hexletterequal.Text = "56";
            }
            if (hexletterinput.Text == "W")
            {
                hexletterequal.Text = "57";
            }
            if (hexletterinput.Text == "X")
            {
                hexletterequal.Text = "58";
            }
            if (hexletterinput.Text == "Y")
            {
                hexletterequal.Text = "59";
            }
            if (hexletterinput.Text == "Z")
            {
                hexletterequal.Text = "5A";
            }

            #endregion
            #region misc
            if (hexletterinput.Text == "!")
            {
                hexletterequal.Text = "21";
            }
            if (hexletterinput.Text == "#")
            {
                hexletterequal.Text = "23";
            }
            if (hexletterinput.Text == "$")
            {
                hexletterequal.Text = "24";
            }
            if (hexletterinput.Text == "%")
            {
                hexletterequal.Text = "25";
            }
            if (hexletterinput.Text == "&")
            {
                hexletterequal.Text = "26";
            }
            if (hexletterinput.Text == "'")
            {
                hexletterequal.Text = "27";
            }
            if (hexletterinput.Text == "(")
            {
                hexletterequal.Text = "28";
            }
            if (hexletterinput.Text == ")")
            {
                hexletterequal.Text = "29";
            }
            if (hexletterinput.Text == "*")
            {
                hexletterequal.Text = "2A";
            }
            if (hexletterinput.Text == "+")
            {
                hexletterequal.Text = "2B";
            }
            if (hexletterinput.Text == ",")
            {
                hexletterequal.Text = "2C";
            }
            if (hexletterinput.Text == "-")
            {
                hexletterequal.Text = "2D";
            }
            if (hexletterinput.Text == ".")
            {
                hexletterequal.Text = "2E";
            }
            if (hexletterinput.Text == "/")
            {
                hexletterequal.Text = "2F";
            }
            if (hexletterinput.Text == ":")
            {
                hexletterequal.Text = "3A";
            }
            if (hexletterinput.Text == ";")
            {
                hexletterequal.Text = "3B";
            }
            if (hexletterinput.Text == "<")
            {
                hexletterequal.Text = "3C";
            }
            if (hexletterinput.Text == "=")
            {
                hexletterequal.Text = "3D";
            }
            if (hexletterinput.Text == ">")
            {
                hexletterequal.Text = "3E";
            }
            if (hexletterinput.Text == "?")
            {
                hexletterequal.Text = "3F";
            }
            if (hexletterinput.Text == "@")
            {
                hexletterequal.Text = "40";
            }
            if (hexletterinput.Text == "[")
            {
                hexletterequal.Text = "5B";
            }
            if (hexletterinput.Text == "]")
            {
                hexletterequal.Text = "5D";
            }
            if (hexletterinput.Text == @"\")
            {
                hexletterequal.Text = "5C";
            }
            if (hexletterinput.Text == "^")
            {
                hexletterequal.Text = "5E";
            }
            if (hexletterinput.Text == "_")
            {
                hexletterequal.Text = "5F";
            }
            if (hexletterinput.Text == "`")
            {
                hexletterequal.Text = "60";
            }
            if (hexletterinput.Text == "{")
            {
                hexletterequal.Text = "7B";
            }
            if (hexletterinput.Text == "}")
            {
                hexletterequal.Text = "7C";
            }
            if (hexletterinput.Text == "|")
            {
                hexletterequal.Text = "7C";
            }
            if (hexletterinput.Text == "~")
            {
                hexletterequal.Text = "7E";
            }
            #endregion
            #region random
            if (hexletterinput.Text == "DEL")
            {
                hexletterequal.Text = "7F";
            }
            if (hexletterinput.Text == " ")
            {
                hexletterequal.Text = "20";
            }
            if (hexletterinput.Text == "NUL")
            {
                hexletterequal.Text = "00";
            }
            if (hexletterinput.Text == "SOH")
            {
                hexletterequal.Text = "01";
            }
            if (hexletterinput.Text == "STX")
            {
                hexletterequal.Text = "02";
            }
            if (hexletterinput.Text == "ETX")
            {
                hexletterequal.Text = "03";
            }
            if (hexletterinput.Text == "EOT")
            {
                hexletterequal.Text = "04";
            }
            if (hexletterinput.Text == "ENQ")
            {
                hexletterequal.Text = "05";
            }
            if (hexletterinput.Text == "ACK")
            {
                hexletterequal.Text = "06";
            }
            if (hexletterinput.Text == "BEL")
            {
                hexletterequal.Text = "07";
            }
            if (hexletterinput.Text == "BS")
            {
                hexletterequal.Text = "08";
            }
            if (hexletterinput.Text == "HT")
            {
                hexletterequal.Text = "09";
            }
            if (hexletterinput.Text == "LF")
            {
                hexletterequal.Text = "0A";
            }
            if (hexletterinput.Text == "VT")
            {
                hexletterequal.Text = "0B";
            }
            if (hexletterinput.Text == "FF")
            {
                hexletterequal.Text = "0C";
            }
            if (hexletterinput.Text == "CR")
            {
                hexletterequal.Text = "0D";
            }
            if (hexletterinput.Text == "SO")
            {
                hexletterequal.Text = "0E";
            }
            if (hexletterinput.Text == "SI")
            {
                hexletterequal.Text = "0F";
            }
            if (hexletterinput.Text == "DLE")
            {
                hexletterequal.Text = "10";
            }
            if (hexletterinput.Text == "DC1")
            {
                hexletterequal.Text = "11";
            }
            if (hexletterinput.Text == "DC2")
            {
                hexletterequal.Text = "12";
            }
            if (hexletterinput.Text == "DC3")
            {
                hexletterequal.Text = "13";
            }
            if (hexletterinput.Text == "DC4")
            {
                hexletterequal.Text = "14";
            }
            if (hexletterinput.Text == "NAK")
            {
                hexletterequal.Text = "15";
            }
            if (hexletterinput.Text == "SYN")
            {
                hexletterequal.Text = "16";
            }
            if (hexletterinput.Text == "ETB")
            {
                hexletterequal.Text = "17";
            }
            if (hexletterinput.Text == "CAN")
            {
                hexletterequal.Text = "18";
            }
            if (hexletterinput.Text == "EM")
            {
                hexletterequal.Text = "19";
            }
            if (hexletterinput.Text == "SUB")
            {
                hexletterequal.Text = "1A";
            }
            if (hexletterinput.Text == "ESC")
            {
                hexletterequal.Text = "1B";
            }
            if (hexletterinput.Text == "FS")
            {
                hexletterequal.Text = "1C";
            }
            if (hexletterinput.Text == "GS")
            {
                hexletterequal.Text = "1D";
            }
            if (hexletterinput.Text == "RS")
            {
                hexletterequal.Text = "1E";
            }
            if (hexletterinput.Text == "US")
            {
                hexletterequal.Text = "1F";
            }
            #endregion
            #region numbers
            if (hexletterinput.Text == "0")
            {
                hexletterequal.Text = "30";
            }
            if (hexletterinput.Text == "1")
            {
                hexletterequal.Text = "31";
            }
            if (hexletterinput.Text == "2")
            {
                hexletterequal.Text = "32";
            }
            if (hexletterinput.Text == "3")
            {
                hexletterequal.Text = "33";
            }
            if (hexletterinput.Text == "4")
            {
                hexletterequal.Text = "34";
            }
            if (hexletterinput.Text == "5")
            {
                hexletterequal.Text = "35";
            }
            if (hexletterinput.Text == "6")
            {
                hexletterequal.Text = "36";
            }
            if (hexletterinput.Text == "7")
            {
                hexletterequal.Text = "37";
            }
            if (hexletterinput.Text == "8")
            {
                hexletterequal.Text = "38";
            }
            if (hexletterinput.Text == "9")
            {
                hexletterequal.Text = "39";
            }
            #endregion
        }
        #endregion

      

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new options().Show();
        }

    

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }







       

        #region equalbyte8
        private void byte8equal_Click(object sender, EventArgs e)
        {
            var result8 = number8y8 + number8y7 + number8y6 + number8y5 + number8y4 + number8y3 + number8y2 + number8y1;
            byteresult8.Text = result8.ToString();

        }

        private void byte7equal_Click(object sender, EventArgs e)
        {
            var result7 = number7y8 + number7y7 + number7y6 + number7y5 + number7y4 + number7y3 + number7y2 + number7y1;
            byteresult7.Text = result7.ToString();
        }

        private void byte6equal_Click(object sender, EventArgs e)
        {
            var result6 = number6y8 + number6y7 + number6y6 + number6y5 + number6y4 + number6y3 + number6y2 + number6y1;
            byteresult6.Text = result6.ToString();
        }

        private void byte5equal_Click(object sender, EventArgs e)
        {
            var result5 = number5y8 + number5y7 + number5y6 + number5y5 + number5y4 + number5y3 + number5y2 + number5y1;
            byteresult5.Text = result5.ToString();
        }

        private void byte4equal_Click(object sender, EventArgs e)
        {
            var result4 = number4y8 + number4y7 + number4y6 + number4y5 + number4y4 + number4y3 + number4y2 + number4y1;
            byteresult4.Text = result4.ToString();
        }

        private void byte3equal_Click(object sender, EventArgs e)
        {
            var result3 = number3y8 + number3y7 + number3y6 + number3y5 + number3y4 + number3y3 + number3y2 + number3y1;
            byteresult3.Text = result3.ToString();
        }

        private void byte2equal_Click(object sender, EventArgs e)
        {
            var result2 = number2y8 + number2y7 + number2y6 + number2y5 + number2y4 + number2y3 + number2y2 + number2y1;
            byteresult2.Text = result2.ToString();
        }

        private void byte1equal_Click(object sender, EventArgs e)
        {
            var result1 = number1y8 + number1y7 + number1y6 + number1y5 + number1y4 + number1y3 + number1y2 + number1y1;
            byteresult1.Text = result1.ToString();
        }
        #endregion

        #region clear8bytes
        private void clear8bytesburron_Click(object sender, EventArgs e)
        {
            byte8y8button.Text = "0";
            byte8y7button.Text = "0";
            byte8y6button.Text = "0";
            byte8y5button.Text = "0";
            byte8y4button.Text = "0";
            byte8y3button.Text = "0";
            byte8y2button.Text = "0";
            byte8y1button.Text = "0";

            byte7y8button.Text = "0";
            byte7y7button.Text = "0";
            byte7y6button.Text = "0";
            byte7y5button.Text = "0";
            byte7y4button.Text = "0";
            byte7y3button.Text = "0";
            byte7y2button.Text = "0";
            byte7y1button.Text = "0";

            byte6y8button.Text = "0";
            byte6y7button.Text = "0";
            byte6y6button.Text = "0";
            byte6y5button.Text = "0";
            byte6y4button.Text = "0";
            byte6y3button.Text = "0";
            byte6y2button.Text = "0";
            byte6y1button.Text = "0";

            byte5y8button.Text = "0";
            byte5y7button.Text = "0";
            byte5y6button.Text = "0";
            byte5y5button.Text = "0";
            byte5y4button.Text = "0";
            byte5y3button.Text = "0";
            byte5y2button.Text = "0";
            byte5y1button.Text = "0";

            byte4y8button.Text = "0";
            byte4y7button.Text = "0";
            byte4y6button.Text = "0";
            byte4y5button.Text = "0";
            byte4y4button.Text = "0";
            byte4y3button.Text = "0";
            byte4y2button.Text = "0";
            byte4y1button.Text = "0";

            byte3y8button.Text = "0";
            byte3y7button.Text = "0";
            byte3y6button.Text = "0";
            byte3y5button.Text = "0";
            byte3y4button.Text = "0";
            byte3y3button.Text = "0";
            byte3y2button.Text = "0";
            byte3y1button.Text = "0";

            byte2y8button.Text = "0";
            byte2y7button.Text = "0";
            byte2y6button.Text = "0";
            byte2y5button.Text = "0";
            byte2y4button.Text = "0";
            byte2y3button.Text = "0";
            byte2y2button.Text = "0";
            byte2y1button.Text = "0";

            byte1y8button.Text = "0";
            byte1y7button.Text = "0";
            byte1y6button.Text = "0";
            byte1y5button.Text = "0";
            byte1y4button.Text = "0";
            byte1y3button.Text = "0";
            byte1y2button.Text = "0";
            byte1y1button.Text = "0";

            number8y8 = 0;
            number8y7 = 0;
            number8y6 = 0;
            number8y5 = 0;
            number8y4 = 0;
            number8y3 = 0;
            number8y2 = 0;
            number8y1 = 0;

            number7y8 = 0;
            number7y7 = 0;
            number7y6 = 0;
            number7y5 = 0;
            number7y4 = 0;
            number7y3 = 0;
            number7y2 = 0;
            number7y1 = 0;

            number6y8 = 0;
            number6y7 = 0;
            number6y6 = 0;
            number6y5 = 0;
            number6y4 = 0;
            number6y3 = 0;
            number6y2 = 0;
            number6y1 = 0;

            number5y8 = 0;
            number5y7 = 0;
            number5y6 = 0;
            number5y5 = 0;
            number5y4 = 0;
            number5y3 = 0;
            number5y2 = 0;
            number5y1 = 0;

            number4y8 = 0;
            number4y7 = 0;
            number4y6 = 0;
            number4y5 = 0;
            number4y4 = 0;
            number4y3 = 0;
            number4y2 = 0;
            number4y1 = 0;

            number3y8 = 0;
            number3y7 = 0;
            number3y6 = 0;
            number3y5 = 0;
            number3y4 = 0;
            number3y3 = 0;
            number3y2 = 0;
            number3y1 = 0;

            number2y8 = 0;
            number2y7 = 0;
            number2y6 = 0;
            number2y5 = 0;
            number2y4 = 0;
            number2y3 = 0;
            number2y2 = 0;
            number2y1 = 0;

            number1y8 = 0;
            number1y7 = 0;
            number1y6 = 0;
            number1y5 = 0;
            number1y4 = 0;
            number1y3 = 0;
            number1y2 = 0;
            number1y1 = 0;

            byteresult1.Text = "";
            byteresult2.Text = "";
            byteresult3.Text = "";
            byteresult4.Text = "";
            byteresult5.Text = "";
            byteresult6.Text = "";
            byteresult7.Text = "";
            byteresult8.Text = "";

            panel8y8.BackColor = Color.White;
            panel8y7.BackColor = Color.White;
            panel8y6.BackColor = Color.White;
            panel8y5.BackColor = Color.White;
            panel8y4.BackColor = Color.White;
            panel8y3.BackColor = Color.White;
            panel8y2.BackColor = Color.White;
            panel8y1.BackColor = Color.White;

            panel7y8.BackColor = Color.White;
            panel7y7.BackColor = Color.White;
            panel7y6.BackColor = Color.White;
            panel7y5.BackColor = Color.White;
            panel7y4.BackColor = Color.White;
            panel7y3.BackColor = Color.White;
            panel7y2.BackColor = Color.White;
            panel7y1.BackColor = Color.White;

            panel6y8.BackColor = Color.White;
            panel6y7.BackColor = Color.White;
            panel6y6.BackColor = Color.White;
            panel6y4.BackColor = Color.White;
            panel6y3.BackColor = Color.White;
            panel6y2.BackColor = Color.White;
            panel6y1.BackColor = Color.White;

            panel5y8.BackColor = Color.White;
            panel5y7.BackColor = Color.White;
            panel5y6.BackColor = Color.White;
            panel5y5.BackColor = Color.White;
            panel5y4.BackColor = Color.White;
            panel5y3.BackColor = Color.White;
            panel5y2.BackColor = Color.White;
            panel5y1.BackColor = Color.White;

            panel4y8.BackColor = Color.White;
            panel4y7.BackColor = Color.White;
            panel4y6.BackColor = Color.White;
            panel4y5.BackColor = Color.White;
            panel4y4.BackColor = Color.White;
            panel4y3.BackColor = Color.White;
            panel4y2.BackColor = Color.White;
            panel4y1.BackColor = Color.White;

            panel3y8.BackColor = Color.White;
            panel3y7.BackColor = Color.White;
            panel3y6.BackColor = Color.White;
            panel3y5.BackColor = Color.White;
            panel3y4.BackColor = Color.White;
            panel3y3.BackColor = Color.White;
            panel3y2.BackColor = Color.White;
            panel3y1.BackColor = Color.White;

            panel2y8.BackColor = Color.White;
            panel2y7.BackColor = Color.White;
            panel2y6.BackColor = Color.White;
            panel2y5.BackColor = Color.White;
            panel2y4.BackColor = Color.White;
            panel2y3.BackColor = Color.White;
            panel2y2.BackColor = Color.White;
            panel2y1.BackColor = Color.White;

            panel1y8.BackColor = Color.White;
            panel1y7.BackColor = Color.White;
            panel1y6.BackColor = Color.White;
            panel1y5.BackColor = Color.White;
            panel1y4.BackColor = Color.White;
            panel1y3.BackColor = Color.White;
            panel1y2.BackColor = Color.White;
            panel1y1.BackColor = Color.White;
        }
        #endregion
        #region 8bytesthing

        
        private void byte8y7button_Click(object sender, EventArgs e)
        {
            number8y7 = 64;
            byte8y7button.Text = "1";
            panel8y7.BackColor = Color.Black;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            number5y2 = 2;
            byte5y2button.Text = "1";
            panel5y2.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number1y3 = 4;
            byte1y3button.Text = "1";
            panel1y3.BackColor = Color.Black;
        }

        private void byte8y8button_Click(object sender, EventArgs e)
        {
            number8y8 = 128;
            byte8y8button.Text = "1";
            panel8y8.BackColor = Color.Black;
        }

        private void byte8y6button_Click(object sender, EventArgs e)
        {
            number8y6 = 32;
            byte8y6button.Text = "1";
            panel8y6.BackColor = Color.Black;
        }

        private void byte8y5button_Click(object sender, EventArgs e)
        {
            number8y5 = 16;
            byte8y5button.Text = "1";
            panel8y5.BackColor = Color.Black;
        }

        private void byte8y4button_Click(object sender, EventArgs e)
        {
            number8y4 = 8;
            byte8y4button.Text = "1";
            panel8y4.BackColor = Color.Black;
        }

        private void byte8y3button_Click(object sender, EventArgs e)
        {
            number8y3 = 4;
            byte8y3button.Text = "1";
            panel8y3.BackColor = Color.Black;
        }

        private void byte8y2button_Click(object sender, EventArgs e)
        {
            number8y2 = 2;
            byte8y2button.Text = "1";
            panel8y2.BackColor = Color.Black;
        }

        private void byte8y1button_Click(object sender, EventArgs e)
        {
            number8y1 = 1;
            byte8y1button.Text = "1";
            panel8y1.BackColor = Color.Black;
        }



     

        private void byte7y8button_Click(object sender, EventArgs e)
        {
            number7y8 = 128;
            byte7y8button.Text = "1";
            panel7y8.BackColor = Color.Black;
        }

        private void byte7y7button_Click(object sender, EventArgs e)
        {
            number7y7 = 64;
            byte7y7button.Text = "1";
            panel7y7.BackColor = Color.Black;
        }

        private void byte7y6button_Click(object sender, EventArgs e)
        {
            number7y6 = 32;
            byte7y6button.Text = "1";
            panel7y6.BackColor = Color.Black;
        }

        private void byte7y5button_Click(object sender, EventArgs e)
        {
            number7y5 = 16;
            byte7y5button.Text = "1";
            panel7y5.BackColor = Color.Black;
        }

        private void byte7y4button_Click(object sender, EventArgs e)
        {
            number7y4 = 8;
            byte7y4button.Text = "1";
            panel7y4.BackColor = Color.Black;
        }

        private void byte7y3button_Click(object sender, EventArgs e)
        {
            number7y3 = 4;
            byte7y3button.Text = "1";
            panel7y3.BackColor = Color.Black;
        }

        private void byte7y2button_Click(object sender, EventArgs e)
        {
            number7y2 = 2;
            byte7y2button.Text = "1";
            panel7y2.BackColor = Color.Black;
        }

        private void byte7y1button_Click(object sender, EventArgs e)
        {
            number7y1 = 1;
            byte7y1button.Text = "1";
            panel7y1.BackColor = Color.Black;
        }

        private void byte6y8button_Click(object sender, EventArgs e)
        {
            number6y8 = 128;
            byte6y8button.Text = "1";
            panel6y8.BackColor = Color.Black;
        }

        private void byte6y7button_Click(object sender, EventArgs e)
        {
            number6y7 = 64;
            byte6y7button.Text = "1";
            panel6y7.BackColor = Color.Black;
        }

        private void byte6y6button_Click(object sender, EventArgs e)
        {
            number6y6 = 32;
            byte6y6button.Text = "1";
            panel6y6.BackColor = Color.Black;
        }

        private void byte6y5button_Click(object sender, EventArgs e)
        {
            number6y5 = 16;
            byte6y5button.Text = "1";
            panel6y5.BackColor = Color.Black;
        }

        private void byte6y4button_Click(object sender, EventArgs e)
        {
            number6y4 = 8;
            byte6y4button.Text = "1";
            panel6y4.BackColor = Color.Black;
        }

        private void byte6y3button_Click(object sender, EventArgs e)
        {
            number6y3 = 4;
            byte6y3button.Text = "1";
            panel6y3.BackColor = Color.Black;
        }

        private void byte6y2button_Click(object sender, EventArgs e)
        {
            number6y2 = 2;
            byte6y2button.Text = "1";
            panel6y2.BackColor = Color.Black;
        }

        private void byte6y1button_Click(object sender, EventArgs e)
        {
            number6y1 = 1;
            byte6y1button.Text = "1";
            panel6y1.BackColor = Color.Black;
        }

     

        private void byte5y8button_Click(object sender, EventArgs e)
        {
            number5y8 = 128;
            byte5y8button.Text = "1";
            panel5y8.BackColor = Color.Black;
        }

        private void byte5y7button_Click(object sender, EventArgs e)
        {
            number5y7 = 64;
            byte5y7button.Text = "1";
            panel5y7.BackColor = Color.Black;
        }

        private void byte5y6button_Click(object sender, EventArgs e)
        {
            number5y6 = 32;
            byte5y6button.Text = "1";
            panel5y6.BackColor = Color.Black;
        }

        private void byte5y5button_Click(object sender, EventArgs e)
        {
            number5y5 = 16;
            byte5y5button.Text = "1";
            panel5y5.BackColor = Color.Black;
        }

        private void byte5y4button_Click(object sender, EventArgs e)
        {
            number5y4 = 8;
            byte5y4button.Text = "1";
            panel5y4.BackColor = Color.Black;
        }

        private void byte5y3button_Click(object sender, EventArgs e)
        {
            number5y3 = 4;
            byte5y3button.Text = "1";
            panel5y3.BackColor = Color.Black;
        }

        private void byte5y1button_Click(object sender, EventArgs e)
        {
            number5y1 = 1;
            byte5y1button.Text = "1";
            panel5y1.BackColor = Color.Black;
        }
       

        private void byte4y8button_Click(object sender, EventArgs e)
        {
            number4y8 = 128;
            byte4y8button.Text = "1";
            panel4y8.BackColor = Color.Black;

        }

        private void byte4y7button_Click(object sender, EventArgs e)
        {
            number4y7 = 64;
            byte4y7button.Text = "1";
            panel4y7.BackColor = Color.Black;
        }

        private void byte4y6button_Click(object sender, EventArgs e)
        {
            number4y6 = 32;
            byte4y6button.Text = "1";
            panel4y6.BackColor = Color.Black;
        }

        private void byte4y5button_Click(object sender, EventArgs e)
        {
            number4y5 = 16;
            byte4y5button.Text = "1";
            panel4y5.BackColor = Color.Black;
        }

        private void byte4y4button_Click(object sender, EventArgs e)
        {
            number4y4 = 8;
            byte4y4button.Text = "1";
            panel4y4.BackColor = Color.Black;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void byte4y3button_Click(object sender, EventArgs e)
        {
            number4y3 = 4;
            byte4y3button.Text = "1";
            panel4y3.BackColor = Color.Black;
        }

        private void byte4y2button_Click(object sender, EventArgs e)
        {
            number4y2 = 2;
            byte4y2button.Text = "1";
            panel4y2.BackColor = Color.Black;
        }

        private void byte4y1button_Click(object sender, EventArgs e)
        {
            number4y1 = 1;
            byte4y1button.Text = "1";
            panel4y1.BackColor = Color.Black;
        }

        private void byte3y8button_Click(object sender, EventArgs e)
        {
            number3y8 = 128;
            byte3y8button.Text = "1";
            panel3y8.BackColor = Color.Black;
        }

        private void byte3y7button_Click(object sender, EventArgs e)
        {
            number3y7 = 64;
            byte3y7button.Text = "1";
            panel3y7.BackColor = Color.Black;
        }

        private void byte3y6button_Click(object sender, EventArgs e)
        {
            number3y6 = 32;
            byte3y6button.Text = "1";
            panel3y6.BackColor = Color.Black;
        }

        private void byte3y5button_Click(object sender, EventArgs e)
        {
            number3y5 = 16;
            byte3y5button.Text = "1";
            panel3y5.BackColor = Color.Black;
        }

        private void byte3y4button_Click(object sender, EventArgs e)
        {
            number3y4 = 8;
            byte3y4button.Text = "1";
            panel3y4.BackColor = Color.Black;
        }

        private void byte3y3button_Click(object sender, EventArgs e)
        {
            number3y3 = 4;
            byte3y3button.Text = "1";
            panel3y3.BackColor = Color.Black;
        }

        private void byte3y2button_Click(object sender, EventArgs e)
        {
            number3y2 = 2;
            byte3y2button.Text = "1";
            panel3y2.BackColor = Color.Black;
        }

        private void byte3y1button_Click(object sender, EventArgs e)
        {
            number3y1 = 1;
            byte3y1button.Text = "1";
            panel3y1.BackColor = Color.Black;
        }

        private void byte2y8button_Click(object sender, EventArgs e)
        {
            number2y8 = 128;
            byte2y8button.Text = "1";
            panel2y8.BackColor = Color.Black;
        }

        private void byte2y7button_Click(object sender, EventArgs e)
        {
            number2y7 = 64;
            byte2y7button.Text = "1";
            panel2y7.BackColor = Color.Black;
        }

        private void byte2y6button_Click(object sender, EventArgs e)
        {
            number2y6 = 32;
            byte2y6button.Text = "1";
            panel2y6.BackColor = Color.Black;
        }

        private void byte2y5button_Click(object sender, EventArgs e)
        {
            number2y5 = 16;
            byte2y5button.Text = "1";
            panel2y5.BackColor = Color.Black;
        }

        private void byte2y4button_Click(object sender, EventArgs e)
        {
            number2y4 = 8;
            byte2y4button.Text = "1";
            panel2y4.BackColor = Color.Black;
        }

        private void byte2y3button_Click(object sender, EventArgs e)
        {
            number2y3 = 4;
            byte2y3button.Text = "1";
            panel2y3.BackColor = Color.Black;
        }

        private void byte2y2button_Click(object sender, EventArgs e)
        {
            number2y2 = 2;
            byte2y2button.Text = "1";
            panel2y2.BackColor = Color.Black;
        }

        private void byte2y1button_Click(object sender, EventArgs e)
        {
            number2y1 = 1;
            byte2y1button.Text = "1";
            panel2y1.BackColor = Color.Black;
        }

        private void byte1y8button_Click(object sender, EventArgs e)
        {
            number1y8 = 128;
            byte1y8button.Text = "1";
            panel1y8.BackColor = Color.Black;
        }

        private void byte1y7button_Click(object sender, EventArgs e)
        {
            number1y7 = 64;
            byte1y7button.Text = "1";
            panel1y7.BackColor = Color.Black;
        }

        private void byte1y6button_Click(object sender, EventArgs e)
        {

            number1y6 = 32;
            byte1y6button.Text = "1";
            panel1y6.BackColor = Color.Black;
        }

        private void byte1y5button_Click(object sender, EventArgs e)
        {
            number1y5 = 16;
            byte1y5button.Text = "1";
            panel1y5.BackColor = Color.Black;
        }

        private void byte1y4button_Click(object sender, EventArgs e)
        {
            number1y4 = 8;
            byte1y4button.Text = "1";
            panel1y4.BackColor = Color.Black;
        }

        private void byte1y2button_Click(object sender, EventArgs e)
        {
            number1y2 = 2;
            byte1y2button.Text = "1";
            panel1y2.BackColor = Color.Black;
        }

        private void byte1y1button_Click(object sender, EventArgs e)
        {
            number1y1 = 1;
            byte1y1button.Text = "1";
            panel1y1.BackColor = Color.Black;
        }
        #endregion
    }

}
