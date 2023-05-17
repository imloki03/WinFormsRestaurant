namespace WinFormsRestaurant
{
    partial class WorkTimeStatics
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
            this.chart_worktime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_worktime)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_worktime
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_worktime.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_worktime.Legends.Add(legend1);
            this.chart_worktime.Location = new System.Drawing.Point(41, 26);
            this.chart_worktime.Name = "chart_worktime";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_worktime.Series.Add(series1);
            this.chart_worktime.Size = new System.Drawing.Size(970, 500);
            this.chart_worktime.TabIndex = 1;
            this.chart_worktime.Text = "chart1";
            // 
            // WorkTimeStatics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.chart_worktime);
            this.Name = "WorkTimeStatics";
            this.Text = "WorkTimeStatics";
            this.Load += new System.EventHandler(this.WorkTimeStatics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_worktime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_worktime;
    }
}