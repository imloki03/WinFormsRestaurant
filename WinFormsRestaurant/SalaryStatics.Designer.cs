namespace WinFormsRestaurant
{
    partial class SalaryStatics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_salary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_salary
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_salary.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_salary.Legends.Add(legend2);
            this.chart_salary.Location = new System.Drawing.Point(44, 27);
            this.chart_salary.Name = "chart_salary";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_salary.Series.Add(series2);
            this.chart_salary.Size = new System.Drawing.Size(970, 500);
            this.chart_salary.TabIndex = 0;
            this.chart_salary.Text = "chart1";
            // 
            // SalaryStatics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.chart_salary);
            this.Name = "SalaryStatics";
            this.Text = "SalaryStatics";
            this.Load += new System.EventHandler(this.SalaryStatics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_salary;
    }
}