using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using SAE1BibliothequeJeu;

namespace SAE_1
{
    public partial class frmEnregistrement : Form
    {
        public frmEnregistrement()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmMenu FormMenu = new frmMenu();
            FormMenu.Show();
            this.Close();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Partie P; frmJeu frmJeu;
            P = new Partie(txtPseudoJoueur.Text);

            frmJeu = new frmJeu(P);
            frmJeu.Show();
            this.Close();
        }

        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            TextBox txtPseudoJoueur = (TextBox)sender;

        }

        private void FormEnregistrement_Load(object sender, EventArgs e)
        {

        }
    }
}
