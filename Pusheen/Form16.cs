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
    public partial class Form16 : Form
    {
        public Form16()
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
                form8.StartPosition = FormStartPosition.Manual;
                form8.Location = this.Location;

                form8.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
