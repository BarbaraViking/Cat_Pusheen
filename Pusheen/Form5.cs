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
    public partial class Form5 : Form
    {
        Random rand = new Random();
        List<PictureBox> balls = new List<PictureBox>();
        System.Windows.Forms.Timer spawnTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer moveTimer = new System.Windows.Forms.Timer();
        int count_ball = 0;
        Image ballImage = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_22-no-bg-preview (carve.photos).png"); // путь к твоему PNG
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(252, 240, 228);

            // Таймер спавна
            spawnTimer.Interval = 1000;
            spawnTimer.Tick += SpawnTimer_Tick;
            spawnTimer.Start();

            // Таймер движения
            moveTimer.Interval = 20;
            moveTimer.Tick += MoveTimer_Tick;
            moveTimer.Start();
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            PictureBox ball = new PictureBox();
            ball.SizeMode = PictureBoxSizeMode.AutoSize; // размер по картинке
            ball.Image = ballImage;
            ball.Top = 0;
            ball.Left = rand.Next(0, this.ClientSize.Width); //  - ball.Width
            ball.Tag = rand.Next(3, 5); // скорость
            ball.BackColor = Color.Transparent;
            ball.Click += Ball_Click;
            this.Controls.Add(ball);
            balls.Add(ball);
        }
        private void Ball_Click(object sender, EventArgs e)
        {
            // sender — это тот PictureBox, по которому кликнули
            PictureBox clickedBall = sender as PictureBox;
            if (clickedBall != null)
            {
                // например, удаляем шарик
                this.Controls.Remove(clickedBall);
                balls.Remove(clickedBall);
                clickedBall.Dispose();
                count_ball++; // увеличиваем счетчик
                label1.Text = $"{count_ball}";

                // или выводим сообщение
            }
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = balls.Count - 1; i >= 0; i--)
            {
                PictureBox ball = balls[i];
                int speed = (int)ball.Tag;
                ball.Top += speed;

                if (ball.Top > this.ClientSize.Height)
                {
                    this.Controls.Remove(ball);
                    balls.RemoveAt(i);
                    ball.Dispose();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
