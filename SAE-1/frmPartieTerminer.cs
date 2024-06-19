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
    public partial class frmPartieTerminer : Form
    {
        public frmPartieTerminer()
        {
            InitializeComponent();
        }

        private void frmPartieTerminer_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmMenu formMenu = new frmMenu();
            formMenu.Show();
            this.Close();
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {

        }
    }
}
