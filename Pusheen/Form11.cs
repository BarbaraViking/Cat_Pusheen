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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.StartPosition = FormStartPosition.Manual;
            form10.Location = this.Location;

            form10.Show();
            this.Hide();

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.StartPosition = FormStartPosition.Manual;
            form14.Location = this.Location;

            form14.Show();
            this.Hide();

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
