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
    public partial class Form13 : Form
    {
        List<Image> frames = new List<Image>();
        string[] variants = { @"C:\Users\barbara\Downloads\gif\sleep1.gif", @"C:\Users\barbara\Downloads\gif\sleep2.gif", @"C:\Users\barbara\Downloads\gif\sleep3.gif" };

        int currentIndex = 0;
        public Form13()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            Random rd = new Random();
            string randomItem = variants[rd.Next(variants.Length)];
            pictureBox2.Image = Image.FromFile(randomItem);

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
        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
