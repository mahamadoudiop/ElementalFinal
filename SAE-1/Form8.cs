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

namespace SAE_1
{
    public partial class FormEnregistrement : Form
    {
        public FormEnregistrement()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenu FormMenu = new FormMenu();
            FormMenu.Show();
            this.Close();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            FormJeu formJeu = new FormJeu(txtPseudo.Text);
            formJeu.Show();
            this.Close();
        }

        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            //TextBox txtPseudo = (TextBox)sender;
        }

        private void FormEnregistrement_Load(object sender, EventArgs e)
        {

        }
    }
}
