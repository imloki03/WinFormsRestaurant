namespace WinFormsRestaurant
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_table = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_amountOfDiner = new System.Windows.Forms.TextBox();
            this.list_dishes = new System.Windows.Forms.DataGridView();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_order = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_dishes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table:";
            // 
            // lb_table
            // 
            this.lb_table.AutoSize = true;
            this.lb_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table.Location = new System.Drawing.Point(100, 19);
            this.lb_table.Name = "lb_table";
            this.lb_table.Size = new System.Drawing.Size(19, 20);
            this.lb_table.TabIndex = 1;
            this.lb_table.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of Diner:";
            // 
            // tb_amountOfDiner
            // 
            this.tb_amountOfDiner.Location = new System.Drawing.Point(160, 49);
            this.tb_amountOfDiner.Name = "tb_amountOfDiner";
            this.tb_amountOfDiner.Size = new System.Drawing.Size(125, 20);
            this.tb_amountOfDiner.TabIndex = 3;
            // 
            // list_dishes
            // 
            this.list_dishes.AllowUserToDeleteRows = false;
            this.list_dishes.AllowUserToResizeColumns = false;
            this.list_dishes.AllowUserToResizeRows = false;
            this.list_dishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dishes.Location = new System.Drawing.Point(34, 127);
            this.list_dishes.Name = "list_dishes";
            this.list_dishes.RowHeadersVisible = false;
            this.list_dishes.Size = new System.Drawing.Size(272, 275);
            this.list_dishes.TabIndex = 4;
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(126, 80);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(89, 34);
            this.bt_select.TabIndex = 5;
            this.bt_select.Text = "Select Dishes";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_order
            // 
            this.bt_order.Location = new System.Drawing.Point(84, 420);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(75, 33);
            this.bt_order.TabIndex = 6;
            this.bt_order.Text = "Order";
            this.bt_order.UseVisualStyleBackColor = true;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(182, 420);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 33);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 480);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.list_dishes);
            this.Controls.Add(this.tb_amountOfDiner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_table);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.list_dishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_amountOfDiner;
        private System.Windows.Forms.DataGridView list_dishes;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_order;
        private System.Windows.Forms.Button bt_cancel;
    }
}