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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void linkLabel_tiktok_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pokemongo.com/");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
