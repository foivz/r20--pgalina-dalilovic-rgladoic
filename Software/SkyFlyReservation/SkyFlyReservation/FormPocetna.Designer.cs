namespace SkyFlyReservation
{
    partial class FormPocetna
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.dgvNajpopularnijiLetovi = new System.Windows.Forms.DataGridView();
            this.btnPregledRezervacija = new System.Windows.Forms.Button();
            this.btnPregledLetova = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnPregledAviona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajpopularnijiLetovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Najpopularniji letovi:";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezerviraj.Location = new System.Drawing.Point(860, 433);
            this.btnRezerviraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(144, 42);
            this.btnRezerviraj.TabIndex = 59;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKupi.Location = new System.Drawing.Point(1012, 433);
            this.btnKupi.Margin = new System.Windows.Forms.Padding(4);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(144, 42);
            this.btnKupi.TabIndex = 58;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // dgvNajpopularnijiLetovi
            // 
            this.dgvNajpopularnijiLetovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNajpopularnijiLetovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajpopularnijiLetovi.Location = new System.Drawing.Point(17, 119);
            this.dgvNajpopularnijiLetovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNajpopularnijiLetovi.Name = "dgvNajpopularnijiLetovi";
            this.dgvNajpopularnijiLetovi.RowHeadersWidth = 51;
            this.dgvNajpopularnijiLetovi.Size = new System.Drawing.Size(1139, 306);
            this.dgvNajpopularnijiLetovi.TabIndex = 57;
            // 
            // btnPregledRezervacija
            // 
            this.btnPregledRezervacija.Location = new System.Drawing.Point(169, 16);
            this.btnPregledRezervacija.Margin = new System.Windows.Forms.Padding(4);
            this.btnPregledRezervacija.Name = "btnPregledRezervacija";
            this.btnPregledRezervacija.Size = new System.Drawing.Size(144, 42);
            this.btnPregledRezervacija.TabIndex = 56;
            this.btnPregledRezervacija.Text = "Pregled rezervacija";
            this.btnPregledRezervacija.UseVisualStyleBackColor = true;
            this.btnPregledRezervacija.Click += new System.EventHandler(this.btnPregledRezervacija_Click);
            // 
            // btnPregledLetova
            // 
            this.btnPregledLetova.Location = new System.Drawing.Point(17, 16);
            this.btnPregledLetova.Margin = new System.Windows.Forms.Padding(4);
            this.btnPregledLetova.Name = "btnPregledLetova";
            this.btnPregledLetova.Size = new System.Drawing.Size(144, 42);
            this.btnPregledLetova.TabIndex = 55;
            this.btnPregledLetova.Text = "Pregled letova";
            this.btnPregledLetova.UseVisualStyleBackColor = true;
            this.btnPregledLetova.Click += new System.EventHandler(this.btnPregledLetova_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistracija.Location = new System.Drawing.Point(860, 16);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(144, 42);
            this.btnRegistracija.TabIndex = 54;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrijava.Location = new System.Drawing.Point(1012, 16);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(144, 42);
            this.btnPrijava.TabIndex = 53;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // picMenu
            // 
            this.picMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMenu.Location = new System.Drawing.Point(1, 1);
            this.picMenu.Margin = new System.Windows.Forms.Padding(4);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(1169, 74);
            this.picMenu.TabIndex = 61;
            this.picMenu.TabStop = false;
            // 
            // btnPregledAviona
            // 
            this.btnPregledAviona.Location = new System.Drawing.Point(321, 16);
            this.btnPregledAviona.Margin = new System.Windows.Forms.Padding(4);
            this.btnPregledAviona.Name = "btnPregledAviona";
            this.btnPregledAviona.Size = new System.Drawing.Size(144, 42);
            this.btnPregledAviona.TabIndex = 62;
            this.btnPregledAviona.Text = "Pregled aviona";
            this.btnPregledAviona.UseVisualStyleBackColor = true;
            this.btnPregledAviona.Click += new System.EventHandler(this.btnPregledAviona_Click);
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 491);
            this.Controls.Add(this.btnPregledAviona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.dgvNajpopularnijiLetovi);
            this.Controls.Add(this.btnPregledRezervacija);
            this.Controls.Add(this.btnPregledLetova);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.picMenu);
            this.Name = "FormPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyFlyReservation";
            this.Load += new System.EventHandler(this.FormPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajpopularnijiLetovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.DataGridView dgvNajpopularnijiLetovi;
        private System.Windows.Forms.Button btnPregledRezervacija;
        private System.Windows.Forms.Button btnPregledLetova;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnPregledAviona;
    }
}