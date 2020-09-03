namespace SkyFlyReservation
{
    partial class FormPrikazIzvjesca
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrikazIzvjesca));
            this.chartPolaznisniAerodromi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPreuzmi = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPreuzmi2 = new System.Windows.Forms.Button();
            this.chartOdredisniAerodromi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPolaznisniAerodromi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOdredisniAerodromi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPolaznisniAerodromi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPolaznisniAerodromi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPolaznisniAerodromi.Legends.Add(legend1);
            this.chartPolaznisniAerodromi.Location = new System.Drawing.Point(12, 12);
            this.chartPolaznisniAerodromi.Name = "chartPolaznisniAerodromi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Broj polazaka";
            this.chartPolaznisniAerodromi.Series.Add(series1);
            this.chartPolaznisniAerodromi.Size = new System.Drawing.Size(584, 319);
            this.chartPolaznisniAerodromi.TabIndex = 0;
            this.chartPolaznisniAerodromi.Text = "chartPolazisniAerodromi";
            title1.BackColor = System.Drawing.Color.Yellow;
            title1.Name = "Polazišni aerodromi";
            title1.Text = "Polazišni aerodromi";
            this.chartPolaznisniAerodromi.Titles.Add(title1);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(704, 697);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(84, 40);
            this.btnOdustani.TabIndex = 112;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPreuzmi
            // 
            this.btnPreuzmi.Location = new System.Drawing.Point(602, 292);
            this.btnPreuzmi.Name = "btnPreuzmi";
            this.btnPreuzmi.Size = new System.Drawing.Size(84, 40);
            this.btnPreuzmi.TabIndex = 113;
            this.btnPreuzmi.Text = "Preuzmi";
            this.btnPreuzmi.UseVisualStyleBackColor = true;
            this.btnPreuzmi.Click += new System.EventHandler(this.btnPreuzmi_Click);
            // 
            // btnPreuzmi2
            // 
            this.btnPreuzmi2.Location = new System.Drawing.Point(602, 640);
            this.btnPreuzmi2.Name = "btnPreuzmi2";
            this.btnPreuzmi2.Size = new System.Drawing.Size(84, 40);
            this.btnPreuzmi2.TabIndex = 115;
            this.btnPreuzmi2.Text = "Preuzmi";
            this.btnPreuzmi2.UseVisualStyleBackColor = true;
            this.btnPreuzmi2.Click += new System.EventHandler(this.btnPreuzmi2_Click);
            // 
            // chartOdredisniAerodromi
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOdredisniAerodromi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOdredisniAerodromi.Legends.Add(legend2);
            this.chartOdredisniAerodromi.Location = new System.Drawing.Point(12, 361);
            this.chartOdredisniAerodromi.Name = "chartOdredisniAerodromi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Broj dolazaka";
            this.chartOdredisniAerodromi.Series.Add(series2);
            this.chartOdredisniAerodromi.Size = new System.Drawing.Size(584, 319);
            this.chartOdredisniAerodromi.TabIndex = 116;
            this.chartOdredisniAerodromi.Text = "chartPolazisniAerodromi";
            title2.BackColor = System.Drawing.Color.Yellow;
            title2.Name = "Odredišni aerodromi";
            title2.Text = "Odredišni aerodromi";
            this.chartOdredisniAerodromi.Titles.Add(title2);
            // 
            // FormPrikazIzvjesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.chartOdredisniAerodromi);
            this.Controls.Add(this.btnPreuzmi2);
            this.Controls.Add(this.btnPreuzmi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.chartPolaznisniAerodromi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrikazIzvjesca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz izvješća";
            this.Load += new System.EventHandler(this.FormPrikazIzvjesca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrikazIzvjesca_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chartPolaznisniAerodromi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOdredisniAerodromi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPolaznisniAerodromi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPreuzmi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPreuzmi2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOdredisniAerodromi;
    }
}