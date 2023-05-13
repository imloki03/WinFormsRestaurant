namespace WinFormsRestaurant
{
    partial class ShiftManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.list_shift = new System.Windows.Forms.DataGridView();
            this.cb_dayRange = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_shift)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Hanzel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift Schedule";
            // 
            // list_shift
            // 
            this.list_shift.AllowUserToAddRows = false;
            this.list_shift.AllowUserToDeleteRows = false;
            this.list_shift.AllowUserToResizeColumns = false;
            this.list_shift.AllowUserToResizeRows = false;
            this.list_shift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_shift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.list_shift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_shift.DefaultCellStyle = dataGridViewCellStyle4;
            this.list_shift.Location = new System.Drawing.Point(32, 126);
            this.list_shift.Name = "list_shift";
            this.list_shift.Size = new System.Drawing.Size(1014, 475);
            this.list_shift.TabIndex = 2;
            // 
            // cb_dayRange
            // 
            this.cb_dayRange.FormattingEnabled = true;
            this.cb_dayRange.Location = new System.Drawing.Point(705, 71);
            this.cb_dayRange.Name = "cb_dayRange";
            this.cb_dayRange.Size = new System.Drawing.Size(172, 21);
            this.cb_dayRange.TabIndex = 3;
            this.cb_dayRange.SelectedIndexChanged += new System.EventHandler(this.cb_dayRange_SelectedIndexChanged);
            // 
            // ShiftManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.cb_dayRange);
            this.Controls.Add(this.list_shift);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1090, 700);
            this.MinimumSize = new System.Drawing.Size(1090, 700);
            this.Name = "ShiftManagement";
            this.Text = "ShiftManagement";
            this.Load += new System.EventHandler(this.ShiftManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_shift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView list_shift;
        private System.Windows.Forms.ComboBox cb_dayRange;
    }
}