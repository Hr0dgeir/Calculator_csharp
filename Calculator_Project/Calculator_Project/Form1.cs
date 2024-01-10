using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result;
        double number1;
        double number2;
        int choise;
        string last_panel;
        double sqrt;
        double one_dividedby_x;
        bool dot;
        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text += "";
            }
            else
            {
                richTextBox1.Text += 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 1.ToString();
            }
            else
            {
                richTextBox1.Text += 1.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 2.ToString();
            }
            else
            {
                richTextBox1.Text += 2.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 3.ToString();
            }
            else
            {
                richTextBox1.Text += 3.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 4.ToString();
            }
            else
            {
                richTextBox1.Text += 4.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 5.ToString();
            }
            else
            {
                richTextBox1.Text += 5.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 6.ToString();
            }
            else
            {
                richTextBox1.Text += 6.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 7.ToString();
            }
            else
            {
                richTextBox1.Text += 7.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 8.ToString();
            }
            else
            {
                richTextBox1.Text += 8.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.StartsWith("0"))
            {
                richTextBox1.Text = 9.ToString();
            }
            else
            {
                richTextBox1.Text += 9.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(richTextBox1.Text);
                choise = 1;
                richTextBox2.Text = richTextBox1.Text + " + ";
                richTextBox1.Text = "";
            }
            catch 
            {
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(richTextBox1.Text);
                choise = 2;
                richTextBox2.Text = richTextBox1.Text + " x ";
                richTextBox1.Text = "";
            }
            catch 
            {
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                number2 = Convert.ToDouble(richTextBox1.Text);
                choise_button();
                richTextBox1.Text = result.ToString();
                richTextBox2.Text += number2 + " = " + result + " ";
                if (number1 == 0)
                {
                    result = number2;
                    richTextBox1.Text = result.ToString();
                    richTextBox2.Text = result + " = ";
                }
            }
            catch 
            {
            }
        }

        public void choise_button()
        {
            if (choise == 1)
            {
                result = number1 + number2;
                last_panel = number1 + " + " + number2 + " = " + result;
                listBox1.Items.Add(last_panel);
            }
            if (choise == 2)
            {
                result = number1 * number2;
                last_panel = number1 + " X " + number2 + " = " + result;
                listBox1.Items.Add(last_panel);
            }
            if (choise == 3)
            {
                result = number1 - number2;
                last_panel = number1 + " - " + number2 + " = " + result;
                listBox1.Items.Add(last_panel);
            }
            if (choise == 4)
            {
                result = number1 / number2;
                last_panel = number1 + " / " + number2 + " = " + result;
                listBox1.Items.Add(last_panel);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(richTextBox1.Text);
                choise = 3;
                richTextBox2.Text = richTextBox1.Text + " - ";
                richTextBox1.Text = "";
            }
            catch 
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(richTextBox1.Text);
                choise = 4;
                richTextBox2.Text = richTextBox1.Text + " / ";
                richTextBox1.Text = "";
            }
            catch 
            {
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "0")
            {
                if (richTextBox1.Text.StartsWith("-"))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace("-", "");
                }
                else if (richTextBox1.Text.StartsWith(""))
                {
                    richTextBox1.Text = "-" + richTextBox1.Text;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            richTextBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(richTextBox1.Text);
                result = number1 * number1;
                listBox1.Items.Add(result);
                richTextBox2.Text = richTextBox1.Text + "²";
                richTextBox1.Text = result.ToString();
            }
            catch 
            {                
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                sqrt = Convert.ToDouble(richTextBox1.Text);
                result = Math.Sqrt(sqrt);
                listBox1.Items.Add(result);
                richTextBox2.Text = " √ " + sqrt;
                richTextBox1.Text = result.ToString();
            }
            catch 
            {
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "0"; 
            }

            
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            catch 
            {
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                one_dividedby_x = Convert.ToDouble(richTextBox1.Text);
                result = 1 / one_dividedby_x;
                richTextBox1.Text = result.ToString();
                richTextBox2.Text = 1 + "/" + one_dividedby_x;
                listBox1.Items.Add(result);
            }
            catch 
            {
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
