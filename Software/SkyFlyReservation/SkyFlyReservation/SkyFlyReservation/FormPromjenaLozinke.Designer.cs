namespace SkyFlyReservation
{
    partial class FormPromjenaLozinke
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
            this.label1 = new System.Windows.Forms.Label();
            this.PromjeniButton = new System.Windows.Forms.Button();
            this.PonovljenaLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.PonovljenaLozinkaLabel = new System.Windows.Forms.Label();
            this.LozinkaTextBox = new System.Windows.Forms.TextBox();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NatragButton
            // 
            this.NatragButton.Location = new System.Drawing.Point(227, 159);
            this.NatragButton.Name = "NatragButton";
            this.NatragButton.Size = new System.Drawing.Size(94, 35);
            this.NatragButton.TabIndex = 58;
            this.NatragButton.Text = "Natrag";
            this.NatragButton.UseVisualStyleBackColor = true;
            this.NatragButton.Click += new System.EventHandler(this.NatragButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Promjeni lozinku";
            // 
            // PromjeniButton
            // 
            this.PromjeniButton.Location = new System.Drawing.Point(125, 159);
            this.PromjeniButton.Name = "PromjeniButton";
            this.PromjeniButton.Size = new System.Drawing.Size(94, 35);
            this.PromjeniButton.TabIndex = 56;
            this.PromjeniButton.Text = "Promjeni";
            this.PromjeniButton.UseVisualStyleBackColor = true;
            this.PromjeniButton.Click += new System.EventHandler(this.RegistrirajSeButton_Click);
            // 
            // PonovljenaLozinkaTextBox
            // 
            this.PonovljenaLozinkaTextBox.Location = new System.Drawing.Point(124, 120);
            this.PonovljenaLozinkaTextBox.Name = "PonovljenaLozinkaTextBox";
            this.PonovljenaLozinkaTextBox.Size = new System.Drawing.Size(197, 20);
            this.PonovljenaLozinkaTextBox.TabIndex = 55;
            this.PonovljenaLozinkaTextBox.TextChanged += new System.EventHandler(this.PonovljenaLozinkaTextBox_TextChanged);
            // 
            // PonovljenaLozinkaLabel
            // 
            this.PonovljenaLozinkaLabel.AutoSize = true;
            this.PonovljenaLozinkaLabel.Location = new System.Drawing.Point(23, 123);
            this.PonovljenaLozinkaLabel.Name = "PonovljenaLozinkaLabel";
            this.PonovljenaLozinkaLabel.Size = new System.Drawing.Size(99, 13);
            this.PonovljenaLozinkaLabel.TabIndex = 52;
            this.PonovljenaLozinkaLabel.Text = "Ponovljena lozinka:";
            this.PonovljenaLozinkaLabel.Click += new System.EventHandler(this.PonovljenaLozinkaLabel_Click);
            // 
            // LozinkaTextBox
            // 
            this.LozinkaTextBox.Location = new System.Drawing.Point(124, 94);
            this.LozinkaTextBox.Name = "LozinkaTextBox";
            this.LozinkaTextBox.Size = new System.Drawing.Size(197, 20);
            this.LozinkaTextBox.TabIndex = 54;
            this.LozinkaTextBox.TextChanged += new System.EventHandler(this.LozinkaTextBox_TextChanged);
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(71, 97);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.LozinkaLabel.TabIndex = 53;
            this.LozinkaLabel.Text = "Lozinka:";
            this.LozinkaLabel.Click += new System.EventHandler(this.LozinkaLabel_Click);
            // 
            // FormPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 251);
            this.Controls.Add(this.NatragButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PromjeniButton);
            this.Controls.Add(this.PonovljenaLozinkaTextBox);
            this.Controls.Add(this.PonovljenaLozinkaLabel);
            this.Controls.Add(this.LozinkaTextBox);
            this.Controls.Add(this.LozinkaLabel);
            this.Name = "FormPromjenaLozinke";
            this.Text = "Promjena lozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NatragButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PromjeniButton;
        private System.Windows.Forms.TextBox PonovljenaLozinkaTextBox;
        private System.Windows.Forms.Label PonovljenaLozinkaLabel;
        private System.Windows.Forms.TextBox LozinkaTextBox;
        private System.Windows.Forms.Label LozinkaLabel;
    }
}