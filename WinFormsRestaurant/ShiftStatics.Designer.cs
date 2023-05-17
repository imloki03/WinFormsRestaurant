namespace WinFormsRestaurant
{
    partial class ShiftStatics
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
            this.chart_shift = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_shift)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_shift
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_shift.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_shift.Legends.Add(legend1);
            this.chart_shift.Location = new System.Drawing.Point(60, 49);
            this.chart_shift.Margin = new System.Windows.Forms.Padding(4);
            this.chart_shift.Name = "chart_shift";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_shift.Series.Add(series1);
            this.chart_shift.Size = new System.Drawing.Size(1293, 615);
            this.chart_shift.TabIndex = 0;
            this.chart_shift.Text = "chart1";
            // 
            // ShiftStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 681);
            this.Controls.Add(this.chart_shift);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1421, 728);
            this.MinimumSize = new System.Drawing.Size(1421, 728);
            this.Name = "ShiftStatics";
            this.Text = "ShiftStatics";
            this.Load += new System.EventHandler(this.ShiftStatics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_shift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_shift;
    }
}