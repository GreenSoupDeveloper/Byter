using System;
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
        

        public Form1()
        {
            InitializeComponent();
            
            
            

        }

      
         
      

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

        private void letterresultbutton_Click(object sender, EventArgs e)
        {
            reset();
            if (letterinput.Text == "a")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox11.Text = "1"; number1 = 1;
            }
            if (letterinput.Text == "b")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox2.Text = "1"; number2 = 2;
            }
            if (letterinput.Text == "c")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox11.Text = "1"; number1 = 1;
                textBox2.Text = "1"; number2 = 2;
            }
            if (letterinput.Text == "d")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox3.Text = "1"; number3 = 4;
            }
            if (letterinput.Text == "e")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox3.Text = "1"; number3 = 4;
                textBox11.Text = "1"; number1 = 1;
            }
            if (letterinput.Text == "f")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox3.Text = "1"; number3 = 4;
                textBox2.Text = "1"; number2 = 2;
            }
            if (letterinput.Text == "g")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox3.Text = "1"; number3 = 4;
                textBox2.Text = "1"; number2 = 2;
                textBox11.Text = "1"; number1 = 1;
            }
            if (letterinput.Text == "h")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
          
            }
            if (letterinput.Text == "i")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox11.Text = "1"; number1 = 1;

            }
            if (letterinput.Text == "j")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox2.Text = "1"; number2 = 2;

            }
            if (letterinput.Text == "k")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox2.Text = "1"; number2 = 2;
                textBox11.Text = "1"; number1 = 1;

            }
            if (letterinput.Text == "l")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox3.Text = "1"; number3 = 4;
           

            }
            if (letterinput.Text == "m")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox3.Text = "1"; number3 = 4;
                textBox11.Text = "1"; number1 = 1;


            }
            if (letterinput.Text == "n")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox3.Text = "1"; number3 = 4;
                textBox2.Text = "1"; number2 = 2;


            }
            if (letterinput.Text == "o")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox4.Text = "1"; number4 = 8;
                textBox3.Text = "1"; number3 = 4;
                textBox2.Text = "1"; number2 = 2;
                textBox11.Text = "1"; number1 = 1;


            }
            if (letterinput.Text == "p")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
     


            }
            if (letterinput.Text == "q")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox11.Text = "1"; number1 = 1;



            }
            if (letterinput.Text == "r")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox2.Text = "1"; number2 = 2;



            }
            if (letterinput.Text == "s")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox2.Text = "1"; number2 = 2;
                textBox11.Text = "1"; number1 = 1;



            }
            if (letterinput.Text == "t")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox3.Text = "1"; number3 = 4;
          



            }
            if (letterinput.Text == "u")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox3.Text = "1"; number3 = 4;
                textBox11.Text = "1"; number1 = 1;




            }
            if (letterinput.Text == "v")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox3.Text = "1"; number3 = 4;
                textBox2.Text = "1"; number2 = 2;




            }
            if (letterinput.Text == "w")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox3.Text = "1"; number3 = 4;
                textBox2.Text = "1"; number2 = 2;
                textBox11.Text = "1"; number1 = 1;




            }
            if (letterinput.Text == "x")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox4.Text = "1"; number4 = 8;
      




            }
            if (letterinput.Text == "y")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox4.Text = "1"; number4 = 8;
                textBox11.Text = "1"; number1 = 1;





            }
            if (letterinput.Text == "z")
            {
                reset();
                textBox7.Text = "1"; number7 = 64;
                textBox6.Text = "1"; number6 = 32;
                textBox5.Text = "1"; number5 = 16;
                textBox4.Text = "1"; number4 = 8;
                textBox2.Text = "1"; number2 = 2;
            }
            if (letterinput.Text == "" || letterinput.Text == " ")
            {
                typesmth terWindow = new typesmth();
                terWindow.Show();
            }


            var resultint = number8 + number7 + number6 + number5 + number4 + number3 + number2 + number1;
            result.Text = resultint.ToString();
        }

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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondWindow = new Form2();
            secondWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
