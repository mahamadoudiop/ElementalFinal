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
    public partial class frmPartie : Form
    {
        public frmPartie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnciennesSauvegarde form4 = new frmAnciennesSauvegarde();

            // Affiche FormAccueille
            form4.Show();

            // Masque FormMenu
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmMenu FormMenu = new frmMenu();
            FormMenu.Show();
            this.Close();
        }

        

        private void btnJouer_Click(object sender, EventArgs e)
        {
            frmEnregistrement FormEnregistrement = new frmEnregistrement();  
            FormEnregistrement.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
