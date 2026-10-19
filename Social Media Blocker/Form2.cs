using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            
            {
                // Checking if Form4 for Facebook already exists
                Form4 form = Application.OpenForms
                    .OfType<Form4>()
                    .FirstOrDefault(f => f.AppName == "Facebook");

                if (form == null) //if no existing form
                {
                    form = new Form4();
                    form.AppName = "Facebook";
                }
                this.Hide();
                form.Show();
            }
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Checking if Form4 for Tiktok already exists
                Form4 form = Application.OpenForms
                    .OfType<Form4>()
                    .FirstOrDefault(f => f.AppName == "Tiktok");

                if (form == null) // no existing form
                {
                    form = new Form4();
                    form.AppName = "Tiktok";
                }

                this.Hide();
                form.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                // Check if Form4 for Snapchat already exists
                Form4 form = Application.OpenForms
                    .OfType<Form4>()
                    .FirstOrDefault(f => f.AppName == "Snapchat");

                if (form == null) // no existing form
                {
                     form = new Form4();
                    form.AppName = "Snapchat";
                }

                this.Hide();
                form.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                // Checking if Form4 for Instagram already exists
                Form4 form = Application.OpenForms
                    .OfType<Form4>()
                    .FirstOrDefault(f => f.AppName == "Instagram");

                if (form == null) // no existing form
                {
                    form = new Form4();
                    form.AppName = "Instagram";
                }

                this.Hide();
                form.Show();
            }
        }
    }
}
