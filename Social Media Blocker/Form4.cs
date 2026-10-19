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
    
    public partial class Form4 : Form
    {
        public string AppName = "";

        bool IsTimerRunning = false;

        int Timer = 60;
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            IsTimerRunning = true;
            textBox1.Enabled = false;
            btn_SetTimer.Enabled = false;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            IsTimerRunning = false;

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                
                Timer = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                
                Timer = 60;
            }
            
                lbl_seconds.Text = Timer + " Seconds";


            timer1.Start();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (IsTimerRunning == false)
            {
                timer1.Start();
                IsTimerRunning = true;
            }
            else if (IsTimerRunning == true)
            {
                timer1.Stop();
                IsTimerRunning = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer > 0)
            {
                Timer -= 1;

                {
                    if (Timer > 9)
                    {
                        lbl_seconds.Text = Timer + " Seconds";
                    }
                    else
                    {
                        lbl_seconds.Text = "0" + Timer + " Seconds";

                    }

                }
            }
            //switch case
            if (Timer < 0.5)
            {
                timer1.Stop();
                IsTimerRunning = false;

                textBox1.Enabled = true;
                btn_SetTimer.Enabled = true;

                switch (AppName)
                {
                    case "Facebook":
                        Form5 fbForm = new Form5();
                        fbForm.Show();
                        break;

                    case "Instagram":
                        Form6 instaForm = new Form6();
                        instaForm.Show();
                        break;

                    case "Snapchat":
                        Form7 snapForm = new Form7();
                        snapForm.Show();
                        break;

                    case "Tiktok":
                        Form8 tikForm = new Form8();
                        tikForm.Show(); 
                        break;
                }

                this.Close();
            }

        }

        private void btn_SetTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a time before clicking Set.");
                return;  
            }
            if (!int.TryParse(textBox1.Text, out Timer))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
           

            if (Timer <= 0)
            {
                MessageBox.Show("Please Enter a valid time");
                return;
                
            }
            Timer = Convert.ToInt32(textBox1.Text);
            lbl_seconds.Text = Timer + " Seconds";
            timer1.Start();

            textBox1.Enabled = false;
            btn_SetTimer.Enabled = false;



        }

        private void btn_1hour_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer = 3600;
            lbl_seconds.Text = Timer + " Seconds";
            timer1.Start();
            textBox1.Enabled = false;
            btn_SetTimer.Enabled = false;
        }

        private void btn_2hour_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer = 7200;
            lbl_seconds.Text = Timer + " Seconds";
            timer1.Start();
            textBox1.Enabled = false;
            btn_SetTimer.Enabled = false;
        }

        private void btn_6hour_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Timer = 21600;
            lbl_seconds.Text = Timer + " Seconds";
            timer1.Start();
            textBox1.Enabled = false;
            btn_SetTimer.Enabled = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
