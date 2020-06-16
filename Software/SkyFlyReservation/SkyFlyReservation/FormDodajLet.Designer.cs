namespace SkyFlyReservation
{
    partial class FormDodajLet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajLet));
            this.dodajLetLabel = new System.Windows.Forms.Label();
            this.polazisniAerodromLabel = new System.Windows.Forms.Label();
            this.noviLetGroupBox = new System.Windows.Forms.GroupBox();
            this.aviokompanijeComboBox = new System.Windows.Forms.ComboBox();
            this.aviokompanijaLabel = new System.Windows.Forms.Label();
            this.valutaTextBox = new System.Windows.Forms.TextBox();
            this.dodajLetButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.cijenaKarteTextBox = new System.Windows.Forms.TextBox();
            this.cijenaKarteLabel = new System.Windows.Forms.Label();
            this.avionNaLetuComboBox = new System.Windows.Forms.ComboBox();
            this.avionNaLetuLabel = new System.Windows.Forms.Label();
            this.datumVrijemeDolaskaLabel = new System.Windows.Forms.Label();
            this.datumVrijemeDolaskaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumVrijemePolaskaLabel = new System.Windows.Forms.Label();
            this.datumVrijemePolaskaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odredisniAerodromComboBox = new System.Windows.Forms.ComboBox();
            this.odredisniAerodromLabel = new System.Windows.Forms.Label();
            this.polazisniAerodromComboBox = new System.Windows.Forms.ComboBox();
            this.noviLetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodajLetLabel
            // 
            this.dodajLetLabel.AutoSize = true;
            this.dodajLetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajLetLabel.Location = new System.Drawing.Point(32, 30);
            this.dodajLetLabel.Name = "dodajLetLabel";
            this.dodajLetLabel.Size = new System.Drawing.Size(137, 24);
            this.dodajLetLabel.TabIndex = 20;
            this.dodajLetLabel.Text = "Dodaj novi let";
            // 
            // polazisniAerodromLabel
            // 
            this.polazisniAerodromLabel.AutoSize = true;
            this.polazisniAerodromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polazisniAerodromLabel.Location = new System.Drawing.Point(63, 34);
            this.polazisniAerodromLabel.Name = "polazisniAerodromLabel";
            this.polazisniAerodromLabel.Size = new System.Drawing.Size(137, 17);
            this.polazisniAerodromLabel.TabIndex = 22;
            this.polazisniAerodromLabel.Text = "Polazišni aerodrom :";
            // 
            // noviLetGroupBox
            // 
            this.noviLetGroupBox.Controls.Add(this.aviokompanijeComboBox);
            this.noviLetGroupBox.Controls.Add(this.aviokompanijaLabel);
            this.noviLetGroupBox.Controls.Add(this.valutaTextBox);
            this.noviLetGroupBox.Controls.Add(this.dodajLetButton);
            this.noviLetGroupBox.Controls.Add(this.odustaniButton);
            this.noviLetGroupBox.Controls.Add(this.cijenaKarteTextBox);
            this.noviLetGroupBox.Controls.Add(this.cijenaKarteLabel);
            this.noviLetGroupBox.Controls.Add(this.avionNaLetuComboBox);
            this.noviLetGroupBox.Controls.Add(this.avionNaLetuLabel);
            this.noviLetGroupBox.Controls.Add(this.datumVrijemeDolaskaLabel);
            this.noviLetGroupBox.Controls.Add(this.datumVrijemeDolaskaDateTimePicker);
            this.noviLetGroupBox.Controls.Add(this.datumVrijemePolaskaLabel);
            this.noviLetGroupBox.Controls.Add(this.datumVrijemePolaskaDateTimePicker);
            this.noviLetGroupBox.Controls.Add(this.odredisniAerodromComboBox);
            this.noviLetGroupBox.Controls.Add(this.odredisniAerodromLabel);
            this.noviLetGroupBox.Controls.Add(this.polazisniAerodromComboBox);
            this.noviLetGroupBox.Controls.Add(this.polazisniAerodromLabel);
            this.noviLetGroupBox.Location = new System.Drawing.Point(36, 68);
            this.noviLetGroupBox.Name = "noviLetGroupBox";
            this.noviLetGroupBox.Size = new System.Drawing.Size(366, 540);
            this.noviLetGroupBox.TabIndex = 23;
            this.noviLetGroupBox.TabStop = false;
            this.noviLetGroupBox.Text = "Novi let :";
            // 
            // aviokompanijeComboBox
            // 
            this.aviokompanijeComboBox.FormattingEnabled = true;
            this.aviokompanijeComboBox.Location = new System.Drawing.Point(66, 306);
            this.aviokompanijeComboBox.Name = "aviokompanijeComboBox";
            this.aviokompanijeComboBox.Size = new System.Drawing.Size(249, 24);
            this.aviokompanijeComboBox.TabIndex = 38;
            this.aviokompanijeComboBox.SelectedIndexChanged += new System.EventHandler(this.aviokompanijeComboBox_SelectedIndexChanged);
            // 
            // aviokompanijaLabel
            // 
            this.aviokompanijaLabel.AutoSize = true;
            this.aviokompanijaLabel.Location = new System.Drawing.Point(63, 284);
            this.aviokompanijaLabel.Name = "aviokompanijaLabel";
            this.aviokompanijaLabel.Size = new System.Drawing.Size(107, 17);
            this.aviokompanijaLabel.TabIndex = 37;
            this.aviokompanijaLabel.Text = "Aviokompanija :";
            // 
            // valutaTextBox
            // 
            this.valutaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valutaTextBox.Location = new System.Drawing.Point(190, 432);
            this.valutaTextBox.Name = "valutaTextBox";
            this.valutaTextBox.ReadOnly = true;
            this.valutaTextBox.Size = new System.Drawing.Size(56, 22);
            this.valutaTextBox.TabIndex = 36;
            this.valutaTextBox.Text = "HRK";
            // 
            // dodajLetButton
            // 
            this.dodajLetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajLetButton.Location = new System.Drawing.Point(66, 486);
            this.dodajLetButton.Name = "dodajLetButton";
            this.dodajLetButton.Size = new System.Drawing.Size(103, 37);
            this.dodajLetButton.TabIndex = 35;
            this.dodajLetButton.Text = "Dodaj let";
            this.dodajLetButton.UseVisualStyleBackColor = true;
            this.dodajLetButton.Click += new System.EventHandler(this.dodajLetButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustaniButton.Location = new System.Drawing.Point(213, 486);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(102, 37);
            this.odustaniButton.TabIndex = 34;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // cijenaKarteTextBox
            // 
            this.cijenaKarteTextBox.Location = new System.Drawing.Point(66, 432);
            this.cijenaKarteTextBox.Name = "cijenaKarteTextBox";
            this.cijenaKarteTextBox.Size = new System.Drawing.Size(118, 22);
            this.cijenaKarteTextBox.TabIndex = 33;
            // 
            // cijenaKarteLabel
            // 
            this.cijenaKarteLabel.AutoSize = true;
            this.cijenaKarteLabel.Location = new System.Drawing.Point(63, 411);
            this.cijenaKarteLabel.Name = "cijenaKarteLabel";
            this.cijenaKarteLabel.Size = new System.Drawing.Size(91, 17);
            this.cijenaKarteLabel.TabIndex = 32;
            this.cijenaKarteLabel.Text = "Cijena karte :";
            // 
            // avionNaLetuComboBox
            // 
            this.avionNaLetuComboBox.FormattingEnabled = true;
            this.avionNaLetuComboBox.Location = new System.Drawing.Point(66, 367);
            this.avionNaLetuComboBox.Name = "avionNaLetuComboBox";
            this.avionNaLetuComboBox.Size = new System.Drawing.Size(249, 24);
            this.avionNaLetuComboBox.TabIndex = 31;
            // 
            // avionNaLetuLabel
            // 
            this.avionNaLetuLabel.AutoSize = true;
            this.avionNaLetuLabel.Location = new System.Drawing.Point(63, 346);
            this.avionNaLetuLabel.Name = "avionNaLetuLabel";
            this.avionNaLetuLabel.Size = new System.Drawing.Size(51, 17);
            this.avionNaLetuLabel.TabIndex = 30;
            this.avionNaLetuLabel.Text = "Avion :";
            // 
            // datumVrijemeDolaskaLabel
            // 
            this.datumVrijemeDolaskaLabel.AutoSize = true;
            this.datumVrijemeDolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumVrijemeDolaskaLabel.Location = new System.Drawing.Point(63, 226);
            this.datumVrijemeDolaskaLabel.Name = "datumVrijemeDolaskaLabel";
            this.datumVrijemeDolaskaLabel.Size = new System.Drawing.Size(166, 17);
            this.datumVrijemeDolaskaLabel.TabIndex = 29;
            this.datumVrijemeDolaskaLabel.Text = "Datum i vrijeme dolaska :";
            // 
            // datumVrijemeDolaskaDateTimePicker
            // 
            this.datumVrijemeDolaskaDateTimePicker.CustomFormat = "dd. MMMM yyyy., HH:mm:ss";
            this.datumVrijemeDolaskaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumVrijemeDolaskaDateTimePicker.Location = new System.Drawing.Point(66, 246);
            this.datumVrijemeDolaskaDateTimePicker.Name = "datumVrijemeDolaskaDateTimePicker";
            this.datumVrijemeDolaskaDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.datumVrijemeDolaskaDateTimePicker.TabIndex = 28;
            // 
            // datumVrijemePolaskaLabel
            // 
            this.datumVrijemePolaskaLabel.AutoSize = true;
            this.datumVrijemePolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumVrijemePolaskaLabel.Location = new System.Drawing.Point(63, 161);
            this.datumVrijemePolaskaLabel.Name = "datumVrijemePolaskaLabel";
            this.datumVrijemePolaskaLabel.Size = new System.Drawing.Size(166, 17);
            this.datumVrijemePolaskaLabel.TabIndex = 27;
            this.datumVrijemePolaskaLabel.Text = "Datum i vrijeme polaska :";
            // 
            // datumVrijemePolaskaDateTimePicker
            // 
            this.datumVrijemePolaskaDateTimePicker.CustomFormat = "dd. MMMM yyyy., HH:mm:ss";
            this.datumVrijemePolaskaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumVrijemePolaskaDateTimePicker.Location = new System.Drawing.Point(66, 181);
            this.datumVrijemePolaskaDateTimePicker.Name = "datumVrijemePolaskaDateTimePicker";
            this.datumVrijemePolaskaDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.datumVrijemePolaskaDateTimePicker.TabIndex = 26;
            // 
            // odredisniAerodromComboBox
            // 
            this.odredisniAerodromComboBox.FormattingEnabled = true;
            this.odredisniAerodromComboBox.Location = new System.Drawing.Point(66, 114);
            this.odredisniAerodromComboBox.Name = "odredisniAerodromComboBox";
            this.odredisniAerodromComboBox.Size = new System.Drawing.Size(249, 24);
            this.odredisniAerodromComboBox.TabIndex = 25;
            // 
            // odredisniAerodromLabel
            // 
            this.odredisniAerodromLabel.AutoSize = true;
            this.odredisniAerodromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odredisniAerodromLabel.Location = new System.Drawing.Point(63, 94);
            this.odredisniAerodromLabel.Name = "odredisniAerodromLabel";
            this.odredisniAerodromLabel.Size = new System.Drawing.Size(142, 17);
            this.odredisniAerodromLabel.TabIndex = 24;
            this.odredisniAerodromLabel.Text = "Odredišni aerodrom :";
            // 
            // polazisniAerodromComboBox
            // 
            this.polazisniAerodromComboBox.FormattingEnabled = true;
            this.polazisniAerodromComboBox.Location = new System.Drawing.Point(66, 54);
            this.polazisniAerodromComboBox.Name = "polazisniAerodromComboBox";
            this.polazisniAerodromComboBox.Size = new System.Drawing.Size(249, 24);
            this.polazisniAerodromComboBox.TabIndex = 23;
            // 
            // FormDodajLet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 645);
            this.Controls.Add(this.noviLetGroupBox);
            this.Controls.Add(this.dodajLetLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormDodajLet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj let";
            this.Load += new System.EventHandler(this.FormDodajLet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDodajLet_KeyDown);
            this.noviLetGroupBox.ResumeLayout(false);
            this.noviLetGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dodajLetLabel;
        private System.Windows.Forms.Label polazisniAerodromLabel;
        private System.Windows.Forms.GroupBox noviLetGroupBox;
        private System.Windows.Forms.Button dodajLetButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.TextBox cijenaKarteTextBox;
        private System.Windows.Forms.Label cijenaKarteLabel;
        private System.Windows.Forms.ComboBox avionNaLetuComboBox;
        private System.Windows.Forms.Label avionNaLetuLabel;
        private System.Windows.Forms.Label datumVrijemeDolaskaLabel;
        private System.Windows.Forms.DateTimePicker datumVrijemeDolaskaDateTimePicker;
        private System.Windows.Forms.Label datumVrijemePolaskaLabel;
        private System.Windows.Forms.DateTimePicker datumVrijemePolaskaDateTimePicker;
        private System.Windows.Forms.ComboBox odredisniAerodromComboBox;
        private System.Windows.Forms.Label odredisniAerodromLabel;
        private System.Windows.Forms.ComboBox polazisniAerodromComboBox;
        private System.Windows.Forms.TextBox valutaTextBox;
        private System.Windows.Forms.ComboBox aviokompanijeComboBox;
        private System.Windows.Forms.Label aviokompanijaLabel;
    }
}