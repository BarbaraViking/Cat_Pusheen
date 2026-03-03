using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pusheen
{
    public partial class Form7 : Form
    {
        List<Image> frames = new List<Image>();
        int currentIndex = 0;
        public Form7()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
            timer1.Interval = 40;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = $"{progressBar1.Value}%";
                if (progressBar1.Value == 10)
                {
                    label6.Text = "+0.3";
                }
                if (progressBar1.Value == 45)
                {
                    label5.Text = "+0.1";
                }
                if (progressBar1.Value == 75)
                {
                    label7.Text = "+0.1";
                }
                if (progressBar1.Value == 95)
                {
                    label4.Text = "+0.4";
                }
            }
            else
            {
                timer1.Stop();
                Form8 form8 = new Form8();
                form8.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //label5_Click
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;

            form2.Show();
            this.Hide();
        }
    }
}
