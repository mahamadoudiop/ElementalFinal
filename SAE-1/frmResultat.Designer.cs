namespace SAE_1
{
    partial class frmResultat
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
            groupBox1 = new GroupBox();
            txtScore = new TextBox();
            groupBox2 = new GroupBox();
            txtBonusRecolter = new TextBox();
            groupBox3 = new GroupBox();
            txtTempsEcouler = new TextBox();
            lblResultat = new Label();
            btnSuivant = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtScore);
            groupBox1.Location = new Point(95, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SCORE  :";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(92, 50);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(208, 23);
            txtScore.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBonusRecolter);
            groupBox2.Location = new Point(95, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "NOMBRE BONUS RECOLTER";
            // 
            // txtBonusRecolter
            // 
            txtBonusRecolter.Location = new Point(92, 50);
            txtBonusRecolter.Name = "txtBonusRecolter";
            txtBonusRecolter.Size = new Size(208, 23);
            txtBonusRecolter.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTempsEcouler);
            groupBox3.Location = new Point(95, 445);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 116);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "TEMPS ECOULER";
            // 
            // txtTempsEcouler
            // 
            txtTempsEcouler.Location = new Point(92, 47);
            txtTempsEcouler.Name = "txtTempsEcouler";
            txtTempsEcouler.Size = new Size(208, 23);
            txtTempsEcouler.TabIndex = 2;
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultat.Location = new Point(234, 81);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(110, 22);
            lblResultat.TabIndex = 2;
            lblResultat.Text = "RESULTAT";
            // 
            // btnSuivant
            // 
            btnSuivant.BackColor = Color.LightBlue;
            btnSuivant.Location = new Point(234, 631);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new Size(110, 35);
            btnSuivant.TabIndex = 3;
            btnSuivant.Text = "SUIVANT";
            btnSuivant.UseVisualStyleBackColor = false;
            btnSuivant.Click += btnSuivant_Click;
            // 
            // frmResultat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(btnSuivant);
            Controls.Add(lblResultat);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmResultat";
            Text = "RESULTAT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtScore;
        private GroupBox groupBox2;
        private TextBox txtBonusRecolter;
        private GroupBox groupBox3;
        private TextBox txtTempsEcouler;
        private Label lblResultat;
        private Button btnSuivant;
    }
}