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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.ZaboravljenaLozinkaLabel = new System.Windows.Forms.Label();
            this.PrijavaLabel = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.KorImeLabel = new System.Windows.Forms.Label();
            this.btnSeePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(411, 267);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(121, 43);
            this.btnNatrag.TabIndex = 47;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // ZaboravljenaLozinkaLabel
            // 
            this.ZaboravljenaLozinkaLabel.AutoSize = true;
            this.ZaboravljenaLozinkaLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZaboravljenaLozinkaLabel.Location = new System.Drawing.Point(265, 227);
            this.ZaboravljenaLozinkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZaboravljenaLozinkaLabel.Name = "ZaboravljenaLozinkaLabel";
            this.ZaboravljenaLozinkaLabel.Size = new System.Drawing.Size(147, 17);
            this.ZaboravljenaLozinkaLabel.TabIndex = 46;
            this.ZaboravljenaLozinkaLabel.Text = "Zaboravljena lozinka?";
            this.ZaboravljenaLozinkaLabel.Click += new System.EventHandler(this.ZaboravljenaLozinkaLabel_Click);
            // 
            // PrijavaLabel
            // 
            this.PrijavaLabel.AutoSize = true;
            this.PrijavaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijavaLabel.Location = new System.Drawing.Point(357, 99);
            this.PrijavaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrijavaLabel.Name = "PrijavaLabel";
            this.PrijavaLabel.Size = new System.Drawing.Size(78, 25);
            this.PrijavaLabel.TabIndex = 45;
            this.PrijavaLabel.Text = "Prijava";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(269, 267);
            this.btnPrijaviSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(121, 43);
            this.btnPrijaviSe.TabIndex = 44;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.PrijaviSeButton_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(269, 181);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(261, 22);
            this.txtLozinka.TabIndex = 43;
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(204, 185);
            this.LozinkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(61, 17);
            this.LozinkaLabel.TabIndex = 42;
            this.LozinkaLabel.Text = "Lozinka:";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(269, 149);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(261, 22);
            this.txtKorIme.TabIndex = 41;
            // 
            // KorImeLabel
            // 
            this.KorImeLabel.AutoSize = true;
            this.KorImeLabel.Location = new System.Drawing.Point(157, 153);
            this.KorImeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KorImeLabel.Name = "KorImeLabel";
            this.KorImeLabel.Size = new System.Drawing.Size(103, 17);
            this.KorImeLabel.TabIndex = 40;
            this.KorImeLabel.Text = "Korisničko ime:";
            // 
            // btnSeePassword
            // 
            this.btnSeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeePassword.Location = new System.Drawing.Point(547, 179);
            this.btnSeePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeePassword.Name = "btnSeePassword";
            this.btnSeePassword.Size = new System.Drawing.Size(40, 27);
            this.btnSeePassword.TabIndex = 48;
            this.btnSeePassword.Text = "👁";
            this.btnSeePassword.UseVisualStyleBackColor = true;
            this.btnSeePassword.Click += new System.EventHandler(this.btnSeePassword_Click);
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 427);
            this.Controls.Add(this.btnSeePassword);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.ZaboravljenaLozinkaLabel);
            this.Controls.Add(this.PrijavaLabel);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.LozinkaLabel);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.KorImeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrijava_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label ZaboravljenaLozinkaLabel;
        private System.Windows.Forms.Label PrijavaLabel;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label KorImeLabel;
        private System.Windows.Forms.Button btnSeePassword;
    }
}