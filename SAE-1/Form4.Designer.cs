namespace SAE_1
{
    partial class Form4
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
            btnSauv2 = new Button();
            btnSauv3 = new Button();
            pbCadreSauv = new PictureBox();
            btnSauv1 = new Button();
            lblAncienneSauv = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCadreSauv).BeginInit();
            SuspendLayout();
            // 
            // btnSauv2
            // 
            btnSauv2.BackColor = Color.LightBlue;
            btnSauv2.Location = new Point(207, 337);
            btnSauv2.Name = "btnSauv2";
            btnSauv2.Size = new Size(202, 50);
            btnSauv2.TabIndex = 3;
            btnSauv2.Text = "Sauvegarde 2";
            btnSauv2.UseVisualStyleBackColor = false;
            // 
            // btnSauv3
            // 
            btnSauv3.BackColor = Color.LightBlue;
            btnSauv3.Location = new Point(207, 485);
            btnSauv3.Name = "btnSauv3";
            btnSauv3.Size = new Size(202, 50);
            btnSauv3.TabIndex = 4;
            btnSauv3.Text = "Sauvgarde 3";
            btnSauv3.UseVisualStyleBackColor = false;
            // 
            // pbCadreSauv
            // 
            pbCadreSauv.Image = Properties.Resources.cadre;
            pbCadreSauv.Location = new Point(89, 48);
            pbCadreSauv.Name = "pbCadreSauv";
            pbCadreSauv.Size = new Size(473, 617);
            pbCadreSauv.TabIndex = 6;
            pbCadreSauv.TabStop = false;
            // 
            // btnSauv1
            // 
            btnSauv1.BackColor = Color.LightBlue;
            btnSauv1.Location = new Point(207, 204);
            btnSauv1.Name = "btnSauv1";
            btnSauv1.Size = new Size(202, 50);
            btnSauv1.TabIndex = 2;
            btnSauv1.Text = "Sauvegarde 1";
            btnSauv1.UseVisualStyleBackColor = false;
            btnSauv1.Click += btnSauv1_Click;
            // 
            // lblAncienneSauv
            // 
            lblAncienneSauv.AutoSize = true;
            lblAncienneSauv.BackColor = Color.Transparent;
            lblAncienneSauv.BorderStyle = BorderStyle.FixedSingle;
            lblAncienneSauv.Font = new Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAncienneSauv.Location = new Point(147, 114);
            lblAncienneSauv.Name = "lblAncienneSauv";
            lblAncienneSauv.Size = new Size(340, 35);
            lblAncienneSauv.TabIndex = 7;
            lblAncienneSauv.Text = "Ancienne Sauvegarde";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(lblAncienneSauv);
            Controls.Add(btnSauv3);
            Controls.Add(btnSauv2);
            Controls.Add(btnSauv1);
            Controls.Add(pbCadreSauv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pbCadreSauv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSauv2;
        private Button btnSauv3;
        private PictureBox pbCadreSauv;
        private Button btnSauv1;
        private Label lblAncienneSauv;
    }
}