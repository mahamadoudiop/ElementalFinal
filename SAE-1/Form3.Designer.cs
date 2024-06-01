namespace SAE_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnSauvegarde = new Button();
            btnJouer = new Button();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // btnSauvegarde
            // 
            btnSauvegarde.BackColor = Color.LightBlue;
            btnSauvegarde.Location = new Point(207, 97);
            btnSauvegarde.Name = "btnSauvegarde";
            btnSauvegarde.Size = new Size(202, 50);
            btnSauvegarde.TabIndex = 0;
            btnSauvegarde.Text = "SAUVEGARDE";
            btnSauvegarde.UseVisualStyleBackColor = false;
            btnSauvegarde.Click += button1_Click;
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.LightBlue;
            btnJouer.Location = new Point(207, 225);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(202, 50);
            btnJouer.TabIndex = 1;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
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
            btnRetour.TabIndex = 2;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 396);
            Controls.Add(btnRetour);
            Controls.Add(btnJouer);
            Controls.Add(btnSauvegarde);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSauvegarde;
        private Button btnJouer;
        private Button btnRetour;
    }
}