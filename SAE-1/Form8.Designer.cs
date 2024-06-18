namespace SAE_1
{
    partial class FormEnregistrement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnregistrement));
            grbPseudo = new GroupBox();
            txtPseudoJoueur = new TextBox();
            btnRetour = new Button();
            btnJouer = new Button();
            grbPseudo.SuspendLayout();
            SuspendLayout();
            // 
            // grbPseudo
            // 
            grbPseudo.Controls.Add(txtPseudoJoueur);
            grbPseudo.Location = new Point(132, 63);
            grbPseudo.Name = "grbPseudo";
            grbPseudo.Size = new Size(351, 135);
            grbPseudo.TabIndex = 0;
            grbPseudo.TabStop = false;
            grbPseudo.Text = "ENTREZ VOTRE PSEUDO";
            // 
            // txtPseudoJoueur
            // 
            txtPseudoJoueur.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPseudoJoueur.Location = new Point(45, 56);
            txtPseudoJoueur.Name = "txtPseudoJoueur";
            txtPseudoJoueur.Size = new Size(251, 25);
            txtPseudoJoueur.TabIndex = 0;
            txtPseudoJoueur.TextChanged += txtPseudo_TextChanged;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.CadetBlue;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Image = (Image)resources.GetObject("btnRetour.Image");
            btnRetour.Location = new Point(12, 317);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(70, 67);
            btnRetour.TabIndex = 3;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnJouer
            // 
            btnJouer.Location = new Point(216, 244);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(152, 36);
            btnJouer.TabIndex = 4;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = true;
            btnJouer.Click += btnJouer_Click;
            // 
            // FormEnregistrement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 396);
            Controls.Add(btnJouer);
            Controls.Add(btnRetour);
            Controls.Add(grbPseudo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormEnregistrement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enregistrement";
            Load += FormEnregistrement_Load;
            grbPseudo.ResumeLayout(false);
            grbPseudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbPseudo;
        private TextBox txtPseudoJoueur;
        private Button btnRetour;
        private Button btnJouer;
    }
}