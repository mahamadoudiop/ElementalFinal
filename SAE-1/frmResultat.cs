﻿using System;
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
    public partial class frmResultat : Form
    {
        public frmResultat()
        {
            InitializeComponent();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            frmPartieTerminer formPartieTerminer = new frmPartieTerminer();
            formPartieTerminer.Show();
            this.Hide();
        }
    }
}
