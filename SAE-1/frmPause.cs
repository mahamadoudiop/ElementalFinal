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
    public partial class frmPause : Form
    {
        public frmPause()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions form6 = new frmOptions(this);
            form6.Show();
            this.Hide();
        }

        private void FormPause_Load(object sender, EventArgs e)
        {

        }

        private void btnReprendre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSauvegardePartie_Click(object sender, EventArgs e)
        {

        }
    }
}
