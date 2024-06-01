namespace SAE_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Affiche Form1
            form2.Show();

            // Masque Form2
            this.Hide();
        }
    }
}
