namespace SAE_1
{
    partial class frmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            btnJouer = new Button();
            picFeu = new PictureBox();
            picNuage = new PictureBox();
            picPierre = new PictureBox();
            picEau = new PictureBox();
            lblNomJeu = new Label();
            ((System.ComponentModel.ISupportInitialize)picFeu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNuage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPierre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEau).BeginInit();
            SuspendLayout();
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.LightBlue;
            btnJouer.Location = new Point(203, 322);
            btnJouer.Margin = new Padding(3, 2, 3, 2);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(228, 44);
            btnJouer.TabIndex = 1;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // picFeu
            // 
            picFeu.BackColor = Color.Transparent;
            picFeu.Image = (Image)resources.GetObject("picFeu.Image");
            picFeu.Location = new Point(508, 138);
            picFeu.Name = "picFeu";
            picFeu.Size = new Size(58, 84);
            picFeu.TabIndex = 2;
            picFeu.TabStop = false;
            picFeu.Click += pictureBox1_Click_1;
            // 
            // picNuage
            // 
            picNuage.BackColor = Color.Transparent;
            picNuage.Image = (Image)resources.GetObject("picNuage.Image");
            picNuage.Location = new Point(263, 55);
            picNuage.Name = "picNuage";
            picNuage.Size = new Size(84, 50);
            picNuage.TabIndex = 3;
            picNuage.TabStop = false;
            picNuage.Click += pictureBox2_Click;
            // 
            // picPierre
            // 
            picPierre.BackColor = Color.Transparent;
            picPierre.Image = (Image)resources.GetObject("picPierre.Image");
            picPierre.Location = new Point(263, 224);
            picPierre.Name = "picPierre";
            picPierre.Size = new Size(100, 62);
            picPierre.TabIndex = 4;
            picPierre.TabStop = false;
            // 
            // picEau
            // 
            picEau.BackColor = Color.Transparent;
            picEau.Image = (Image)resources.GetObject("picEau.Image");
            picEau.Location = new Point(88, 138);
            picEau.Name = "picEau";
            picEau.Size = new Size(55, 76);
            picEau.TabIndex = 5;
            picEau.TabStop = false;
            // 
            // lblNomJeu
            // 
            lblNomJeu.AutoSize = true;
            lblNomJeu.BackColor = Color.Transparent;
            lblNomJeu.BorderStyle = BorderStyle.FixedSingle;
            lblNomJeu.FlatStyle = FlatStyle.Flat;
            lblNomJeu.Font = new Font("Frank Ruehl CLM", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 177);
            lblNomJeu.Location = new Point(164, 162);
            lblNomJeu.Name = "lblNomJeu";
            lblNomJeu.Size = new Size(313, 32);
            lblNomJeu.TabIndex = 8;
            lblNomJeu.Text = "ELEMENTAL ODYSSEY";
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 426);
            Controls.Add(lblNomJeu);
            Controls.Add(picEau);
            Controls.Add(picPierre);
            Controls.Add(picNuage);
            Controls.Add(picFeu);
            Controls.Add(btnJouer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormAccueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAccueil";
            ((System.ComponentModel.ISupportInitialize)picFeu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNuage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPierre).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJouer;
        private PictureBox picFeu;
        private PictureBox picNuage;
        private PictureBox picPierre;
        private PictureBox picEau;
        private Label lblNomJeu;
    }
}
