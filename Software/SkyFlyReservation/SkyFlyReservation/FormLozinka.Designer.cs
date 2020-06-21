namespace SkyFlyReservation
{
    partial class FormLozinka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLozinka));
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPonovljenaLozinka = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnRegistrirajSe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeePassword2 = new System.Windows.Forms.Button();
            this.btnSeePassword1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(144, 87);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(261, 22);
            this.txtLozinka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ponovljena lozinka:";
            // 
            // txtPonovljenaLozinka
            // 
            this.txtPonovljenaLozinka.Location = new System.Drawing.Point(144, 125);
            this.txtPonovljenaLozinka.Name = "txtPonovljenaLozinka";
            this.txtPonovljenaLozinka.Size = new System.Drawing.Size(261, 22);
            this.txtPonovljenaLozinka.TabIndex = 2;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(280, 166);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(125, 43);
            this.btnNatrag.TabIndex = 10;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnRegistrirajSe
            // 
            this.btnRegistrirajSe.Location = new System.Drawing.Point(144, 166);
            this.btnRegistrirajSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrirajSe.Name = "btnRegistrirajSe";
            this.btnRegistrirajSe.Size = new System.Drawing.Size(125, 43);
            this.btnRegistrirajSe.TabIndex = 9;
            this.btnRegistrirajSe.Text = "Postavi";
            this.btnRegistrirajSe.UseVisualStyleBackColor = true;
            this.btnRegistrirajSe.Click += new System.EventHandler(this.btnRegistrirajSe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Postavi novu lozinku";
            // 
            // btnSeePassword2
            // 
            this.btnSeePassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeePassword2.Location = new System.Drawing.Point(412, 123);
            this.btnSeePassword2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeePassword2.Name = "btnSeePassword2";
            this.btnSeePassword2.Size = new System.Drawing.Size(40, 27);
            this.btnSeePassword2.TabIndex = 95;
            this.btnSeePassword2.Text = "👁";
            this.btnSeePassword2.UseVisualStyleBackColor = true;
            this.btnSeePassword2.Click += new System.EventHandler(this.btnSeePassword2_Click);
            // 
            // btnSeePassword1
            // 
            this.btnSeePassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeePassword1.Location = new System.Drawing.Point(412, 85);
            this.btnSeePassword1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeePassword1.Name = "btnSeePassword1";
            this.btnSeePassword1.Size = new System.Drawing.Size(40, 27);
            this.btnSeePassword1.TabIndex = 94;
            this.btnSeePassword1.Text = "👁";
            this.btnSeePassword1.UseVisualStyleBackColor = true;
            this.btnSeePassword1.Click += new System.EventHandler(this.btnSeePassword1_Click);
            // 
            // FormLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 255);
            this.Controls.Add(this.btnSeePassword2);
            this.Controls.Add(this.btnSeePassword1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnRegistrirajSe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPonovljenaLozinka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLozinka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLozinka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLozinka";
            this.Load += new System.EventHandler(this.FormLozinka_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLozinka_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPonovljenaLozinka;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnRegistrirajSe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeePassword2;
        private System.Windows.Forms.Button btnSeePassword1;
    }
}