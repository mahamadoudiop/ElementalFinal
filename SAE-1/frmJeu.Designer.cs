namespace SAE_1
{
    partial class frmJeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJeu));
            pnlLabyrinthe = new Panel();
            btnPause = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblPseudo = new Label();
            groupBox1 = new GroupBox();
            picPointVie1 = new PictureBox();
            picPointVie2 = new PictureBox();
            picPointVie3 = new PictureBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picPointVie1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPointVie2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPointVie3).BeginInit();
            SuspendLayout();
            // 
            // pnlLabyrinthe
            // 
            pnlLabyrinthe.Location = new Point(26, 101);
            pnlLabyrinthe.Name = "pnlLabyrinthe";
            pnlLabyrinthe.Size = new Size(605, 327);
            pnlLabyrinthe.TabIndex = 0;
            pnlLabyrinthe.Paint += pnlLabyrinthe_Paint;
            // 
            // btnPause
            // 
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Image = (Image)resources.GetObject("btnPause.Image");
            btnPause.Location = new Point(601, 4);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(42, 34);
            btnPause.TabIndex = 1;
            btnPause.Text = " ";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Location = new Point(-21, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 5);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Location = new Point(-25, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 5);
            panel2.TabIndex = 2;
            // 
            // lblPseudo
            // 
            lblPseudo.Location = new Point(242, 24);
            lblPseudo.Name = "lblPseudo";
            lblPseudo.Size = new Size(153, 38);
            lblPseudo.TabIndex = 4;
            lblPseudo.Text = "Pseudo";
            lblPseudo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(236, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 53);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // picPointVie1
            // 
            picPointVie1.Image = Properties.Resources.point_Vie;
            picPointVie1.Location = new Point(12, 445);
            picPointVie1.Name = "picPointVie1";
            picPointVie1.Size = new Size(44, 35);
            picPointVie1.SizeMode = PictureBoxSizeMode.Zoom;
            picPointVie1.TabIndex = 7;
            picPointVie1.TabStop = false;
            // 
            // picPointVie2
            // 
            picPointVie2.Image = Properties.Resources.point_Vie;
            picPointVie2.Location = new Point(12, 486);
            picPointVie2.Name = "picPointVie2";
            picPointVie2.Size = new Size(44, 35);
            picPointVie2.SizeMode = PictureBoxSizeMode.Zoom;
            picPointVie2.TabIndex = 8;
            picPointVie2.TabStop = false;
            // 
            // picPointVie3
            // 
            picPointVie3.Image = Properties.Resources.point_Vie;
            picPointVie3.Location = new Point(12, 527);
            picPointVie3.Name = "picPointVie3";
            picPointVie3.Size = new Size(44, 35);
            picPointVie3.SizeMode = PictureBoxSizeMode.Zoom;
            picPointVie3.TabIndex = 9;
            picPointVie3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(76, 445);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(555, 110);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "BONUS ";
            // 
            // frmJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(643, 567);
            Controls.Add(groupBox2);
            Controls.Add(picPointVie3);
            Controls.Add(picPointVie2);
            Controls.Add(picPointVie1);
            Controls.Add(lblPseudo);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnPause);
            Controls.Add(pnlLabyrinthe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jeu";
            FormClosing += frmJeu_FormClosing;
            Load += frmJeu_Load;
            KeyDown += frmJeu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picPointVie1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPointVie2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPointVie3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLabyrinthe;
        private Button btnPause;
        private Panel panel1;
        private Panel panel2;
        private Label lblPseudo;
        private GroupBox groupBox1;
        private PictureBox picPointVie1;
        private PictureBox picPointVie2;
        private PictureBox picPointVie3;
        private GroupBox groupBox2;
    }
}