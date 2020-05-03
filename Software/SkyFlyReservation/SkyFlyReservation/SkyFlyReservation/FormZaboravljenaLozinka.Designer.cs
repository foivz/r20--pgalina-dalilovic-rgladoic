namespace SkyFlyReservation
{
    partial class FormZaboravljenaLozinka
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
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrirajSeButton = new System.Windows.Forms.Button();
            this.PosaljiLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RegistrirajSeButton
            // 
            this.RegistrirajSeButton.Location = new System.Drawing.Point(53, 119);
            this.RegistrirajSeButton.Name = "RegistrirajSeButton";
            this.RegistrirajSeButton.Size = new System.Drawing.Size(98, 35);
            this.RegistrirajSeButton.TabIndex = 20;
            this.RegistrirajSeButton.Text = "Pošalji";
            this.RegistrirajSeButton.UseVisualStyleBackColor = true;
            // 
            // PosaljiLabel
            // 
            this.PosaljiLabel.AutoSize = true;
            this.PosaljiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosaljiLabel.Location = new System.Drawing.Point(49, 9);
            this.PosaljiLabel.Name = "PosaljiLabel";
            this.PosaljiLabel.Size = new System.Drawing.Size(215, 20);
            this.PosaljiLabel.TabIndex = 19;
            this.PosaljiLabel.Text = "Pošalji privremenu lozinku";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(53, 62);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(211, 20);
            this.EmailTextBox.TabIndex = 18;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 65);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Email:";
            // 
            // FormZaboravljenaLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegistrirajSeButton);
            this.Controls.Add(this.PosaljiLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Name = "FormZaboravljenaLozinka";
            this.Text = "FormZaboravljenaLozinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegistrirajSeButton;
        private System.Windows.Forms.Label PosaljiLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
    }
}