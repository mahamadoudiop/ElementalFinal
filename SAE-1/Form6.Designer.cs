namespace SAE_1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            btnRetour = new Button();
            grpCommande = new GroupBox();
            lblHaut = new Label();
            lblGauche = new Label();
            lblBas = new Label();
            lblDroite = new Label();
            pictureBox1 = new PictureBox();
            grpRegleDuJeu = new GroupBox();
            grpCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            grpCommande.Controls.Add(pictureBox1);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpRegleDuJeu
            // 
            grpRegleDuJeu.Location = new Point(51, 350);
            grpRegleDuJeu.Name = "grpRegleDuJeu";
            grpRegleDuJeu.Size = new Size(515, 260);
            grpRegleDuJeu.TabIndex = 5;
            grpRegleDuJeu.TabStop = false;
            grpRegleDuJeu.Text = "REGLE DU JEU";
            grpRegleDuJeu.Enter += groupBox2_Enter;
            // 
            // Form6
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
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            grpCommande.ResumeLayout(false);
            grpCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private GroupBox grpCommande;
        private GroupBox grpRegleDuJeu;
        private PictureBox pictureBox1;
        private Label lblHaut;
        private Label lblGauche;
        private Label lblBas;
        private Label lblDroite;
    }
}