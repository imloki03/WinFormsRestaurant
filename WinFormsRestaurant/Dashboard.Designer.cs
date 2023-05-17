namespace WinFormsRestaurant
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.bt_shift1 = new System.Windows.Forms.Button();
            this.bt_shift2 = new System.Windows.Forms.Button();
            this.bt_shift3 = new System.Windows.Forms.Button();
            this.pn_orders = new System.Windows.Forms.Panel();
            this.lb_orders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_totalrevenue = new System.Windows.Forms.Panel();
            this.lb_diners = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_revenue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_working = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_checkin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_scheduled = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lb_date = new System.Windows.Forms.Label();
            this.pn_orders.SuspendLayout();
            this.pn_totalrevenue.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // dt_date
            // 
            this.dt_date.CustomFormat = "dddd, MMM  dd, yyyy";
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_date.Location = new System.Drawing.Point(491, 11);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(150, 20);
            this.dt_date.TabIndex = 1;
            this.dt_date.Value = new System.DateTime(2023, 4, 1, 0, 0, 0, 0);
            this.dt_date.ValueChanged += new System.EventHandler(this.dt_date_ValueChanged);
            // 
            // bt_shift1
            // 
            this.bt_shift1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.bt_shift1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_shift1.FlatAppearance.BorderSize = 2;
            this.bt_shift1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_shift1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_shift1.Location = new System.Drawing.Point(654, 7);
            this.bt_shift1.Name = "bt_shift1";
            this.bt_shift1.Size = new System.Drawing.Size(125, 30);
            this.bt_shift1.TabIndex = 2;
            this.bt_shift1.Text = "6:00AM - 10:00AM";
            this.bt_shift1.UseVisualStyleBackColor = false;
            this.bt_shift1.Click += new System.EventHandler(this.bt_shift1_Click);
            // 
            // bt_shift2
            // 
            this.bt_shift2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.bt_shift2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_shift2.FlatAppearance.BorderSize = 2;
            this.bt_shift2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_shift2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_shift2.Location = new System.Drawing.Point(777, 7);
            this.bt_shift2.Name = "bt_shift2";
            this.bt_shift2.Size = new System.Drawing.Size(125, 30);
            this.bt_shift2.TabIndex = 3;
            this.bt_shift2.Text = "11:00AM - 3:00PM";
            this.bt_shift2.UseVisualStyleBackColor = false;
            this.bt_shift2.Click += new System.EventHandler(this.bt_shift2_Click);
            // 
            // bt_shift3
            // 
            this.bt_shift3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.bt_shift3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_shift3.FlatAppearance.BorderSize = 2;
            this.bt_shift3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_shift3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_shift3.Location = new System.Drawing.Point(900, 7);
            this.bt_shift3.Name = "bt_shift3";
            this.bt_shift3.Size = new System.Drawing.Size(125, 30);
            this.bt_shift3.TabIndex = 4;
            this.bt_shift3.Text = "6:00PM - 10:00PM";
            this.bt_shift3.UseVisualStyleBackColor = false;
            this.bt_shift3.Click += new System.EventHandler(this.bt_shift3_Click);
            // 
            // pn_orders
            // 
            this.pn_orders.BackColor = System.Drawing.Color.White;
            this.pn_orders.Controls.Add(this.lb_orders);
            this.pn_orders.Controls.Add(this.label2);
            this.pn_orders.Location = new System.Drawing.Point(9, 43);
            this.pn_orders.Name = "pn_orders";
            this.pn_orders.Size = new System.Drawing.Size(346, 80);
            this.pn_orders.TabIndex = 5;
            // 
            // lb_orders
            // 
            this.lb_orders.AutoSize = true;
            this.lb_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orders.Location = new System.Drawing.Point(53, 35);
            this.lb_orders.Name = "lb_orders";
            this.lb_orders.Size = new System.Drawing.Size(67, 25);
            this.lb_orders.TabIndex = 1;
            this.lb_orders.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orders";
            // 
            // pn_totalrevenue
            // 
            this.pn_totalrevenue.BackColor = System.Drawing.Color.White;
            this.pn_totalrevenue.Controls.Add(this.lb_diners);
            this.pn_totalrevenue.Controls.Add(this.label5);
            this.pn_totalrevenue.Location = new System.Drawing.Point(364, 43);
            this.pn_totalrevenue.Name = "pn_totalrevenue";
            this.pn_totalrevenue.Size = new System.Drawing.Size(346, 80);
            this.pn_totalrevenue.TabIndex = 6;
            // 
            // lb_diners
            // 
            this.lb_diners.AutoSize = true;
            this.lb_diners.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diners.Location = new System.Drawing.Point(57, 35);
            this.lb_diners.Name = "lb_diners";
            this.lb_diners.Size = new System.Drawing.Size(67, 25);
            this.lb_diners.TabIndex = 3;
            this.lb_diners.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(61, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diners";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lb_revenue);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(719, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 80);
            this.panel3.TabIndex = 6;
            // 
            // lb_revenue
            // 
            this.lb_revenue.AutoSize = true;
            this.lb_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_revenue.Location = new System.Drawing.Point(57, 35);
            this.lb_revenue.Name = "lb_revenue";
            this.lb_revenue.Size = new System.Drawing.Size(67, 25);
            this.lb_revenue.TabIndex = 3;
            this.lb_revenue.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(61, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Revenue";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 132);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(701, 269);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(719, 132);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(346, 520);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lb_working);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.lb_checkin);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lb_scheduled);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lb_total);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(9, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 243);
            this.panel4.TabIndex = 6;
            // 
            // lb_working
            // 
            this.lb_working.AutoSize = true;
            this.lb_working.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_working.Location = new System.Drawing.Point(38, 205);
            this.lb_working.Name = "lb_working";
            this.lb_working.Size = new System.Drawing.Size(67, 25);
            this.lb_working.TabIndex = 8;
            this.lb_working.Text = "10000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(42, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Working";
            // 
            // lb_checkin
            // 
            this.lb_checkin.AutoSize = true;
            this.lb_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkin.Location = new System.Drawing.Point(38, 153);
            this.lb_checkin.Name = "lb_checkin";
            this.lb_checkin.Size = new System.Drawing.Size(67, 25);
            this.lb_checkin.TabIndex = 6;
            this.lb_checkin.Text = "10000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(42, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Checked-IN";
            // 
            // lb_scheduled
            // 
            this.lb_scheduled.AutoSize = true;
            this.lb_scheduled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scheduled.Location = new System.Drawing.Point(38, 100);
            this.lb_scheduled.Name = "lb_scheduled";
            this.lb_scheduled.Size = new System.Drawing.Size(67, 25);
            this.lb_scheduled.TabIndex = 4;
            this.lb_scheduled.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(42, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Scheduled Today";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Employee";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(38, 48);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(67, 25);
            this.lb_total.TabIndex = 1;
            this.lb_total.Text = "10000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(42, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(209, 409);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 243);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(491, 10);
            this.lb_date.MinimumSize = new System.Drawing.Size(150, 20);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(150, 20);
            this.lb_date.TabIndex = 10;
            this.lb_date.Text = "Saturday, Apr 01, 2023";
            this.lb_date.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_date.Click += new System.EventHandler(this.lb_date_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn_totalrevenue);
            this.Controls.Add(this.pn_orders);
            this.Controls.Add(this.bt_shift3);
            this.Controls.Add(this.bt_shift2);
            this.Controls.Add(this.bt_shift1);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1090, 700);
            this.MinimumSize = new System.Drawing.Size(1090, 700);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pn_orders.ResumeLayout(false);
            this.pn_orders.PerformLayout();
            this.pn_totalrevenue.ResumeLayout(false);
            this.pn_totalrevenue.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Button bt_shift1;
        private System.Windows.Forms.Button bt_shift2;
        private System.Windows.Forms.Button bt_shift3;
        private System.Windows.Forms.Panel pn_orders;
        private System.Windows.Forms.Label lb_orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_totalrevenue;
        private System.Windows.Forms.Label lb_diners;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_revenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_working;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_checkin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_scheduled;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lb_date;
    }
}