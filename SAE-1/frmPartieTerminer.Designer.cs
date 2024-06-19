namespace SAE_1
{
    partial class frmPartieTerminer
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
            grpPartieTerminer = new GroupBox();
            btnRejouer = new Button();
            btnMenuPrincipal = new Button();
            grpPartieTerminer.SuspendLayout();
            SuspendLayout();
            // 
            // grpPartieTerminer
            // 
            grpPartieTerminer.Controls.Add(btnRejouer);
            grpPartieTerminer.Controls.Add(btnMenuPrincipal);
            grpPartieTerminer.Location = new Point(47, 51);
            grpPartieTerminer.Name = "grpPartieTerminer";
            grpPartieTerminer.Size = new Size(502, 288);
            grpPartieTerminer.TabIndex = 2;
            grpPartieTerminer.TabStop = false;
            grpPartieTerminer.Text = "FIN DE PARTIE";
            // 
            // btnRejouer
            // 
            btnRejouer.BackColor = Color.LightBlue;
            btnRejouer.Location = new Point(156, 161);
            btnRejouer.Name = "btnRejouer";
            btnRejouer.Size = new Size(202, 50);
            btnRejouer.TabIndex = 4;
            btnRejouer.Text = "REJOUER";
            btnRejouer.UseVisualStyleBackColor = false;
            btnRejouer.Click += btnRejouer_Click;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = Color.LightBlue;
            btnMenuPrincipal.Location = new Point(156, 64);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(202, 50);
            btnMenuPrincipal.TabIndex = 3;
            btnMenuPrincipal.Text = "MENU PRINCIPAL";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // frmPartieTerminer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 396);
            Controls.Add(grpPartieTerminer);
            Name = "frmPartieTerminer";
            Text = "PARIE TERMINER";
            Load += frmPartieTerminer_Load;
            grpPartieTerminer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPartieTerminer;
        private Button btnRejouer;
        private Button btnMenuPrincipal;
    }
}