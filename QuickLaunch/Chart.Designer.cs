namespace QuickLaunch
{
    partial class Chart
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
            this.chartTile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTile)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTile
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTile.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTile.Legends.Add(legend1);
            this.chartTile.Location = new System.Drawing.Point(27, 12);
            this.chartTile.Name = "chartTile";
            this.chartTile.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "TiLe";
            this.chartTile.Series.Add(series1);
            this.chartTile.Size = new System.Drawing.Size(645, 343);
            this.chartTile.TabIndex = 0;
            this.chartTile.TabStop = false;
            this.chartTile.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Tỉ lệ phần trăm sử dụng ứng dụng";
            this.chartTile.Titles.Add(title1);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 382);
            this.Controls.Add(this.chartTile);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTile;
    }
}