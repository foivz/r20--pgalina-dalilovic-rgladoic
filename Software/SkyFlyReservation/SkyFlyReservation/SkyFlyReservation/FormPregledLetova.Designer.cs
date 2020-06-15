namespace SkyFlyReservation
{
    partial class FormPregledLetova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledLetova));
            this.popisLetovaLabel = new System.Windows.Forms.Label();
            this.popisLetovaDataGridView = new System.Windows.Forms.DataGridView();
            this.detaljiLetaButton = new System.Windows.Forms.Button();
            this.rezervirajKartuButton = new System.Windows.Forms.Button();
            this.pretrazivanjeLetovaGroupBox = new System.Windows.Forms.GroupBox();
            this.pretraziPremaDatumuCheckBox = new System.Windows.Forms.CheckBox();
            this.pretraziLetoveButton = new System.Windows.Forms.Button();
            this.datumPolaskaLabel = new System.Windows.Forms.Label();
            this.datumPolaskaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odredisniAerodromComboBox = new System.Windows.Forms.ComboBox();
            this.odredisniAerodromLabel = new System.Windows.Forms.Label();
            this.polazisniAerodromComboBox = new System.Windows.Forms.ComboBox();
            this.polazisniAerodromLabel = new System.Windows.Forms.Label();
            this.dodajLetButton = new System.Windows.Forms.Button();
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.pregledRezervacijaButton = new System.Windows.Forms.Button();
            this.obrisiLetButton = new System.Windows.Forms.Button();
            this.azurirajLetButton = new System.Windows.Forms.Button();
            this.prikaziSveButton = new System.Windows.Forms.Button();
            this.buttonAvioniAviokompanije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisLetovaDataGridView)).BeginInit();
            this.pretrazivanjeLetovaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisLetovaLabel
            // 
            this.popisLetovaLabel.AutoSize = true;
            this.popisLetovaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisLetovaLabel.Location = new System.Drawing.Point(23, 25);
            this.popisLetovaLabel.Name = "popisLetovaLabel";
            this.popisLetovaLabel.Size = new System.Drawing.Size(123, 24);
            this.popisLetovaLabel.TabIndex = 0;
            this.popisLetovaLabel.Text = "Popis letova";
            // 
            // popisLetovaDataGridView
            // 
            this.popisLetovaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisLetovaDataGridView.Location = new System.Drawing.Point(27, 61);
            this.popisLetovaDataGridView.Name = "popisLetovaDataGridView";
            this.popisLetovaDataGridView.RowHeadersWidth = 51;
            this.popisLetovaDataGridView.RowTemplate.Height = 24;
            this.popisLetovaDataGridView.Size = new System.Drawing.Size(859, 461);
            this.popisLetovaDataGridView.TabIndex = 1;
            // 
            // detaljiLetaButton
            // 
            this.detaljiLetaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detaljiLetaButton.Location = new System.Drawing.Point(788, 528);
            this.detaljiLetaButton.Name = "detaljiLetaButton";
            this.detaljiLetaButton.Size = new System.Drawing.Size(98, 42);
            this.detaljiLetaButton.TabIndex = 2;
            this.detaljiLetaButton.Text = "Detalji leta";
            this.detaljiLetaButton.UseVisualStyleBackColor = true;
            this.detaljiLetaButton.Click += new System.EventHandler(this.detaljiLetaButton_Click);
            // 
            // rezervirajKartuButton
            // 
            this.rezervirajKartuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervirajKartuButton.Location = new System.Drawing.Point(27, 528);
            this.rezervirajKartuButton.Name = "rezervirajKartuButton";
            this.rezervirajKartuButton.Size = new System.Drawing.Size(98, 42);
            this.rezervirajKartuButton.TabIndex = 4;
            this.rezervirajKartuButton.Text = "Rezerviraj kartu";
            this.rezervirajKartuButton.UseVisualStyleBackColor = true;
            this.rezervirajKartuButton.Click += new System.EventHandler(this.rezervirajKartuButton_Click);
            // 
            // pretrazivanjeLetovaGroupBox
            // 
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.pretraziPremaDatumuCheckBox);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.pretraziLetoveButton);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.datumPolaskaLabel);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.datumPolaskaDateTimePicker);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.odredisniAerodromComboBox);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.odredisniAerodromLabel);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.polazisniAerodromComboBox);
            this.pretrazivanjeLetovaGroupBox.Controls.Add(this.polazisniAerodromLabel);
            this.pretrazivanjeLetovaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretrazivanjeLetovaGroupBox.Location = new System.Drawing.Point(901, 61);
            this.pretrazivanjeLetovaGroupBox.Name = "pretrazivanjeLetovaGroupBox";
            this.pretrazivanjeLetovaGroupBox.Size = new System.Drawing.Size(309, 371);
            this.pretrazivanjeLetovaGroupBox.TabIndex = 5;
            this.pretrazivanjeLetovaGroupBox.TabStop = false;
            this.pretrazivanjeLetovaGroupBox.Text = "Pretraživanje letova :";
            // 
            // pretraziPremaDatumuCheckBox
            // 
            this.pretraziPremaDatumuCheckBox.AutoSize = true;
            this.pretraziPremaDatumuCheckBox.Location = new System.Drawing.Point(10, 237);
            this.pretraziPremaDatumuCheckBox.Name = "pretraziPremaDatumuCheckBox";
            this.pretraziPremaDatumuCheckBox.Size = new System.Drawing.Size(195, 21);
            this.pretraziPremaDatumuCheckBox.TabIndex = 7;
            this.pretraziPremaDatumuCheckBox.Text = "Pretraži prema datumu";
            this.pretraziPremaDatumuCheckBox.UseVisualStyleBackColor = true;
            // 
            // pretraziLetoveButton
            // 
            this.pretraziLetoveButton.Location = new System.Drawing.Point(102, 300);
            this.pretraziLetoveButton.Name = "pretraziLetoveButton";
            this.pretraziLetoveButton.Size = new System.Drawing.Size(103, 42);
            this.pretraziLetoveButton.TabIndex = 6;
            this.pretraziLetoveButton.Text = "Pretraži letove";
            this.pretraziLetoveButton.UseVisualStyleBackColor = true;
            this.pretraziLetoveButton.Click += new System.EventHandler(this.pretraziLetoveButton_Click);
            // 
            // datumPolaskaLabel
            // 
            this.datumPolaskaLabel.AutoSize = true;
            this.datumPolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumPolaskaLabel.Location = new System.Drawing.Point(7, 175);
            this.datumPolaskaLabel.Name = "datumPolaskaLabel";
            this.datumPolaskaLabel.Size = new System.Drawing.Size(110, 17);
            this.datumPolaskaLabel.TabIndex = 5;
            this.datumPolaskaLabel.Text = "Datum polaska :";
            // 
            // datumPolaskaDateTimePicker
            // 
            this.datumPolaskaDateTimePicker.Location = new System.Drawing.Point(10, 197);
            this.datumPolaskaDateTimePicker.Name = "datumPolaskaDateTimePicker";
            this.datumPolaskaDateTimePicker.Size = new System.Drawing.Size(282, 22);
            this.datumPolaskaDateTimePicker.TabIndex = 4;
            // 
            // odredisniAerodromComboBox
            // 
            this.odredisniAerodromComboBox.FormattingEnabled = true;
            this.odredisniAerodromComboBox.Location = new System.Drawing.Point(10, 124);
            this.odredisniAerodromComboBox.Name = "odredisniAerodromComboBox";
            this.odredisniAerodromComboBox.Size = new System.Drawing.Size(282, 24);
            this.odredisniAerodromComboBox.TabIndex = 3;
            // 
            // odredisniAerodromLabel
            // 
            this.odredisniAerodromLabel.AutoSize = true;
            this.odredisniAerodromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odredisniAerodromLabel.Location = new System.Drawing.Point(7, 103);
            this.odredisniAerodromLabel.Name = "odredisniAerodromLabel";
            this.odredisniAerodromLabel.Size = new System.Drawing.Size(142, 17);
            this.odredisniAerodromLabel.TabIndex = 2;
            this.odredisniAerodromLabel.Text = "Odredišni aerodrom :";
            // 
            // polazisniAerodromComboBox
            // 
            this.polazisniAerodromComboBox.FormattingEnabled = true;
            this.polazisniAerodromComboBox.Location = new System.Drawing.Point(10, 52);
            this.polazisniAerodromComboBox.Name = "polazisniAerodromComboBox";
            this.polazisniAerodromComboBox.Size = new System.Drawing.Size(282, 24);
            this.polazisniAerodromComboBox.TabIndex = 1;
            // 
            // polazisniAerodromLabel
            // 
            this.polazisniAerodromLabel.AutoSize = true;
            this.polazisniAerodromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polazisniAerodromLabel.Location = new System.Drawing.Point(7, 31);
            this.polazisniAerodromLabel.Name = "polazisniAerodromLabel";
            this.polazisniAerodromLabel.Size = new System.Drawing.Size(137, 17);
            this.polazisniAerodromLabel.TabIndex = 0;
            this.polazisniAerodromLabel.Text = "Polazišni aerodrom :";
            // 
            // dodajLetButton
            // 
            this.dodajLetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajLetButton.Location = new System.Drawing.Point(561, 13);
            this.dodajLetButton.Name = "dodajLetButton";
            this.dodajLetButton.Size = new System.Drawing.Size(98, 42);
            this.dodajLetButton.TabIndex = 7;
            this.dodajLetButton.Text = "Dodaj let";
            this.dodajLetButton.UseVisualStyleBackColor = true;
            this.dodajLetButton.Click += new System.EventHandler(this.dodajLetButton_Click);
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kupiKartuButton.Location = new System.Drawing.Point(131, 528);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(98, 42);
            this.kupiKartuButton.TabIndex = 8;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // pregledRezervacijaButton
            // 
            this.pregledRezervacijaButton.Location = new System.Drawing.Point(1111, 517);
            this.pregledRezervacijaButton.Name = "pregledRezervacijaButton";
            this.pregledRezervacijaButton.Size = new System.Drawing.Size(90, 51);
            this.pregledRezervacijaButton.TabIndex = 9;
            this.pregledRezervacijaButton.Text = "Pregled rezervacija";
            this.pregledRezervacijaButton.UseVisualStyleBackColor = true;
            this.pregledRezervacijaButton.Click += new System.EventHandler(this.pregledRezervacijaButton_Click);
            // 
            // obrisiLetButton
            // 
            this.obrisiLetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisiLetButton.Location = new System.Drawing.Point(788, 13);
            this.obrisiLetButton.Name = "obrisiLetButton";
            this.obrisiLetButton.Size = new System.Drawing.Size(98, 42);
            this.obrisiLetButton.TabIndex = 10;
            this.obrisiLetButton.Text = "Obriši letove";
            this.obrisiLetButton.UseVisualStyleBackColor = true;
            this.obrisiLetButton.Click += new System.EventHandler(this.obrisiLetButton_Click);
            // 
            // azurirajLetButton
            // 
            this.azurirajLetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azurirajLetButton.Location = new System.Drawing.Point(665, 13);
            this.azurirajLetButton.Name = "azurirajLetButton";
            this.azurirajLetButton.Size = new System.Drawing.Size(117, 42);
            this.azurirajLetButton.TabIndex = 11;
            this.azurirajLetButton.Text = "Ažuriraj letove";
            this.azurirajLetButton.UseVisualStyleBackColor = true;
            this.azurirajLetButton.Click += new System.EventHandler(this.azurirajLetButton_Click);
            // 
            // prikaziSveButton
            // 
            this.prikaziSveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikaziSveButton.Location = new System.Drawing.Point(628, 528);
            this.prikaziSveButton.Name = "prikaziSveButton";
            this.prikaziSveButton.Size = new System.Drawing.Size(154, 42);
            this.prikaziSveButton.TabIndex = 7;
            this.prikaziSveButton.Text = "Prikaži sve letove";
            this.prikaziSveButton.UseVisualStyleBackColor = true;
            this.prikaziSveButton.Click += new System.EventHandler(this.prikaziSveButton_Click);
            // 
            // buttonAvioniAviokompanije
            // 
            this.buttonAvioniAviokompanije.Location = new System.Drawing.Point(954, 517);
            this.buttonAvioniAviokompanije.Name = "buttonAvioniAviokompanije";
            this.buttonAvioniAviokompanije.Size = new System.Drawing.Size(123, 51);
            this.buttonAvioniAviokompanije.TabIndex = 12;
            this.buttonAvioniAviokompanije.Text = "Avioni aviokompanije";
            this.buttonAvioniAviokompanije.UseVisualStyleBackColor = true;
            this.buttonAvioniAviokompanije.Click += new System.EventHandler(this.buttonAvioniAviokompanije_Click);
            // 
            // FormPregledLetova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 602);
            this.Controls.Add(this.buttonAvioniAviokompanije);
            this.Controls.Add(this.prikaziSveButton);
            this.Controls.Add(this.azurirajLetButton);
            this.Controls.Add(this.obrisiLetButton);
            this.Controls.Add(this.pregledRezervacijaButton);
            this.Controls.Add(this.kupiKartuButton);
            this.Controls.Add(this.dodajLetButton);
            this.Controls.Add(this.pretrazivanjeLetovaGroupBox);
            this.Controls.Add(this.rezervirajKartuButton);
            this.Controls.Add(this.detaljiLetaButton);
            this.Controls.Add(this.popisLetovaDataGridView);
            this.Controls.Add(this.popisLetovaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPregledLetova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled letova";
            this.Load += new System.EventHandler(this.FormPregledLetova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPregledLetova_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.popisLetovaDataGridView)).EndInit();
            this.pretrazivanjeLetovaGroupBox.ResumeLayout(false);
            this.pretrazivanjeLetovaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisLetovaLabel;
        private System.Windows.Forms.DataGridView popisLetovaDataGridView;
        private System.Windows.Forms.Button detaljiLetaButton;
        private System.Windows.Forms.Button rezervirajKartuButton;
        private System.Windows.Forms.GroupBox pretrazivanjeLetovaGroupBox;
        private System.Windows.Forms.Button pretraziLetoveButton;
        private System.Windows.Forms.Label datumPolaskaLabel;
        private System.Windows.Forms.DateTimePicker datumPolaskaDateTimePicker;
        private System.Windows.Forms.ComboBox odredisniAerodromComboBox;
        private System.Windows.Forms.Label odredisniAerodromLabel;
        private System.Windows.Forms.ComboBox polazisniAerodromComboBox;
        private System.Windows.Forms.Label polazisniAerodromLabel;
        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.Button dodajLetButton;
        private System.Windows.Forms.Button pregledRezervacijaButton;
        private System.Windows.Forms.Button obrisiLetButton;
        private System.Windows.Forms.Button azurirajLetButton;
        private System.Windows.Forms.Button prikaziSveButton;
        private System.Windows.Forms.Button buttonAvioniAviokompanije;
        private System.Windows.Forms.CheckBox pretraziPremaDatumuCheckBox;
    }
}

