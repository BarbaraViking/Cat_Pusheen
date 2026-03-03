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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.StartPosition = FormStartPosition.Manual;
            form14.Location = this.Location;

            form14.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
