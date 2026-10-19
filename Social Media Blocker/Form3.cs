using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Final_Project
{
    public partial class Form3 : Form
    {

        double num1, num2 , result ;
        string calTotal, option;
        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            option = "√";
            double root = Math.Sqrt(Convert.ToDouble(txt_total.Text));
            txt_total.Text = Convert.ToString(root);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + ".";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "2";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToDouble(txt_total.Text);
            txt_total.Clear();

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToDouble(txt_total.Text);
            txt_total.Clear();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            option = "X";
            num1 = Convert.ToDouble(txt_total.Text);
            txt_total.Clear();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txt_total.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            else if (option.Equals("-"))
                result = num1 - num2;
            else if (option.Equals("/"))
                result = num1 / num2;
            else if (option.Equals("X"))
                result = num1 * num2;
            else if (option.Equals("%"))
                result = (num1 /num2)* 100;
            txt_total.Text = Convert.ToString(result);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txt_total.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            else if (option.Equals("-"))
                result = num1 - num2;
            else if (option.Equals("/"))
                result = num1 / num2;
            else if (option.Equals("X"))
                result = num1 * num2;
            else if (option.Equals("%"))
                result = (num1 / num2) * 100;
            txt_total.Text = Convert.ToString(result);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToDouble(txt_total.Text);
            txt_total.Clear();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_total.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}
