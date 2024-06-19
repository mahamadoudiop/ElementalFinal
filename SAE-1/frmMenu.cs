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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            frmOptions form6 = new frmOptions();
            form6.Show();
            this.Hide();
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 


        private void btnPartie_Click(object sender, EventArgs e)
        {
            frmPartie form3 = new frmPartie();
            form3.Show();
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter le jeu ?",
                                                   "Confirmer la fermeture",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // on selection le button 2 pour eviter que l'utiliseur click deux fois sur entrer et donc quitte par erreur l'aplication

            if (result == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            { 
                Application.Exit();
             }
        }
    }
}
