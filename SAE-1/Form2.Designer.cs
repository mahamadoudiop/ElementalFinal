namespace SAE_1
{
    partial class FormMenu
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
            btnPartie = new Button();
            btnOption = new Button();
            btnQuiter = new Button();
            lblMenu = new Label();
            SuspendLayout();
            // 
            // btnPartie
            // 
            btnPartie.BackColor = Color.LightBlue;
            btnPartie.Location = new Point(207, 204);
            btnPartie.Name = "btnPartie";
            btnPartie.Size = new Size(202, 50);
            btnPartie.TabIndex = 1;
            btnPartie.Text = "PARTIE";
            btnPartie.UseVisualStyleBackColor = false;
            btnPartie.Click += btnPartie_Click;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.LightBlue;
            btnOption.Location = new Point(207, 337);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(202, 50);
            btnOption.TabIndex = 2;
            btnOption.Text = "OPTION";
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // btnQuiter
            // 
            btnQuiter.BackColor = Color.LightBlue;
            btnQuiter.Location = new Point(207, 485);
            btnQuiter.Name = "btnQuiter";
            btnQuiter.Size = new Size(202, 50);
            btnQuiter.TabIndex = 3;
            btnQuiter.Text = "QUITER";
            btnQuiter.UseVisualStyleBackColor = false;
            btnQuiter.Click += btnQuiter_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.BorderStyle = BorderStyle.FixedSingle;
            lblMenu.Font = new Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = SystemColors.ControlText;
            lblMenu.Location = new Point(270, 97);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(85, 35);
            lblMenu.TabIndex = 8;
            lblMenu.Text = "MENU";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(lblMenu);
            Controls.Add(btnQuiter);
            Controls.Add(btnOption);
            Controls.Add(btnPartie);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPartie;
        private Button btnOption;
        private Button btnQuiter;
        private Label lblMenu;
    }
}