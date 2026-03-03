using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pusheen
{
    public partial class Form2 : Form
    {
        static int happy = 100;
        bool isClicked = false;
        Stopwatch sw = new Stopwatch();

        bool next = false;
        public Form2()
        {

            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);

            sw.Start();
            timer1.Interval = 40;
            timer1.Tick += Timer1_Tick;
            
            progressBar1.Value = happy;
            timer1.Start();
            label8.Text = $"{progressBar1.Value}%";

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds > 4000 && isClicked == false)
            {
                if (happy <= 3)
                {
                    happy = 0;
                    progressBar1.Value = happy;
                    progressBar1.ForeColor = Color.Red;

                }
                else
                {
                    if (happy <= 50 && happy > 20) progressBar1.ForeColor = Color.Orange;
                    if (happy >= 51) progressBar1.ForeColor = Color.Green;
                    happy -= 3;
                    if (happy > 100)
                    {
                        happy = 100;
                    }
                    progressBar1.Value = happy;

                }
                sw.Restart();   // перезапуск таймера
                label8.Text = $"{progressBar1.Value}%";
            }
        }
        private void ProgressBar1_Paint(object sender, PaintEventArgs e)
{
    Rectangle rect = progressBar1.ClientRectangle;

    // фон
    e.Graphics.FillRectangle(Brushes.LightGray, rect);

    // вычисляем ширину прогресса
    rect.Width = (int)(rect.Width * ((double)progressBar1.Value / progressBar1.Maximum));

    // выбираем цвет в зависимости от значения
    Brush progressColor;
    if (progressBar1.Value > 70)
        progressColor = Brushes.Green;
    else if (progressBar1.Value > 30)
        progressColor = Brushes.Orange;
    else
        progressColor = Brushes.Red;

    // рисуем прогресс
    e.Graphics.FillRectangle(progressColor, 0, 0, rect.Width, rect.Height);
}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.StartPosition = FormStartPosition.Manual;
            form7.Location = this.Location;

            form7.Show();
            this.Hide();
            happy+= 1;
            isClicked = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private async void pictureBox3_Click(object sender, EventArgs e) // eating
        {
            string[] variants = { @"C:\Users\barbara\Downloads\gif\flake.gif", @"C:\Users\barbara\Downloads\gif\eat.gif", @"C:\Users\barbara\Downloads\gif\eat2.gif", @"C:\Users\barbara\Downloads\gif\eat3.gif", @"C:\Users\barbara\Downloads\gif\eat4.gif" };
            Random rd = new Random();
            string randomItem = variants[rd.Next(variants.Length)];
            pictureBox1.Image = Image.FromFile(randomItem);
            await Task.Delay(2000);
            happy += 10;
            isClicked = true;
            await Task.Delay(5000);
            isClicked = false;
            pictureBox1.Image = Image.FromFile(@"C:\Users\barbara\Downloads\gif\sleep1.gif");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = this.Location;

            form3.Show();
            this.Hide();

        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.StartPosition = FormStartPosition.Manual;
            form12.Location = this.Location;

            form12.Show();
            this.Hide();
            happy += 10;
            isClicked = true;
            await Task.Delay(5000);
            isClicked = false;

        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.StartPosition = FormStartPosition.Manual;
            form13.Location = this.Location;

            form13.Show();
            this.Hide();
            happy += 10;
            isClicked = true;
            await Task.Delay(5000);
            isClicked = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private async void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.StartPosition = FormStartPosition.Manual;
            form16.Location = this.Location;

            form16.Show();
            this.Hide();
            happy += 10;
            isClicked = true;
            await Task.Delay(5000);
            isClicked = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
