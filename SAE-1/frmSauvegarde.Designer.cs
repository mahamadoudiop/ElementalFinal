namespace SAE_1
{
    partial class frmSauvegarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSauvegarde));
            btnContinuer = new Button();
            lblSauvegarde = new Label();
            picFeu = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)picFeu).BeginInit();
            SuspendLayout();
            // 
            // btnContinuer
            // 
            btnContinuer.BackColor = Color.LightBlue;
            btnContinuer.Location = new Point(207, 485);
            btnContinuer.Name = "btnContinuer";
            btnContinuer.Size = new Size(202, 50);
            btnContinuer.TabIndex = 9;
            btnContinuer.Text = "Continuer ";
            btnContinuer.UseVisualStyleBackColor = false;
            // 
            // lblSauvegarde
            // 
            lblSauvegarde.AutoSize = true;
            lblSauvegarde.BackColor = Color.Transparent;
            lblSauvegarde.BorderStyle = BorderStyle.FixedSingle;
            lblSauvegarde.Font = new Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSauvegarde.Location = new Point(171, 105);
            lblSauvegarde.Name = "lblSauvegarde";
            lblSauvegarde.Size = new Size(255, 35);
            lblSauvegarde.TabIndex = 14;
            lblSauvegarde.Text = "Sauvegarde n° ";
            // 
            // picFeu
            // 
            picFeu.Image = (Image)resources.GetObject("picFeu.Image");
            picFeu.Location = new Point(272, 194);
            picFeu.Name = "picFeu";
            picFeu.Size = new Size(54, 84);
            picFeu.SizeMode = PictureBoxSizeMode.Zoom;
            picFeu.TabIndex = 15;
            picFeu.TabStop = false;
            picFeu.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 313);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 16;
            label1.Text = "PSEUDO DU JOUEUR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(253, 395);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 17;
            label2.Text = "SCORE ATTEINT";
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
            btnRetour.TabIndex = 18;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // frmSauvegarde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(btnRetour);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picFeu);
            Controls.Add(lblSauvegarde);
            Controls.Add(btnContinuer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSauvegarde";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAUVEGARDE";
            ((System.ComponentModel.ISupportInitialize)picFeu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnContinuer;
        private Label lblSauvegarde;
        private PictureBox picFeu;
        private Label label1;
        private Label label2;
        private Button btnRetour;
    }
}