using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculate
{ 
    public partial class Form1 : Form
    {
        float x, y;
        int count; /// <summary>
        /// переменная count нужна для кейсов, если что
        /// </summary>
        bool sign = true; /// <summary>
        /// изначально знак перед числом положительный
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        private void calculate()
        {
            switch (count)
            {
                case 1:
                    y = x + float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 2:
                    y = x - float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 3:
                    y = x * float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 4:
                    y = x / float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;

                default:
                    break;
            }

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = x.ToString() + "-";
            sign = true;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = x.ToString() + "*";
            sign = true;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = x.ToString() + "/";
            sign = true;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string lengthOfNumbers = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + lengthOfNumbers[i];
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = false;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = x.ToString() + "+";
            sign = true;
        }
    }
}
