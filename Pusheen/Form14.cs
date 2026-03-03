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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.StartPosition = FormStartPosition.Manual;
            form11.Location = this.Location;

            form11.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;

            form2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            Form15 form15 = new Form15();
            form15.StartPosition = FormStartPosition.Manual;
            form15.Location = this.Location;

            form15.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
