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
    public partial class Form4 : Form
    {
        double angle = 0;

        int startY;
        int click5 = 0;
        int click6 = 0;
        int click2 = 0;
        int click3 = 0;
        int click7 = 0;
        int click8 = 0;
        public Form4()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
            startY = pictureBox9.Top;

            timer1.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            click3++;
            if (click3 == 1)
            {
                pictureBox15.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_19.jpg");
            }
            else if (click3 == 2)
            {
                pictureBox15.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_18.jpg");
                click3 = 0;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // код при загрузке формы
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 0.05; // скорость

            int offset = (int)(Math.Sin(angle) * 20); // амплитуда 20 пикселей

            pictureBox9.Top = startY + offset;

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            click5++;
            if (click5 == 1)
            {
                pictureBox13.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_16.jpg");
                pictureBox14.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_21.jpg");
            }
            else if (click5 == 2)
            {
                pictureBox13.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_15-edited-free (carve.photos).png");
                click5 = 0;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            click6++;
            if (click6 == 1)
            {
                pictureBox14.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_17.jpg");
                pictureBox13.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_15.jpg");
            }
            else if (click6 == 2)
            {
                pictureBox14.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_21-no-bg-preview (carve.photos).png");
                click6 = 0;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            click2++;
            if (click2 == 1)
            {
                pictureBox15.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_20.jpg");
            }
            else if (click2 == 2)
            {
                pictureBox15.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_18.jpg");
                click2 = 0;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            click7++;
            if (click7 == 1)
            {
                pictureBox9.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_6-no-bg-preview (carve.photos).png");
            }
            else if (click7 == 2)
            {
                pictureBox9.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_18.jpg");
                click7 = 0;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            click8++;
            if (click8 == 1)
            {
                pictureBox9.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_10-no-bg-preview (carve.photos).png");
            }
            else if (click8 == 2)
            {
                pictureBox9.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_18.jpg");
                click8 = 0;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.Show();
        }
    }
}
