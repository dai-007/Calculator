using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public int num1 { get; set; }
        public int num2 { get; set; }
        public int result { get; set; }
        public string mathOperator { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            mathOperator = "+";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            mathOperator = "-";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            mathOperator = "*";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            mathOperator = "/";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtTotal.Text);

            if (mathOperator.Equals("+"))
                result = num1 + num2;
            
            if (mathOperator.Equals("-"))
                result = num1 - num2;
            
            if (mathOperator.Equals("*"))
                result = num1 * num2;
            
            if (mathOperator.Equals("/"))
                result = num1 / num2;

            txtTotal.Text = result.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}
