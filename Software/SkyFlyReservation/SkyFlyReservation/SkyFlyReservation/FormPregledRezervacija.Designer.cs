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
            this.filtrirajPopisRezervacijaButton = new System.Windows.Forms.Button();
            this.nisuPlaceneRezervacijeRadio = new System.Windows.Forms.RadioButton();
            this.istekleRezervacijeRadio = new System.Windows.Forms.RadioButton();
            this.placeneRezervacijeRadio = new System.Windows.Forms.RadioButton();
            this.ObrisiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisRezervacijaDataGridView)).BeginInit();
            this.filtrirajPopisRezervacijaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisRezervacijaLabel
            // 
            this.popisRezervacijaLabel.AutoSize = true;
            this.popisRezervacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisRezervacijaLabel.Location = new System.Drawing.Point(17, 20);
            this.popisRezervacijaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisRezervacijaLabel.Name = "popisRezervacijaLabel";
            this.popisRezervacijaLabel.Size = new System.Drawing.Size(138, 18);
            this.popisRezervacijaLabel.TabIndex = 1;
            this.popisRezervacijaLabel.Text = "Popis rezervacija";
            // 
            // popisRezervacijaDataGridView
            // 
            this.popisRezervacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisRezervacijaDataGridView.Location = new System.Drawing.Point(20, 50);
            this.popisRezervacijaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.popisRezervacijaDataGridView.Name = "popisRezervacijaDataGridView";
            this.popisRezervacijaDataGridView.RowHeadersWidth = 51;
            this.popisRezervacijaDataGridView.RowTemplate.Height = 24;
            this.popisRezervacijaDataGridView.Size = new System.Drawing.Size(537, 362);
            this.popisRezervacijaDataGridView.TabIndex = 2;
            // 
            // platiRezervacijuButton
            // 
            this.platiRezervacijuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.platiRezervacijuButton.Location = new System.Drawing.Point(405, 426);
            this.platiRezervacijuButton.Margin = new System.Windows.Forms.Padding(2);
            this.platiRezervacijuButton.Name = "platiRezervacijuButton";
            this.platiRezervacijuButton.Size = new System.Drawing.Size(74, 34);
            this.platiRezervacijuButton.TabIndex = 3;
            this.platiRezervacijuButton.Text = "Plati ";
            this.platiRezervacijuButton.UseVisualStyleBackColor = true;
            this.platiRezervacijuButton.Click += new System.EventHandler(this.platiRezervacijuButton_Click);
            // 
            // filtrirajPopisRezervacijaGroupBox
            // 
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.filtrirajPopisRezervacijaButton);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.nisuPlaceneRezervacijeRadio);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.istekleRezervacijeRadio);
            this.filtrirajPopisRezervacijaGroupBox.Controls.Add(this.placeneRezervacijeRadio);
            this.filtrirajPopisRezervacijaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrirajPopisRezervacijaGroupBox.Location = new System.Drawing.Point(572, 50);
            this.filtrirajPopisRezervacijaGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtrirajPopisRezervacijaGroupBox.Name = "filtrirajPopisRezervacijaGroupBox";
            this.filtrirajPopisRezervacijaGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.filtrirajPopisRezervacijaGroupBox.Size = new System.Drawing.Size(166, 201);
            this.filtrirajPopisRezervacijaGroupBox.TabIndex = 4;
            this.filtrirajPopisRezervacijaGroupBox.TabStop = false;
            this.filtrirajPopisRezervacijaGroupBox.Text = "Filtiriraj popis rezervacija :";
            // 
            // filtrirajPopisRezervacijaButton
            // 
            this.filtrirajPopisRezervacijaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrirajPopisRezervacijaButton.Location = new System.Drawing.Point(42, 162);
            this.filtrirajPopisRezervacijaButton.Margin = new System.Windows.Forms.Padding(2);
            this.filtrirajPopisRezervacijaButton.Name = "filtrirajPopisRezervacijaButton";
            this.filtrirajPopisRezervacijaButton.Size = new System.Drawing.Size(74, 27);
            this.filtrirajPopisRezervacijaButton.TabIndex = 5;
            this.filtrirajPopisRezervacijaButton.Text = "Filtriraj";
            this.filtrirajPopisRezervacijaButton.UseVisualStyleBackColor = true;
            this.filtrirajPopisRezervacijaButton.Click += new System.EventHandler(this.filtrirajPopisRezervacijaButton_Click);
            // 
            // nisuPlaceneRezervacijeRadio
            // 
            this.nisuPlaceneRezervacijeRadio.AutoSize = true;
            this.nisuPlaceneRezervacijeRadio.Location = new System.Drawing.Point(5, 104);
            this.nisuPlaceneRezervacijeRadio.Margin = new System.Windows.Forms.Padding(2);
            this.nisuPlaceneRezervacijeRadio.Name = "nisuPlaceneRezervacijeRadio";
            this.nisuPlaceneRezervacijeRadio.Size = new System.Drawing.Size(87, 17);
            this.nisuPlaceneRezervacijeRadio.TabIndex = 2;
            this.nisuPlaceneRezervacijeRadio.TabStop = true;
            this.nisuPlaceneRezervacijeRadio.Text = "Nisu plaćene";
            this.nisuPlaceneRezervacijeRadio.UseVisualStyleBackColor = true;
            // 
            // istekleRezervacijeRadio
            // 
            this.istekleRezervacijeRadio.AutoSize = true;
            this.istekleRezervacijeRadio.Location = new System.Drawing.Point(5, 68);
            this.istekleRezervacijeRadio.Margin = new System.Windows.Forms.Padding(2);
            this.istekleRezervacijeRadio.Name = "istekleRezervacijeRadio";
            this.istekleRezervacijeRadio.Size = new System.Drawing.Size(56, 17);
            this.istekleRezervacijeRadio.TabIndex = 1;
            this.istekleRezervacijeRadio.TabStop = true;
            this.istekleRezervacijeRadio.Text = "Istekle";
            this.istekleRezervacijeRadio.UseVisualStyleBackColor = true;
            // 
            // placeneRezervacijeRadio
            // 
            this.placeneRezervacijeRadio.AutoSize = true;
            this.placeneRezervacijeRadio.Location = new System.Drawing.Point(5, 33);
            this.placeneRezervacijeRadio.Margin = new System.Windows.Forms.Padding(2);
            this.placeneRezervacijeRadio.Name = "placeneRezervacijeRadio";
            this.placeneRezervacijeRadio.Size = new System.Drawing.Size(64, 17);
            this.placeneRezervacijeRadio.TabIndex = 0;
            this.placeneRezervacijeRadio.TabStop = true;
            this.placeneRezervacijeRadio.Text = "Plaćene";
            this.placeneRezervacijeRadio.UseVisualStyleBackColor = true;
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObrisiButton.Location = new System.Drawing.Point(483, 426);
            this.ObrisiButton.Margin = new System.Windows.Forms.Padding(2);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(74, 34);
            this.ObrisiButton.TabIndex = 5;
            this.ObrisiButton.Text = "Obriši";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            // 
            // FormPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 473);
            this.Controls.Add(this.ObrisiButton);
            this.Controls.Add(this.filtrirajPopisRezervacijaGroupBox);
            this.Controls.Add(this.platiRezervacijuButton);
            this.Controls.Add(this.popisRezervacijaDataGridView);
            this.Controls.Add(this.popisRezervacijaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button ObrisiButton;
    }
}