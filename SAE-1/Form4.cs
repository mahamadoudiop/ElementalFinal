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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lblAncienneSauv_Click(object sender, EventArgs e)
        {

        }

        private void btnSauv1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            // Affiche Form1
            form5.Show();

            // Masque FormMenu
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu FormMenu = new FormMenu();

            // Affiche Form1
            FormMenu.Show();

            // Masque FormMenu
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Affiche Form1
            form3.Show();

            // Masque FormMenu
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
