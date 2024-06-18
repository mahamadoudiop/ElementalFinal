namespace SAE_1
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            btnJouer = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblNomJeu = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(508, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 84);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(263, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(263, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 62);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(88, 138);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 76);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // lblNomJeu
            // 
            lblNomJeu.AutoSize = true;
            lblNomJeu.BackColor = Color.Transparent;
            lblNomJeu.BorderStyle = BorderStyle.FixedSingle;
            lblNomJeu.FlatStyle = FlatStyle.Flat;
            lblNomJeu.Font = new Font("Frank Ruehl CLM", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 177);
            lblNomJeu.Location = new Point(149, 162);
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
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnJouer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormAccueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACCUEIL";
            Load += FormAccueil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJouer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblNomJeu;
    }
}
