namespace SkyFlyReservation
{
    partial class FormPregledRezervacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledRezervacija));
            this.popisRezervacijaLabel = new System.Windows.Forms.Label();
            this.popisRezervacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.platiRezervacijuButton = new System.Windows.Forms.Button();
            this.filtrirajPopisRezervacijaGroupBox = new System.Windows.Forms.GroupBox();
            this.prikaziSveRadio = new System.Windows.Forms.RadioButton();
            this.filtrirajPopisRezervacijaButton = new System.Windows.Forms.Button();
            this.nisuPlaceneRezervacijeRadio = new System.Windows.Forms.RadioButton();
            this.placeneRezervacijeRadio = new System.Windows.Forms.RadioButton();
            this.istekleRezervacijeRadio = new System.Windows.Forms.RadioButton();
            this.obrisiRezervacijuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisRezervacijaDataGridView)).BeginInit();
            this.filtrirajPopisRezervacijaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisRezervacijaLabel
            // 
            this.popisRezervacijaLabel.AutoSize = true;
            this.popisRezervacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisRezervacijaLabel.Location = new System.Drawing.Point(23, 25);
            this.popisRezervacijaLabel.Name = "popisRezervacijaLabel";
            this.popisRezervacijaLabel.Size = new System.Drawing.Size(169, 24);
            this.popisRezervacijaLabel.TabIndex = 1;
            this.popisRezervacijaLabel.Text = "Popis rezervacija";
            // 
            // popisRezervacijaDataGridView
            // 
            this.popisRezervacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisRezervacijaDataGridView.Location = new System.Drawing.Point(27, 61);
            this.popisRezervacijaDataGridView.Name = "popisRezervacijaDataGridView";
            this.popisRezervacijaDataGridView.RowHeadersWidth = 51;
            this.popisRezervacijaDataGridView.RowTemplate.Height = 24;
            this.popisRezervacijaDataGridView.Size = new System.Drawing.Size(1104, 469);
            this.popisRezervacijaDataGridView.TabIndex = 2;
            // 
            // platiRezervacijuButton
            // 
            this.platiRezervacijuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.platiRezervacijuButton.Location = new System.Drawing.Point(27, 536);
            this.platiRezervacijuButton.Name = "platiRezervacijuButton";
            this.platiRezervacijuButton.Size = new System.Drawing.Size(145, 42);
            this.platiRezervacijuButton.TabIndex = 3;
            this.platiRezervacijuButton.Text = "Plati rezervaciju";
            this.platiRezervacijuButton.UseVisualStyleBackColor = true;
            this.platiRezervacijuButton.Click += new System.EventHandler(this.platiRezervacijuButton_Click);
            // 
            // filtrirajPopisRezervacijaGroupBox
            // 
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.prikaziSveRadio);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.filtrirajPopisRezervacijaButton);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.nisuPlaceneRezervacijeRadio);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.placeneRezervacijeRadio);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.istekleRezervacijeRadio);
            this.filtrirajPopisRezervacijaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrirajPopisRezervacijaGroupBox.Location = new System.Drawing.Point(1147, 61);
            this.filtrirajPopisRezervacijaGroupBox.Name = "filtrirajPopisRezervacijaGroupBox";
            this.filtrirajPopisRezervacijaGroupBox.Size = new System.Drawing.Size(211, 279);
            this.filtrirajPopisRezervacijaGroupBox.TabIndex = 4;
            this.filtrirajPopisRezervacijaGroupBox.TabStop = false;
            this.filtrirajPopisRezervacijaGroupBox.Text = "Filtiriraj popis rezervacija :";
            // 
            // prikaziSveRadio
            // 
            this.prikaziSveRadio.AutoSize = true;
            this.prikaziSveRadio.Location = new System.Drawing.Point(6, 40);
            this.prikaziSveRadio.Name = "prikaziSveRadio";
            this.prikaziSveRadio.Size = new System.Drawing.Size(97, 21);
            this.prikaziSveRadio.TabIndex = 6;
            this.prikaziSveRadio.TabStop = true;
            this.prikaziSveRadio.Text = "Prikaži sve";
            this.prikaziSveRadio.UseVisualStyleBackColor = true;
            // 
            // filtrirajPopisRezervacijaButton
            // 
            this.filtrirajPopisRezervacijaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrirajPopisRezervacijaButton.Location = new System.Drawing.Point(58, 228);
            this.filtrirajPopisRezervacijaButton.Name = "filtrirajPopisRezervacijaButton";
            this.filtrirajPopisRezervacijaButton.Size = new System.Drawing.Size(98, 33);
            this.filtrirajPopisRezervacijaButton.TabIndex = 5;
            this.filtrirajPopisRezervacijaButton.Text = "Filtriraj";
            this.filtrirajPopisRezervacijaButton.UseVisualStyleBackColor = true;
            this.filtrirajPopisRezervacijaButton.Click += new System.EventHandler(this.filtrirajPopisRezervacijaButton_Click);
            // 
            // nisuPlaceneRezervacijeRadio
            // 
            this.nisuPlaceneRezervacijeRadio.AutoSize = true;
            this.nisuPlaceneRezervacijeRadio.Location = new System.Drawing.Point(6, 162);
            this.nisuPlaceneRezervacijeRadio.Name = "nisuPlaceneRezervacijeRadio";
            this.nisuPlaceneRezervacijeRadio.Size = new System.Drawing.Size(111, 21);
            this.nisuPlaceneRezervacijeRadio.TabIndex = 2;
            this.nisuPlaceneRezervacijeRadio.TabStop = true;
            this.nisuPlaceneRezervacijeRadio.Text = "Nisu plaćene";
            this.nisuPlaceneRezervacijeRadio.UseVisualStyleBackColor = true;
            // 
            // placeneRezervacijeRadio
            // 
            this.placeneRezervacijeRadio.AutoSize = true;
            this.placeneRezervacijeRadio.Location = new System.Drawing.Point(6, 80);
            this.placeneRezervacijeRadio.Name = "placeneRezervacijeRadio";
            this.placeneRezervacijeRadio.Size = new System.Drawing.Size(80, 21);
            this.placeneRezervacijeRadio.TabIndex = 0;
            this.placeneRezervacijeRadio.TabStop = true;
            this.placeneRezervacijeRadio.Text = "Plaćene";
            this.placeneRezervacijeRadio.UseVisualStyleBackColor = true;
            // 
            // istekleRezervacijeRadio
            // 
            this.istekleRezervacijeRadio.AutoSize = true;
            this.istekleRezervacijeRadio.Location = new System.Drawing.Point(6, 121);
            this.istekleRezervacijeRadio.Name = "istekleRezervacijeRadio";
            this.istekleRezervacijeRadio.Size = new System.Drawing.Size(69, 21);
            this.istekleRezervacijeRadio.TabIndex = 1;
            this.istekleRezervacijeRadio.TabStop = true;
            this.istekleRezervacijeRadio.Text = "Istekle";
            this.istekleRezervacijeRadio.UseVisualStyleBackColor = true;
            // 
            // obrisiRezervacijuButton
            // 
            this.obrisiRezervacijuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisiRezervacijuButton.Location = new System.Drawing.Point(178, 536);
            this.obrisiRezervacijuButton.Name = "obrisiRezervacijuButton";
            this.obrisiRezervacijuButton.Size = new System.Drawing.Size(158, 42);
            this.obrisiRezervacijuButton.TabIndex = 5;
            this.obrisiRezervacijuButton.Text = "Obriši rezervaciju";
            this.obrisiRezervacijuButton.UseVisualStyleBackColor = true;
            this.obrisiRezervacijuButton.Click += new System.EventHandler(this.obrisiRezervacijuButton_Click);
            // 
            // FormPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 602);
            this.Controls.Add(this.obrisiRezervacijuButton);
            this.Controls.Add(this.filtrirajPopisRezervacijaGroupBox);
            this.Controls.Add(this.platiRezervacijuButton);
            this.Controls.Add(this.popisRezervacijaDataGridView);
            this.Controls.Add(this.popisRezervacijaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPregledRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled rezervacija";
            this.Load += new System.EventHandler(this.FormPregledRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisRezervacijaDataGridView)).EndInit();
            this.filtrirajPopisRezervacijaGroupBox.ResumeLayout(false);
            this.filtrirajPopisRezervacijaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisRezervacijaLabel;
        private System.Windows.Forms.DataGridView popisRezervacijaDataGridView;
        private System.Windows.Forms.Button platiRezervacijuButton;
        private System.Windows.Forms.GroupBox filtrirajPopisRezervacijaGroupBox;
        private System.Windows.Forms.RadioButton istekleRezervacijeRadio;
        private System.Windows.Forms.RadioButton placeneRezervacijeRadio;
        private System.Windows.Forms.Button filtrirajPopisRezervacijaButton;
        private System.Windows.Forms.RadioButton nisuPlaceneRezervacijeRadio;
        private System.Windows.Forms.RadioButton prikaziSveRadio;
        private System.Windows.Forms.Button obrisiRezervacijuButton;
    }
}