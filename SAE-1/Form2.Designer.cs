namespace SAE_1
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            btnPartie = new Button();
            btnOption = new Button();
            btnQuiter = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.menu;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 731);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            btnPartie.Click += button1_Click;
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
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 731);
            panel1.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(609, 731);
            Controls.Add(btnQuiter);
            Controls.Add(btnOption);
            Controls.Add(btnPartie);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPartie;
        private Button btnOption;
        private Button btnQuiter;
        private Panel panel1;
    }
}