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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
            List<string> words = new List<string>
            {
                "Puurrrfect!",
                "Meowgical!",
                "Purr-fection!"
            };
            label1.Text = words[new Random().Next(words.Count)];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;

            form2.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
