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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // Affiche FormAccueille
            form4.Show();

            // Masque FormMenu
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenu FormMenu = new FormMenu();
            FormMenu.Show();
            this.Close();
        }

        

        private void btnJouer_Click(object sender, EventArgs e)
        {
            FormEnregistrement FormEnregistrement = new FormEnregistrement();  
            FormEnregistrement.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
