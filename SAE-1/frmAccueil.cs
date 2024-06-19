namespace SAE_1
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //        private void btnJouer_Click(object sender, EventArgs e)
        //        {
        //            FormMenu FormMenu = new FormMenu();

        //            // Affiche FormAccueille
        //            FormMenu.Show();

        //            // Masque FormMenu
        //            this.Hide();
        //        }
        //    }
        //}



        private void btnJouer_Click(object sender, EventArgs e)
        {
            frmMenu FormMenu = new frmMenu();

            // Affiche FormAccueille
            FormMenu.Show();

            // Masque FormMenu
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
