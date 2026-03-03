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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.StartPosition = FormStartPosition.Manual;
            form9.Location = this.Location;

            form9.Show();
            this.Hide();

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;

            form2.Show();
            this.Hide();
        }
    }
}
