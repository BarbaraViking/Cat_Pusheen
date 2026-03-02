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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
