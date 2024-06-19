namespace SAE_1
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            btnRetour = new Button();
            grpCommande = new GroupBox();
            lblHaut = new Label();
            lblGauche = new Label();
            lblBas = new Label();
            lblDroite = new Label();
            picCommande = new PictureBox();
            grpRegleDuJeu = new GroupBox();
            textBox1 = new TextBox();
            grpCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCommande).BeginInit();
            grpRegleDuJeu.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.CadetBlue;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Image = (Image)resources.GetObject("btnRetour.Image");
            btnRetour.Location = new Point(12, 652);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(70, 67);
            btnRetour.TabIndex = 3;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // grpCommande
            // 
            grpCommande.Controls.Add(lblHaut);
            grpCommande.Controls.Add(lblGauche);
            grpCommande.Controls.Add(lblBas);
            grpCommande.Controls.Add(lblDroite);
            grpCommande.Controls.Add(picCommande);
            grpCommande.Location = new Point(89, 48);
            grpCommande.Name = "grpCommande";
            grpCommande.Size = new Size(435, 260);
            grpCommande.TabIndex = 4;
            grpCommande.TabStop = false;
            grpCommande.Text = "COMMANDE";
            grpCommande.Enter += groupBox1_Enter;
            // 
            // lblHaut
            // 
            lblHaut.AutoSize = true;
            lblHaut.Location = new Point(180, 30);
            lblHaut.Name = "lblHaut";
            lblHaut.Size = new Size(76, 15);
            lblHaut.TabIndex = 9;
            lblHaut.Text = "Aller en Haut";
            // 
            // lblGauche
            // 
            lblGauche.AutoSize = true;
            lblGauche.Location = new Point(11, 168);
            lblGauche.Name = "lblGauche";
            lblGauche.Size = new Size(83, 15);
            lblGauche.TabIndex = 8;
            lblGauche.Text = "Aller à Gauche";
            // 
            // lblBas
            // 
            lblBas.AutoSize = true;
            lblBas.Location = new Point(180, 215);
            lblBas.Name = "lblBas";
            lblBas.Size = new Size(68, 15);
            lblBas.TabIndex = 7;
            lblBas.Text = "Aller en Bas";
            // 
            // lblDroite
            // 
            lblDroite.AutoSize = true;
            lblDroite.Location = new Point(344, 168);
            lblDroite.Name = "lblDroite";
            lblDroite.Size = new Size(75, 15);
            lblDroite.TabIndex = 6;
            lblDroite.Text = "Aller à Droite";
            // 
            // picCommande
            // 
            picCommande.Image = (Image)resources.GetObject("picCommande.Image");
            picCommande.Location = new Point(100, 57);
            picCommande.Name = "picCommande";
            picCommande.Size = new Size(238, 145);
            picCommande.TabIndex = 0;
            picCommande.TabStop = false;
            picCommande.Click += pictureBox1_Click;
            // 
            // grpRegleDuJeu
            // 
            grpRegleDuJeu.Controls.Add(textBox1);
            grpRegleDuJeu.Location = new Point(51, 350);
            grpRegleDuJeu.Name = "grpRegleDuJeu";
            grpRegleDuJeu.Size = new Size(515, 260);
            grpRegleDuJeu.TabIndex = 5;
            grpRegleDuJeu.TabStop = false;
            grpRegleDuJeu.Text = "REGLE DU JEU";
            grpRegleDuJeu.Enter += groupBox2_Enter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CadetBlue;
            textBox1.Location = new Point(38, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(448, 232);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // frmOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(grpRegleDuJeu);
            Controls.Add(grpCommande);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmOptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OPTIONS";
            Load += Form6_Load;
            grpCommande.ResumeLayout(false);
            grpCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCommande).EndInit();
            grpRegleDuJeu.ResumeLayout(false);
            grpRegleDuJeu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private GroupBox grpCommande;
        private GroupBox grpRegleDuJeu;
        private PictureBox picCommande;
        private Label lblHaut;
        private Label lblGauche;
        private Label lblBas;
        private Label lblDroite;
        private TextBox textBox1;
    }
}