using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pusheen
{
    public partial class Form6 : Form
    {
        int paid = 0;
        public Form6()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
            pictureBox7.Image = Image.FromFile(@"C:\Users\barbara\Desktop\дз англ\Screenshot_32.jpg");
            pictureBox7.Size = new Size(184, 169);
            pictureBox7.Location = new Point(278, 113);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            paid = 1;
            pictureBox7.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_36-edited-free (carve.photos).png");
            pictureBox7.Size = new Size(166, 167);
            pictureBox7.Location = new Point(288, 108);
            label2.Text = $"{paid}$";
        }
        //278, 113
        //184, 169
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            paid = 1;
            pictureBox7.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_37-edited-free (carve.photos).png");
            pictureBox7.Size = new Size(159, 166);
            pictureBox7.Location = new Point(291, 109);
            label2.Text = $"{paid}$";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            paid = 1;
            pictureBox7.Image = Image.FromFile(@"C:\Users\barbara\Downloads\Screenshot_33-edited-free (carve.photos).png");
            pictureBox7.Size = new Size(174, 164);
            pictureBox7.Location = new Point(283, 113);
            label2.Text = $"{paid}$";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.Show();
        }
    }
}
