namespace SkyFlyReservation
{
    partial class FormPrijava
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
            this.NatragButton = new System.Windows.Forms.Button();
            this.ZaboravljenaLozinkaLabel = new System.Windows.Forms.Label();
            this.PrijavaLabel = new System.Windows.Forms.Label();
            this.PrijaviSeButton = new System.Windows.Forms.Button();
            this.LozinkaTextBox = new System.Windows.Forms.TextBox();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.KorImeTextBox = new System.Windows.Forms.TextBox();
            this.KorImeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NatragButton
            // 
            this.NatragButton.Location = new System.Drawing.Point(428, 235);
            this.NatragButton.Name = "NatragButton";
            this.NatragButton.Size = new System.Drawing.Size(91, 35);
            this.NatragButton.TabIndex = 39;
            this.NatragButton.Text = "Natrag";
            this.NatragButton.UseVisualStyleBackColor = true;
            // 
            // ZaboravljenaLozinkaLabel
            // 
            this.ZaboravljenaLozinkaLabel.AutoSize = true;
            this.ZaboravljenaLozinkaLabel.Location = new System.Drawing.Point(319, 202);
            this.ZaboravljenaLozinkaLabel.Name = "ZaboravljenaLozinkaLabel";
            this.ZaboravljenaLozinkaLabel.Size = new System.Drawing.Size(111, 13);
            this.ZaboravljenaLozinkaLabel.TabIndex = 38;
            this.ZaboravljenaLozinkaLabel.Text = "Zaboravljena lozinka?";
            // 
            // PrijavaLabel
            // 
            this.PrijavaLabel.AutoSize = true;
            this.PrijavaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijavaLabel.Location = new System.Drawing.Point(388, 98);
            this.PrijavaLabel.Name = "PrijavaLabel";
            this.PrijavaLabel.Size = new System.Drawing.Size(62, 20);
            this.PrijavaLabel.TabIndex = 37;
            this.PrijavaLabel.Text = "Prijava";
            // 
            // PrijaviSeButton
            // 
            this.PrijaviSeButton.Location = new System.Drawing.Point(322, 235);
            this.PrijaviSeButton.Name = "PrijaviSeButton";
            this.PrijaviSeButton.Size = new System.Drawing.Size(91, 35);
            this.PrijaviSeButton.TabIndex = 36;
            this.PrijaviSeButton.Text = "Prijavi se";
            this.PrijaviSeButton.UseVisualStyleBackColor = true;
            // 
            // LozinkaTextBox
            // 
            this.LozinkaTextBox.Location = new System.Drawing.Point(322, 165);
            this.LozinkaTextBox.Name = "LozinkaTextBox";
            this.LozinkaTextBox.Size = new System.Drawing.Size(197, 20);
            this.LozinkaTextBox.TabIndex = 35;
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(273, 168);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.LozinkaLabel.TabIndex = 34;
            this.LozinkaLabel.Text = "Lozinka:";
            // 
            // KorImeTextBox
            // 
            this.KorImeTextBox.Location = new System.Drawing.Point(322, 139);
            this.KorImeTextBox.Name = "KorImeTextBox";
            this.KorImeTextBox.Size = new System.Drawing.Size(197, 20);
            this.KorImeTextBox.TabIndex = 33;
            // 
            // KorImeLabel
            // 
            this.KorImeLabel.AutoSize = true;
            this.KorImeLabel.Location = new System.Drawing.Point(238, 142);
            this.KorImeLabel.Name = "KorImeLabel";
            this.KorImeLabel.Size = new System.Drawing.Size(78, 13);
            this.KorImeLabel.TabIndex = 32;
            this.KorImeLabel.Text = "Korisničko ime:";
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NatragButton);
            this.Controls.Add(this.ZaboravljenaLozinkaLabel);
            this.Controls.Add(this.PrijavaLabel);
            this.Controls.Add(this.PrijaviSeButton);
            this.Controls.Add(this.LozinkaTextBox);
            this.Controls.Add(this.LozinkaLabel);
            this.Controls.Add(this.KorImeTextBox);
            this.Controls.Add(this.KorImeLabel);
            this.Name = "FormPrijava";
            this.Text = "FormPrijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NatragButton;
        private System.Windows.Forms.Label ZaboravljenaLozinkaLabel;
        private System.Windows.Forms.Label PrijavaLabel;
        private System.Windows.Forms.Button PrijaviSeButton;
        private System.Windows.Forms.TextBox LozinkaTextBox;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.TextBox KorImeTextBox;
        private System.Windows.Forms.Label KorImeLabel;
    }
}