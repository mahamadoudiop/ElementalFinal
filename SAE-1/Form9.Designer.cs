namespace SAE_1
{
    partial class FormPause
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
            lblMenu = new Label();
            btnAbandonner = new Button();
            btnSauvegardePartie = new Button();
            btnReprendre = new Button();
            btnOptions = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.BorderStyle = BorderStyle.FixedSingle;
            lblMenu.Font = new Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(122, 39);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(102, 35);
            lblMenu.TabIndex = 12;
            lblMenu.Text = "PAUSE";
            lblMenu.Click += lblMenu_Click;
            // 
            // btnAbandonner
            // 
            btnAbandonner.BackColor = Color.LightBlue;
            btnAbandonner.Location = new Point(69, 448);
            btnAbandonner.Name = "btnAbandonner";
            btnAbandonner.Size = new Size(202, 50);
            btnAbandonner.TabIndex = 11;
            btnAbandonner.Text = "Abandonner";
            btnAbandonner.UseVisualStyleBackColor = false;
            // 
            // btnSauvegardePartie
            // 
            btnSauvegardePartie.BackColor = Color.LightBlue;
            btnSauvegardePartie.Location = new Point(69, 328);
            btnSauvegardePartie.Name = "btnSauvegardePartie";
            btnSauvegardePartie.Size = new Size(202, 50);
            btnSauvegardePartie.TabIndex = 10;
            btnSauvegardePartie.Text = "Sauvegarder la Partie";
            btnSauvegardePartie.UseVisualStyleBackColor = false;
            // 
            // btnReprendre
            // 
            btnReprendre.BackColor = Color.LightBlue;
            btnReprendre.Location = new Point(69, 110);
            btnReprendre.Name = "btnReprendre";
            btnReprendre.Size = new Size(202, 50);
            btnReprendre.TabIndex = 9;
            btnReprendre.Text = "Reprendre";
            btnReprendre.UseVisualStyleBackColor = false;
            btnReprendre.Click += btnReprendre_Click;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.LightBlue;
            btnOptions.Location = new Point(69, 216);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(202, 50);
            btnOptions.TabIndex = 13;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // FormPause
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(332, 539);
            Controls.Add(btnOptions);
            Controls.Add(lblMenu);
            Controls.Add(btnAbandonner);
            Controls.Add(btnSauvegardePartie);
            Controls.Add(btnReprendre);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormPause";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pause";
            Load += FormPause_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnAbandonner;
        private Button btnSauvegardePartie;
        private Button btnReprendre;
        private Button btnOptions;
    }
}