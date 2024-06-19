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
    public partial class frmAnciennesSauvegarde : Form
    {
        public frmAnciennesSauvegarde()
        {
            InitializeComponent();
        }

        private void lblAncienneSauv_Click(object sender, EventArgs e)
        {

        }

        private void btnSauv1_Click(object sender, EventArgs e)
        {
            frmSauvegarde form5 = new frmSauvegarde();

            // Affiche Form1
            form5.Show();

            // Masque FormMenu
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu FormMenu = new frmMenu();

            // Affiche Form1
            FormMenu.Show();

            // Masque FormMenu
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmPartie form3 = new frmPartie();

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
