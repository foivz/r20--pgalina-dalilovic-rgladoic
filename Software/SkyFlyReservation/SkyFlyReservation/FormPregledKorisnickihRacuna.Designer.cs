namespace SkyFlyReservation
{
    partial class FormPregledKorisnickihRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledKorisnickihRacuna));
            this.dgvKorisnickiRacuni = new System.Windows.Forms.DataGridView();
            this.filtrirajPopisKorisnickihRacunaGroupBox = new System.Windows.Forms.GroupBox();
            this.filtrirajPopisRacunaButton = new System.Windows.Forms.Button();
            this.registriraniRadio = new System.Windows.Forms.RadioButton();
            this.prikazSvihRadio = new System.Windows.Forms.RadioButton();
            this.moderatorRadio = new System.Windows.Forms.RadioButton();
            this.dodijeliUloguModeratoraButton = new System.Windows.Forms.Button();
            this.popisKorisnickihRacunaLabel = new System.Windows.Forms.Label();
            this.dodijeliUloguRegistriranogKorisnikaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnickiRacuni)).BeginInit();
            this.filtrirajPopisKorisnickihRacunaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKorisnickiRacuni
            // 
            this.dgvKorisnickiRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnickiRacuni.Location = new System.Drawing.Point(12, 45);
            this.dgvKorisnickiRacuni.Name = "dgvKorisnickiRacuni";
            this.dgvKorisnickiRacuni.Size = new System.Drawing.Size(841, 315);
            this.dgvKorisnickiRacuni.TabIndex = 0;
            // 
            // filtrirajPopisKorisnickihRacunaGroupBox
            // 
            this.filtrirajPopisKorisnickihRacunaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrirajPopisKorisnickihRacunaGroupBox.Controls.Add(this.filtrirajPopisRacunaButton);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Controls.Add(this.registriraniRadio);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Controls.Add(this.prikazSvihRadio);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Controls.Add(this.moderatorRadio);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrirajPopisKorisnickihRacunaGroupBox.Location = new System.Drawing.Point(917, 45);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Name = "filtrirajPopisKorisnickihRacunaGroupBox";
            this.filtrirajPopisKorisnickihRacunaGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.filtrirajPopisKorisnickihRacunaGroupBox.Size = new System.Drawing.Size(207, 203);
            this.filtrirajPopisKorisnickihRacunaGroupBox.TabIndex = 5;
            this.filtrirajPopisKorisnickihRacunaGroupBox.TabStop = false;
            this.filtrirajPopisKorisnickihRacunaGroupBox.Text = "Filtiriraj popis korisničkih računa :";
            // 
            // filtrirajPopisRacunaButton
            // 
            this.filtrirajPopisRacunaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrirajPopisRacunaButton.Location = new System.Drawing.Point(55, 147);
            this.filtrirajPopisRacunaButton.Name = "filtrirajPopisRacunaButton";
            this.filtrirajPopisRacunaButton.Size = new System.Drawing.Size(75, 23);
            this.filtrirajPopisRacunaButton.TabIndex = 7;
            this.filtrirajPopisRacunaButton.Text = "Filtriraj";
            this.filtrirajPopisRacunaButton.UseVisualStyleBackColor = true;
            this.filtrirajPopisRacunaButton.Click += new System.EventHandler(this.filtrirajPopisRacunaButton_Click);
            // 
            // registriraniRadio
            // 
            this.registriraniRadio.AutoSize = true;
            this.registriraniRadio.Location = new System.Drawing.Point(4, 94);
            this.registriraniRadio.Margin = new System.Windows.Forms.Padding(2);
            this.registriraniRadio.Name = "registriraniRadio";
            this.registriraniRadio.Size = new System.Drawing.Size(116, 17);
            this.registriraniRadio.TabIndex = 6;
            this.registriraniRadio.TabStop = true;
            this.registriraniRadio.Text = "Registrirani korisnik";
            this.registriraniRadio.UseVisualStyleBackColor = true;
            // 
            // prikazSvihRadio
            // 
            this.prikazSvihRadio.AutoSize = true;
            this.prikazSvihRadio.Location = new System.Drawing.Point(4, 32);
            this.prikazSvihRadio.Margin = new System.Windows.Forms.Padding(2);
            this.prikazSvihRadio.Name = "prikazSvihRadio";
            this.prikazSvihRadio.Size = new System.Drawing.Size(76, 17);
            this.prikazSvihRadio.TabIndex = 6;
            this.prikazSvihRadio.TabStop = true;
            this.prikazSvihRadio.Text = "Prikaži sve";
            this.prikazSvihRadio.UseVisualStyleBackColor = true;
            // 
            // moderatorRadio
            // 
            this.moderatorRadio.AutoSize = true;
            this.moderatorRadio.Location = new System.Drawing.Point(4, 64);
            this.moderatorRadio.Margin = new System.Windows.Forms.Padding(2);
            this.moderatorRadio.Name = "moderatorRadio";
            this.moderatorRadio.Size = new System.Drawing.Size(73, 17);
            this.moderatorRadio.TabIndex = 2;
            this.moderatorRadio.TabStop = true;
            this.moderatorRadio.Text = "Moderator";
            this.moderatorRadio.UseVisualStyleBackColor = true;
            // 
            // dodijeliUloguModeratoraButton
            // 
            this.dodijeliUloguModeratoraButton.Location = new System.Drawing.Point(12, 385);
            this.dodijeliUloguModeratoraButton.Name = "dodijeliUloguModeratoraButton";
            this.dodijeliUloguModeratoraButton.Size = new System.Drawing.Size(183, 29);
            this.dodijeliUloguModeratoraButton.TabIndex = 6;
            this.dodijeliUloguModeratoraButton.Text = "Dodijeli ulogu moderatora";
            this.dodijeliUloguModeratoraButton.UseVisualStyleBackColor = true;
            this.dodijeliUloguModeratoraButton.Click += new System.EventHandler(this.dodijeliUloguModeratoraButton_Click);
            // 
            // popisKorisnickihRacunaLabel
            // 
            this.popisKorisnickihRacunaLabel.AutoSize = true;
            this.popisKorisnickihRacunaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisKorisnickihRacunaLabel.Location = new System.Drawing.Point(9, 13);
            this.popisKorisnickihRacunaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisKorisnickihRacunaLabel.Name = "popisKorisnickihRacunaLabel";
            this.popisKorisnickihRacunaLabel.Size = new System.Drawing.Size(194, 18);
            this.popisKorisnickihRacunaLabel.TabIndex = 7;
            this.popisKorisnickihRacunaLabel.Text = "Popis korisničkih računa";
            // 
            // dodijeliUloguRegistriranogKorisnikaButton
            // 
            this.dodijeliUloguRegistriranogKorisnikaButton.Location = new System.Drawing.Point(670, 385);
            this.dodijeliUloguRegistriranogKorisnikaButton.Name = "dodijeliUloguRegistriranogKorisnikaButton";
            this.dodijeliUloguRegistriranogKorisnikaButton.Size = new System.Drawing.Size(183, 29);
            this.dodijeliUloguRegistriranogKorisnikaButton.TabIndex = 8;
            this.dodijeliUloguRegistriranogKorisnikaButton.Text = "Dodijeli ulogu registriranog korisnika";
            this.dodijeliUloguRegistriranogKorisnikaButton.UseVisualStyleBackColor = true;
            this.dodijeliUloguRegistriranogKorisnikaButton.Click += new System.EventHandler(this.dodijeliUloguRegistriranogKorisnikaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pretraži korisnika prema imenu ili prezimenu";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(963, 321);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazi.TabIndex = 10;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormPregledKorisnickihRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodijeliUloguRegistriranogKorisnikaButton);
            this.Controls.Add(this.popisKorisnickihRacunaLabel);
            this.Controls.Add(this.dodijeliUloguModeratoraButton);
            this.Controls.Add(this.filtrirajPopisKorisnickihRacunaGroupBox);
            this.Controls.Add(this.dgvKorisnickiRacuni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPregledKorisnickihRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled korisničkih računa";
            this.Load += new System.EventHandler(this.FormPregledKorisnickihRacuna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPregledKorisnickihRacuna_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnickiRacuni)).EndInit();
            this.filtrirajPopisKorisnickihRacunaGroupBox.ResumeLayout(false);
            this.filtrirajPopisKorisnickihRacunaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnickiRacuni;
        private System.Windows.Forms.GroupBox filtrirajPopisKorisnickihRacunaGroupBox;
        private System.Windows.Forms.RadioButton prikazSvihRadio;
        private System.Windows.Forms.RadioButton moderatorRadio;
        private System.Windows.Forms.RadioButton registriraniRadio;
        private System.Windows.Forms.Button dodijeliUloguModeratoraButton;
        private System.Windows.Forms.Label popisKorisnickihRacunaLabel;
        private System.Windows.Forms.Button filtrirajPopisRacunaButton;
        private System.Windows.Forms.Button dodijeliUloguRegistriranogKorisnikaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretrazi;
    }
}