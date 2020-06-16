namespace SkyFlyReservation
{
    partial class FormPregledAvionaAviokompanije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledAvionaAviokompanije));
            this.popisAvionaDataGridView = new System.Windows.Forms.DataGridView();
            this.popisAvionaLabel = new System.Windows.Forms.Label();
            this.nazivAviokompanijeLabel = new System.Windows.Forms.Label();
            this.azurirajAvionButton = new System.Windows.Forms.Button();
            this.obrisiAvionButton = new System.Windows.Forms.Button();
            this.dodajAvionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisAvionaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // popisAvionaDataGridView
            // 
            this.popisAvionaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popisAvionaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisAvionaDataGridView.Location = new System.Drawing.Point(27, 61);
            this.popisAvionaDataGridView.Name = "popisAvionaDataGridView";
            this.popisAvionaDataGridView.RowHeadersWidth = 51;
            this.popisAvionaDataGridView.RowTemplate.Height = 24;
            this.popisAvionaDataGridView.Size = new System.Drawing.Size(793, 461);
            this.popisAvionaDataGridView.TabIndex = 3;
            // 
            // popisAvionaLabel
            // 
            this.popisAvionaLabel.AutoSize = true;
            this.popisAvionaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisAvionaLabel.Location = new System.Drawing.Point(23, 25);
            this.popisAvionaLabel.Name = "popisAvionaLabel";
            this.popisAvionaLabel.Size = new System.Drawing.Size(269, 24);
            this.popisAvionaLabel.TabIndex = 2;
            this.popisAvionaLabel.Text = "Popis aviona aviokompanije";
            // 
            // nazivAviokompanijeLabel
            // 
            this.nazivAviokompanijeLabel.AutoSize = true;
            this.nazivAviokompanijeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivAviokompanijeLabel.Location = new System.Drawing.Point(311, 25);
            this.nazivAviokompanijeLabel.Name = "nazivAviokompanijeLabel";
            this.nazivAviokompanijeLabel.Size = new System.Drawing.Size(0, 24);
            this.nazivAviokompanijeLabel.TabIndex = 4;
            // 
            // azurirajAvionButton
            // 
            this.azurirajAvionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.azurirajAvionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azurirajAvionButton.Location = new System.Drawing.Point(585, 528);
            this.azurirajAvionButton.Name = "azurirajAvionButton";
            this.azurirajAvionButton.Size = new System.Drawing.Size(117, 42);
            this.azurirajAvionButton.TabIndex = 14;
            this.azurirajAvionButton.Text = "Ažuriraj avion";
            this.azurirajAvionButton.UseVisualStyleBackColor = true;
            this.azurirajAvionButton.Click += new System.EventHandler(this.azurirajAvionButton_Click);
            // 
            // obrisiAvionButton
            // 
            this.obrisiAvionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.obrisiAvionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisiAvionButton.Location = new System.Drawing.Point(708, 528);
            this.obrisiAvionButton.Name = "obrisiAvionButton";
            this.obrisiAvionButton.Size = new System.Drawing.Size(112, 42);
            this.obrisiAvionButton.TabIndex = 13;
            this.obrisiAvionButton.Text = "Obriši avion";
            this.obrisiAvionButton.UseVisualStyleBackColor = true;
            this.obrisiAvionButton.Click += new System.EventHandler(this.obrisiAvionButton_Click);
            // 
            // dodajAvionButton
            // 
            this.dodajAvionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajAvionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajAvionButton.Location = new System.Drawing.Point(472, 528);
            this.dodajAvionButton.Name = "dodajAvionButton";
            this.dodajAvionButton.Size = new System.Drawing.Size(107, 42);
            this.dodajAvionButton.TabIndex = 12;
            this.dodajAvionButton.Text = "Dodaj avion";
            this.dodajAvionButton.UseVisualStyleBackColor = true;
            this.dodajAvionButton.Click += new System.EventHandler(this.dodajAvionButton_Click);
            // 
            // FormPregledAvionaAviokompanije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 588);
            this.Controls.Add(this.azurirajAvionButton);
            this.Controls.Add(this.obrisiAvionButton);
            this.Controls.Add(this.dodajAvionButton);
            this.Controls.Add(this.nazivAviokompanijeLabel);
            this.Controls.Add(this.popisAvionaDataGridView);
            this.Controls.Add(this.popisAvionaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPregledAvionaAviokompanije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled aviona";
            this.Load += new System.EventHandler(this.FormPregledAvionaAviokompanije_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPregledAvionaAviokompanije_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.popisAvionaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView popisAvionaDataGridView;
        private System.Windows.Forms.Label popisAvionaLabel;
        private System.Windows.Forms.Label nazivAviokompanijeLabel;
        private System.Windows.Forms.Button azurirajAvionButton;
        private System.Windows.Forms.Button obrisiAvionButton;
        private System.Windows.Forms.Button dodajAvionButton;
    }
}