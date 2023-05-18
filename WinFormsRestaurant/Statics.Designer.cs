namespace WinFormsRestaurant
{
    partial class Statics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_salary = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_worktime = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_shift = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Controls.Add(this.bt_salary);
            this.panel5.Location = new System.Drawing.Point(357, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 50);
            this.panel5.TabIndex = 2;
            // 
            // bt_salary
            // 
            this.bt_salary.Location = new System.Drawing.Point(0, -1);
            this.bt_salary.Name = "bt_salary";
            this.bt_salary.Size = new System.Drawing.Size(355, 51);
            this.bt_salary.TabIndex = 1;
            this.bt_salary.Text = "Salary";
            this.bt_salary.UseVisualStyleBackColor = true;
            this.bt_salary.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.bt_worktime);
            this.panel6.Location = new System.Drawing.Point(713, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 50);
            this.panel6.TabIndex = 1;
            // 
            // bt_worktime
            // 
            this.bt_worktime.Location = new System.Drawing.Point(0, -1);
            this.bt_worktime.Name = "bt_worktime";
            this.bt_worktime.Size = new System.Drawing.Size(354, 51);
            this.bt_worktime.TabIndex = 2;
            this.bt_worktime.Text = "WorkTime";
            this.bt_worktime.UseVisualStyleBackColor = true;
            this.bt_worktime.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.bt_shift);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 50);
            this.panel2.TabIndex = 0;
            // 
            // bt_shift
            // 
            this.bt_shift.Location = new System.Drawing.Point(0, 0);
            this.bt_shift.Name = "bt_shift";
            this.bt_shift.Size = new System.Drawing.Size(356, 51);
            this.bt_shift.TabIndex = 0;
            this.bt_shift.Text = "Shift ";
            this.bt_shift.UseVisualStyleBackColor = true;
            this.bt_shift.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.White;
            this.pn_main.Location = new System.Drawing.Point(1, 52);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1070, 600);
            this.pn_main.TabIndex = 2;
            // 
            // Statics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1072, 653);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel1);
            this.Name = "Statics";
            this.Text = "Statics";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Button bt_salary;
        private System.Windows.Forms.Button bt_worktime;
        private System.Windows.Forms.Button bt_shift;
    }
}