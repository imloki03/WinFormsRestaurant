namespace WinFormsRestaurant
{
    partial class Manage
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pn_statistics = new System.Windows.Forms.Panel();
            this.bt_statistics = new System.Windows.Forms.Button();
            this.pn_summarizeSalary = new System.Windows.Forms.Panel();
            this.bt_SummarizeSalary = new System.Windows.Forms.Button();
            this.pn_dashboard = new System.Windows.Forms.Panel();
            this.bt_Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_manageShift = new System.Windows.Forms.Panel();
            this.bt_ManageShift = new System.Windows.Forms.Button();
            this.pn_manageAccount = new System.Windows.Forms.Panel();
            this.bt_ManageAccount = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pn_statistics.SuspendLayout();
            this.pn_summarizeSalary.SuspendLayout();
            this.pn_dashboard.SuspendLayout();
            this.pn_manageShift.SuspendLayout();
            this.pn_manageAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pn_main.Location = new System.Drawing.Point(195, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1090, 700);
            this.pn_main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.pn_statistics);
            this.panel2.Controls.Add(this.pn_summarizeSalary);
            this.panel2.Controls.Add(this.pn_dashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pn_manageShift);
            this.panel2.Controls.Add(this.pn_manageAccount);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 700);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(5, 598);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 0;
            // 
            // pn_statistics
            // 
            this.pn_statistics.BackColor = System.Drawing.Color.Red;
            this.pn_statistics.Controls.Add(this.bt_statistics);
            this.pn_statistics.Location = new System.Drawing.Point(0, 502);
            this.pn_statistics.Name = "pn_statistics";
            this.pn_statistics.Size = new System.Drawing.Size(200, 100);
            this.pn_statistics.TabIndex = 2;
            // 
            // bt_statistics
            // 
            this.bt_statistics.Location = new System.Drawing.Point(5, 0);
            this.bt_statistics.Name = "bt_statistics";
            this.bt_statistics.Size = new System.Drawing.Size(197, 95);
            this.bt_statistics.TabIndex = 1;
            this.bt_statistics.Text = "Statistics";
            this.bt_statistics.UseVisualStyleBackColor = true;
            this.bt_statistics.Click += new System.EventHandler(this.bt_statistics_Click);
            // 
            // pn_summarizeSalary
            // 
            this.pn_summarizeSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pn_summarizeSalary.Controls.Add(this.bt_SummarizeSalary);
            this.pn_summarizeSalary.Location = new System.Drawing.Point(2, 402);
            this.pn_summarizeSalary.Name = "pn_summarizeSalary";
            this.pn_summarizeSalary.Size = new System.Drawing.Size(200, 100);
            this.pn_summarizeSalary.TabIndex = 3;
            // 
            // bt_SummarizeSalary
            // 
            this.bt_SummarizeSalary.Location = new System.Drawing.Point(2, 0);
            this.bt_SummarizeSalary.Name = "bt_SummarizeSalary";
            this.bt_SummarizeSalary.Size = new System.Drawing.Size(197, 95);
            this.bt_SummarizeSalary.TabIndex = 1;
            this.bt_SummarizeSalary.Text = "Summarize Salary";
            this.bt_SummarizeSalary.UseVisualStyleBackColor = true;
            this.bt_SummarizeSalary.Click += new System.EventHandler(this.bt_SummarizeSalary_Click);
            // 
            // pn_dashboard
            // 
            this.pn_dashboard.BackColor = System.Drawing.SystemColors.Control;
            this.pn_dashboard.Controls.Add(this.bt_Dashboard);
            this.pn_dashboard.Location = new System.Drawing.Point(5, 101);
            this.pn_dashboard.Name = "pn_dashboard";
            this.pn_dashboard.Size = new System.Drawing.Size(200, 100);
            this.pn_dashboard.TabIndex = 1;
            // 
            // bt_Dashboard
            // 
            this.bt_Dashboard.Location = new System.Drawing.Point(0, -1);
            this.bt_Dashboard.Name = "bt_Dashboard";
            this.bt_Dashboard.Size = new System.Drawing.Size(197, 95);
            this.bt_Dashboard.TabIndex = 0;
            this.bt_Dashboard.Text = "Dashboard";
            this.bt_Dashboard.UseVisualStyleBackColor = true;
            this.bt_Dashboard.Click += new System.EventHandler(this.bt_Dashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // pn_manageShift
            // 
            this.pn_manageShift.BackColor = System.Drawing.Color.Fuchsia;
            this.pn_manageShift.Controls.Add(this.bt_ManageShift);
            this.pn_manageShift.Location = new System.Drawing.Point(5, 302);
            this.pn_manageShift.Name = "pn_manageShift";
            this.pn_manageShift.Size = new System.Drawing.Size(200, 100);
            this.pn_manageShift.TabIndex = 1;
            // 
            // bt_ManageShift
            // 
            this.bt_ManageShift.Location = new System.Drawing.Point(-2, 2);
            this.bt_ManageShift.Name = "bt_ManageShift";
            this.bt_ManageShift.Size = new System.Drawing.Size(197, 95);
            this.bt_ManageShift.TabIndex = 1;
            this.bt_ManageShift.Text = "Manage Shift";
            this.bt_ManageShift.UseVisualStyleBackColor = true;
            this.bt_ManageShift.Click += new System.EventHandler(this.bt_ManageShift_Click);
            // 
            // pn_manageAccount
            // 
            this.pn_manageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pn_manageAccount.Controls.Add(this.bt_ManageAccount);
            this.pn_manageAccount.Location = new System.Drawing.Point(2, 202);
            this.pn_manageAccount.Name = "pn_manageAccount";
            this.pn_manageAccount.Size = new System.Drawing.Size(200, 100);
            this.pn_manageAccount.TabIndex = 0;
            // 
            // bt_ManageAccount
            // 
            this.bt_ManageAccount.Location = new System.Drawing.Point(3, 0);
            this.bt_ManageAccount.Name = "bt_ManageAccount";
            this.bt_ManageAccount.Size = new System.Drawing.Size(197, 95);
            this.bt_ManageAccount.TabIndex = 1;
            this.bt_ManageAccount.Text = "Manage Account";
            this.bt_ManageAccount.UseVisualStyleBackColor = true;
            this.bt_ManageAccount.Click += new System.EventHandler(this.bt_ManageAccount_Click);
            // 
            // Manage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_main);
            this.Name = "Manage";
            this.Text = "Manage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.panel2.ResumeLayout(false);
            this.pn_statistics.ResumeLayout(false);
            this.pn_summarizeSalary.ResumeLayout(false);
            this.pn_dashboard.ResumeLayout(false);
            this.pn_manageShift.ResumeLayout(false);
            this.pn_manageAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pn_statistics;
        private System.Windows.Forms.Panel pn_summarizeSalary;
        private System.Windows.Forms.Panel pn_manageShift;
        private System.Windows.Forms.Panel pn_manageAccount;
        private System.Windows.Forms.Button bt_statistics;
        private System.Windows.Forms.Button bt_SummarizeSalary;
        private System.Windows.Forms.Button bt_Dashboard;
        private System.Windows.Forms.Button bt_ManageShift;
        private System.Windows.Forms.Button bt_ManageAccount;
    }
}