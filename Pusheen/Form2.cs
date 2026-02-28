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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);

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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e) // eating
        {
            string[] variants = { @"C:\Users\barbara\Downloads\gif\flake.gif", @"C:\Users\barbara\Downloads\gif\eat.gif", @"C:\Users\barbara\Downloads\gif\eat2.gif", @"C:\Users\barbara\Downloads\gif\eat3.gif", @"C:\Users\barbara\Downloads\gif\eat4.gif" };
            Random rd = new Random();
            string randomItem = variants[rd.Next(variants.Length)];
            pictureBox1.Image = Image.FromFile(randomItem);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
