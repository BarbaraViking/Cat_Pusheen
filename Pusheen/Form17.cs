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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.StartPosition = FormStartPosition.Manual;
            form12.Location = this.Location;

            form12.Show();
            this.Hide();
        }
    }
}
