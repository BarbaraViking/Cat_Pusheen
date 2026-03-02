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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
