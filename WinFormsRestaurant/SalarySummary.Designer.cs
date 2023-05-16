namespace WinFormsRestaurant
{
    partial class SalarySummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.list_salary = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // list_salary
            // 
            this.list_salary.AllowUserToAddRows = false;
            this.list_salary.AllowUserToDeleteRows = false;
            this.list_salary.AllowUserToResizeColumns = false;
            this.list_salary.AllowUserToResizeRows = false;
            this.list_salary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_salary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.list_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_salary.DefaultCellStyle = dataGridViewCellStyle4;
            this.list_salary.Location = new System.Drawing.Point(11, 52);
            this.list_salary.Margin = new System.Windows.Forms.Padding(2);
            this.list_salary.Name = "list_salary";
            this.list_salary.RowHeadersVisible = false;
            this.list_salary.RowHeadersWidth = 51;
            this.list_salary.RowTemplate.Height = 24;
            this.list_salary.Size = new System.Drawing.Size(940, 502);
            this.list_salary.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(229, 16);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(393, 20);
            this.tb_search.TabIndex = 1;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(650, 16);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // SalarySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 563);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.list_salary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalarySummary";
            this.Text = "SalarySummary";
            this.Load += new System.EventHandler(this.SalarySummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list_salary;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
    }
}