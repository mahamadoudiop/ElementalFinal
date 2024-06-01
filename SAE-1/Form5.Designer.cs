namespace SAE_1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            btnContinuer = new Button();
            pbCadreSauv = new PictureBox();
            lblSauvegarde = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCadreSauv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pbCadreSauv
            // 
            pbCadreSauv.Image = Properties.Resources.cadre;
            pbCadreSauv.Location = new Point(89, 48);
            pbCadreSauv.Name = "pbCadreSauv";
            pbCadreSauv.Size = new Size(473, 617);
            pbCadreSauv.TabIndex = 10;
            pbCadreSauv.TabStop = false;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 84);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
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
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblSauvegarde);
            Controls.Add(btnContinuer);
            Controls.Add(pbCadreSauv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pbCadreSauv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnContinuer;
        private PictureBox pbCadreSauv;
        private Label lblSauvegarde;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}