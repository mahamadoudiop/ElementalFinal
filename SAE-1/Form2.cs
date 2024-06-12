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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 


        private void btnPartie_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
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
