using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double num = 0,sum=0;
        int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case 0:
                    Console.WriteLine("error");
                    break;
                case 1:
                    sum = num + int.Parse(textBox1.Text);
                    textBox1.Text = sum.ToString();
                    break;
                case 2:
                    sum = num - int.Parse(textBox1.Text);
                    textBox1.Text = sum.ToString();
                    break;
                case 3:
                    sum = num * int.Parse(textBox1.Text);
                textBox1.Text = sum.ToString();
                break;
                case 4:
                    sum = num / int.Parse(textBox1.Text);
                textBox1.Text = sum.ToString();
                break;
            }

        }
        //+
        private void btn_add_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            op = 1;
            textBox1.Text = "";
        }
        //-
        private void btn_sub_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            op = 2;
            textBox1.Text = "";
        }
        //*
        private void btn_mult_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            op = 3;
            textBox1.Text = "";
        }
        ///
        private void btn_div_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            op = 4;
            textBox1.Text = "";
        }
        //



    }
}
