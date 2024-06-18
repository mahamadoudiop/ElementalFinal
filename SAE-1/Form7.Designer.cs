namespace SAE_1
{
    partial class FormJeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeu));
            pnlLabyrinthe = new Panel();
            lblScrore = new Label();
            btnPause = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblPseudo = new Label();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // lblScrore
            // 
            lblScrore.AutoSize = true;
            lblScrore.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScrore.Location = new Point(12, 12);
            lblScrore.Name = "lblScrore";
            lblScrore.Size = new Size(52, 17);
            lblScrore.TabIndex = 2;
            lblScrore.Text = "Score : ";
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
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(94, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // FormJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(643, 567);
            Controls.Add(pictureBox4);
            Controls.Add(lblPseudo);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblScrore);
            Controls.Add(btnPause);
            Controls.Add(pnlLabyrinthe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jeu";
            FormClosing += FormJeu_FormClosing;
            Load += Form7_Load;
            KeyDown += FormJeu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLabyrinthe;
        private Label lblScrore;
        private Button btnPause;
        private Panel panel1;
        private Panel panel2;
        private Label lblPseudo;
        private GroupBox groupBox1;
        private PictureBox pictureBox4;
    }
}