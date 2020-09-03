namespace SkyFlyReservation
{
    partial class FormPregledZahtjeva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledZahtjeva));
            this.popisRezervacijaLabel = new System.Windows.Forms.Label();
            this.dgvPregledZahtjeva = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDetaljiZahtjeva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledZahtjeva)).BeginInit();
            this.SuspendLayout();
            // 
            // popisRezervacijaLabel
            // 
            this.popisRezervacijaLabel.AutoSize = true;
            this.popisRezervacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisRezervacijaLabel.Location = new System.Drawing.Point(20, 20);
            this.popisRezervacijaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisRezervacijaLabel.Name = "popisRezervacijaLabel";
            this.popisRezervacijaLabel.Size = new System.Drawing.Size(118, 18);
            this.popisRezervacijaLabel.TabIndex = 2;
            this.popisRezervacijaLabel.Text = "Popis zahtjeva";
            // 
            // dgvPregledZahtjeva
            // 
            this.dgvPregledZahtjeva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledZahtjeva.Location = new System.Drawing.Point(23, 63);
            this.dgvPregledZahtjeva.Name = "dgvPregledZahtjeva";
            this.dgvPregledZahtjeva.Size = new System.Drawing.Size(750, 304);
            this.dgvPregledZahtjeva.TabIndex = 3;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(670, 398);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(84, 40);
            this.btnOdustani.TabIndex = 112;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDetaljiZahtjeva
            // 
            this.btnDetaljiZahtjeva.Location = new System.Drawing.Point(39, 398);
            this.btnDetaljiZahtjeva.Name = "btnDetaljiZahtjeva";
            this.btnDetaljiZahtjeva.Size = new System.Drawing.Size(84, 40);
            this.btnDetaljiZahtjeva.TabIndex = 113;
            this.btnDetaljiZahtjeva.Text = "Detalji zahtjeva";
            this.btnDetaljiZahtjeva.UseVisualStyleBackColor = true;
            this.btnDetaljiZahtjeva.Click += new System.EventHandler(this.btnDetaljiZahtjeva_Click);
            // 
            // FormPregledZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetaljiZahtjeva);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvPregledZahtjeva);
            this.Controls.Add(this.popisRezervacijaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPregledZahtjeva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled zahtjeva";
            this.Load += new System.EventHandler(this.FormPregledZahtjeva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPregledZahtjeva_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledZahtjeva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisRezervacijaLabel;
        private System.Windows.Forms.DataGridView dgvPregledZahtjeva;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDetaljiZahtjeva;
    }
}