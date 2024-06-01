using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // Affiche Form1
            form4.Show();

            // Masque Form2
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Affiche Form1
            form2.Show();

            // Masque Form2
            this.Hide();
        }
    }
}
