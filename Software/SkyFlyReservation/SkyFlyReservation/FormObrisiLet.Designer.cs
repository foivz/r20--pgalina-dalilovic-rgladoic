namespace SkyFlyReservation
{
    partial class FormObrisiLet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObrisiLet));
            this.nazivAviokompanijeLabel = new System.Windows.Forms.Label();
            this.popisLetovaDataGridView = new System.Windows.Forms.DataGridView();
            this.detaljiLetaLabel = new System.Windows.Forms.Label();
            this.oznakaOdabranogLetaLabel = new System.Windows.Forms.Label();
            this.detaljiLetaGroupBox = new System.Windows.Forms.GroupBox();
            this.obrisiLetButton = new System.Windows.Forms.Button();
            this.vrijemeDolaskaTextBox = new System.Windows.Forms.TextBox();
            this.vrijemeDolaskaLabel = new System.Windows.Forms.Label();
            this.vrijemePolaskaTextBox = new System.Windows.Forms.TextBox();
            this.vrijemePolaskaLabel = new System.Windows.Forms.Label();
            this.avionNaLetuTextBox = new System.Windows.Forms.TextBox();
            this.avionNaLetuLabel = new System.Windows.Forms.Label();
            this.odabraniOdredisniTextBox = new System.Windows.Forms.TextBox();
            this.odabraniOdredisniLabel = new System.Windows.Forms.Label();
            this.odabraniPolazisniTextBox = new System.Windows.Forms.TextBox();
            this.odabraniPolazisniLabel = new System.Windows.Forms.Label();
            this.popisLetovaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.popisLetovaDataGridView)).BeginInit();
            this.detaljiLetaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazivAviokompanijeLabel
            // 
            this.nazivAviokompanijeLabel.AutoSize = true;
            this.nazivAviokompanijeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivAviokompanijeLabel.Location = new System.Drawing.Point(299, 26);
            this.nazivAviokompanijeLabel.Name = "nazivAviokompanijeLabel";
            this.nazivAviokompanijeLabel.Size = new System.Drawing.Size(0, 24);
            this.nazivAviokompanijeLabel.TabIndex = 60;
            // 
            // popisLetovaDataGridView
            // 
            this.popisLetovaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisLetovaDataGridView.Location = new System.Drawing.Point(16, 62);
            this.popisLetovaDataGridView.Name = "popisLetovaDataGridView";
            this.popisLetovaDataGridView.RowHeadersWidth = 51;
            this.popisLetovaDataGridView.RowTemplate.Height = 24;
            this.popisLetovaDataGridView.Size = new System.Drawing.Size(793, 515);
            this.popisLetovaDataGridView.TabIndex = 59;
            this.popisLetovaDataGridView.SelectionChanged += new System.EventHandler(this.popisLetovaDataGridView_SelectionChanged);
            // 
            // detaljiLetaLabel
            // 
            this.detaljiLetaLabel.AutoSize = true;
            this.detaljiLetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detaljiLetaLabel.Location = new System.Drawing.Point(26, 32);
            this.detaljiLetaLabel.Name = "detaljiLetaLabel";
            this.detaljiLetaLabel.Size = new System.Drawing.Size(106, 24);
            this.detaljiLetaLabel.TabIndex = 30;
            this.detaljiLetaLabel.Text = "Detalji leta";
            // 
            // oznakaOdabranogLetaLabel
            // 
            this.oznakaOdabranogLetaLabel.AutoSize = true;
            this.oznakaOdabranogLetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oznakaOdabranogLetaLabel.Location = new System.Drawing.Point(138, 32);
            this.oznakaOdabranogLetaLabel.Name = "oznakaOdabranogLetaLabel";
            this.oznakaOdabranogLetaLabel.Size = new System.Drawing.Size(0, 24);
            this.oznakaOdabranogLetaLabel.TabIndex = 31;
            // 
            // detaljiLetaGroupBox
            // 
            this.detaljiLetaGroupBox.Controls.Add(this.obrisiLetButton);
            this.detaljiLetaGroupBox.Controls.Add(this.vrijemeDolaskaTextBox);
            this.detaljiLetaGroupBox.Controls.Add(this.vrijemeDolaskaLabel);
            this.detaljiLetaGroupBox.Controls.Add(this.vrijemePolaskaTextBox);
            this.detaljiLetaGroupBox.Controls.Add(this.vrijemePolaskaLabel);
            this.detaljiLetaGroupBox.Controls.Add(this.avionNaLetuTextBox);
            this.detaljiLetaGroupBox.Controls.Add(this.avionNaLetuLabel);
            this.detaljiLetaGroupBox.Controls.Add(this.odabraniOdredisniTextBox);
            this.detaljiLetaGroupBox.Controls.Add(this.odabraniOdredisniLabel);
            this.detaljiLetaGroupBox.Controls.Add(this.odabraniPolazisniTextBox);
            this.detaljiLetaGroupBox.Controls.Add(this.odabraniPolazisniLabel);
            this.detaljiLetaGroupBox.Controls.Add(this.detaljiLetaLabel);
            this.detaljiLetaGroupBox.Controls.Add(this.oznakaOdabranogLetaLabel);
            this.detaljiLetaGroupBox.Location = new System.Drawing.Point(829, 59);
            this.detaljiLetaGroupBox.Name = "detaljiLetaGroupBox";
            this.detaljiLetaGroupBox.Size = new System.Drawing.Size(306, 469);
            this.detaljiLetaGroupBox.TabIndex = 57;
            this.detaljiLetaGroupBox.TabStop = false;
            this.detaljiLetaGroupBox.Text = "Detalji leta:";
            // 
            // obrisiLetButton
            // 
            this.obrisiLetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisiLetButton.Location = new System.Drawing.Point(95, 412);
            this.obrisiLetButton.Name = "obrisiLetButton";
            this.obrisiLetButton.Size = new System.Drawing.Size(105, 34);
            this.obrisiLetButton.TabIndex = 57;
            this.obrisiLetButton.Text = "Obriši let";
            this.obrisiLetButton.UseVisualStyleBackColor = true;
            this.obrisiLetButton.Click += new System.EventHandler(this.obrisiLetButton_Click);
            // 
            // vrijemeDolaskaTextBox
            // 
            this.vrijemeDolaskaTextBox.Enabled = false;
            this.vrijemeDolaskaTextBox.Location = new System.Drawing.Point(30, 357);
            this.vrijemeDolaskaTextBox.Name = "vrijemeDolaskaTextBox";
            this.vrijemeDolaskaTextBox.ReadOnly = true;
            this.vrijemeDolaskaTextBox.Size = new System.Drawing.Size(240, 22);
            this.vrijemeDolaskaTextBox.TabIndex = 55;
            // 
            // vrijemeDolaskaLabel
            // 
            this.vrijemeDolaskaLabel.AutoSize = true;
            this.vrijemeDolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vrijemeDolaskaLabel.Location = new System.Drawing.Point(27, 336);
            this.vrijemeDolaskaLabel.Name = "vrijemeDolaskaLabel";
            this.vrijemeDolaskaLabel.Size = new System.Drawing.Size(116, 17);
            this.vrijemeDolaskaLabel.TabIndex = 54;
            this.vrijemeDolaskaLabel.Text = "Vrijeme dolaska :";
            // 
            // vrijemePolaskaTextBox
            // 
            this.vrijemePolaskaTextBox.Enabled = false;
            this.vrijemePolaskaTextBox.Location = new System.Drawing.Point(30, 293);
            this.vrijemePolaskaTextBox.Name = "vrijemePolaskaTextBox";
            this.vrijemePolaskaTextBox.ReadOnly = true;
            this.vrijemePolaskaTextBox.Size = new System.Drawing.Size(240, 22);
            this.vrijemePolaskaTextBox.TabIndex = 53;
            // 
            // vrijemePolaskaLabel
            // 
            this.vrijemePolaskaLabel.AutoSize = true;
            this.vrijemePolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vrijemePolaskaLabel.Location = new System.Drawing.Point(27, 273);
            this.vrijemePolaskaLabel.Name = "vrijemePolaskaLabel";
            this.vrijemePolaskaLabel.Size = new System.Drawing.Size(116, 17);
            this.vrijemePolaskaLabel.TabIndex = 52;
            this.vrijemePolaskaLabel.Text = "Vrijeme polaska :";
            // 
            // avionNaLetuTextBox
            // 
            this.avionNaLetuTextBox.Enabled = false;
            this.avionNaLetuTextBox.Location = new System.Drawing.Point(30, 229);
            this.avionNaLetuTextBox.Name = "avionNaLetuTextBox";
            this.avionNaLetuTextBox.ReadOnly = true;
            this.avionNaLetuTextBox.Size = new System.Drawing.Size(240, 22);
            this.avionNaLetuTextBox.TabIndex = 51;
            // 
            // avionNaLetuLabel
            // 
            this.avionNaLetuLabel.AutoSize = true;
            this.avionNaLetuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avionNaLetuLabel.Location = new System.Drawing.Point(27, 209);
            this.avionNaLetuLabel.Name = "avionNaLetuLabel";
            this.avionNaLetuLabel.Size = new System.Drawing.Size(98, 17);
            this.avionNaLetuLabel.TabIndex = 50;
            this.avionNaLetuLabel.Text = "Avion na letu :";
            // 
            // odabraniOdredisniTextBox
            // 
            this.odabraniOdredisniTextBox.Enabled = false;
            this.odabraniOdredisniTextBox.Location = new System.Drawing.Point(30, 166);
            this.odabraniOdredisniTextBox.Name = "odabraniOdredisniTextBox";
            this.odabraniOdredisniTextBox.ReadOnly = true;
            this.odabraniOdredisniTextBox.Size = new System.Drawing.Size(240, 22);
            this.odabraniOdredisniTextBox.TabIndex = 49;
            // 
            // odabraniOdredisniLabel
            // 
            this.odabraniOdredisniLabel.AutoSize = true;
            this.odabraniOdredisniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabraniOdredisniLabel.Location = new System.Drawing.Point(27, 145);
            this.odabraniOdredisniLabel.Name = "odabraniOdredisniLabel";
            this.odabraniOdredisniLabel.Size = new System.Drawing.Size(142, 17);
            this.odabraniOdredisniLabel.TabIndex = 48;
            this.odabraniOdredisniLabel.Text = "Odredišni aerodrom :";
            // 
            // odabraniPolazisniTextBox
            // 
            this.odabraniPolazisniTextBox.Enabled = false;
            this.odabraniPolazisniTextBox.Location = new System.Drawing.Point(30, 103);
            this.odabraniPolazisniTextBox.Name = "odabraniPolazisniTextBox";
            this.odabraniPolazisniTextBox.ReadOnly = true;
            this.odabraniPolazisniTextBox.Size = new System.Drawing.Size(240, 22);
            this.odabraniPolazisniTextBox.TabIndex = 47;
            // 
            // odabraniPolazisniLabel
            // 
            this.odabraniPolazisniLabel.AutoSize = true;
            this.odabraniPolazisniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabraniPolazisniLabel.Location = new System.Drawing.Point(27, 82);
            this.odabraniPolazisniLabel.Name = "odabraniPolazisniLabel";
            this.odabraniPolazisniLabel.Size = new System.Drawing.Size(137, 17);
            this.odabraniPolazisniLabel.TabIndex = 46;
            this.odabraniPolazisniLabel.Text = "Polazišni aerodrom :";
            // 
            // popisLetovaLabel
            // 
            this.popisLetovaLabel.AutoSize = true;
            this.popisLetovaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisLetovaLabel.Location = new System.Drawing.Point(12, 26);
            this.popisLetovaLabel.Name = "popisLetovaLabel";
            this.popisLetovaLabel.Size = new System.Drawing.Size(263, 24);
            this.popisLetovaLabel.TabIndex = 58;
            this.popisLetovaLabel.Text = "Popis letova aviokompanije";
            // 
            // FormObrisiLet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 637);
            this.Controls.Add(this.nazivAviokompanijeLabel);
            this.Controls.Add(this.popisLetovaDataGridView);
            this.Controls.Add(this.detaljiLetaGroupBox);
            this.Controls.Add(this.popisLetovaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormObrisiLet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obrisi let";
            this.Load += new System.EventHandler(this.FormObrisiLet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormObrisiLet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.popisLetovaDataGridView)).EndInit();
            this.detaljiLetaGroupBox.ResumeLayout(false);
            this.detaljiLetaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivAviokompanijeLabel;
        private System.Windows.Forms.DataGridView popisLetovaDataGridView;
        private System.Windows.Forms.Label detaljiLetaLabel;
        private System.Windows.Forms.Label oznakaOdabranogLetaLabel;
        private System.Windows.Forms.GroupBox detaljiLetaGroupBox;
        private System.Windows.Forms.Label popisLetovaLabel;
        private System.Windows.Forms.Button obrisiLetButton;
        private System.Windows.Forms.TextBox vrijemeDolaskaTextBox;
        private System.Windows.Forms.Label vrijemeDolaskaLabel;
        private System.Windows.Forms.TextBox vrijemePolaskaTextBox;
        private System.Windows.Forms.Label vrijemePolaskaLabel;
        private System.Windows.Forms.TextBox avionNaLetuTextBox;
        private System.Windows.Forms.Label avionNaLetuLabel;
        private System.Windows.Forms.TextBox odabraniOdredisniTextBox;
        private System.Windows.Forms.Label odabraniOdredisniLabel;
        private System.Windows.Forms.TextBox odabraniPolazisniTextBox;
        private System.Windows.Forms.Label odabraniPolazisniLabel;
    }
}