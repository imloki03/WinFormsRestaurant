namespace WinFormsRestaurant
{
    partial class Reciept
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_table = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.dv_bill = new System.Windows.Forms.DataGridView();
            this.lb_cashier = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_bilnumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_scanqr = new System.Windows.Forms.Button();
            this.bt_qrpay = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.bt_cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "WINFORMS RESTAURANT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address : 01 Vo Van Ngan, Linh Chieu, Thu Duc, \r\nThanh pho Ho Chi Minh, Viet Nam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "ORDER RECEIPT";
            // 
            // lb_table
            // 
            this.lb_table.AutoSize = true;
            this.lb_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table.Location = new System.Drawing.Point(183, 181);
            this.lb_table.Name = "lb_table";
            this.lb_table.Size = new System.Drawing.Size(61, 22);
            this.lb_table.TabIndex = 5;
            this.lb_table.Text = "Table";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(46, 216);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(36, 16);
            this.lb_date.TabIndex = 6;
            this.lb_date.Text = "Date";
            // 
            // dv_bill
            // 
            this.dv_bill.AllowUserToAddRows = false;
            this.dv_bill.AllowUserToDeleteRows = false;
            this.dv_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_bill.Location = new System.Drawing.Point(30, 295);
            this.dv_bill.Name = "dv_bill";
            this.dv_bill.ReadOnly = true;
            this.dv_bill.RowHeadersVisible = false;
            this.dv_bill.RowHeadersWidth = 51;
            this.dv_bill.RowTemplate.Height = 24;
            this.dv_bill.Size = new System.Drawing.Size(371, 154);
            this.dv_bill.TabIndex = 7;
            // 
            // lb_cashier
            // 
            this.lb_cashier.AutoSize = true;
            this.lb_cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cashier.Location = new System.Drawing.Point(46, 260);
            this.lb_cashier.Name = "lb_cashier";
            this.lb_cashier.Size = new System.Drawing.Size(53, 16);
            this.lb_cashier.TabIndex = 8;
            this.lb_cashier.Text = "Cashier";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(293, 260);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(38, 16);
            this.lb_time.TabIndex = 9;
            this.lb_time.Text = "Time";
            // 
            // lb_bilnumber
            // 
            this.lb_bilnumber.AutoSize = true;
            this.lb_bilnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bilnumber.Location = new System.Drawing.Point(293, 216);
            this.lb_bilnumber.Name = "lb_bilnumber";
            this.lb_bilnumber.Size = new System.Drawing.Size(56, 16);
            this.lb_bilnumber.TabIndex = 10;
            this.lb_bilnumber.Text = "Bill Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total:";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_money.Location = new System.Drawing.Point(333, 467);
            this.lb_money.Name = "lb_money";
            this.lb_money.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_money.Size = new System.Drawing.Size(68, 22);
            this.lb_money.TabIndex = 12;
            this.lb_money.Text = "Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thank You So Much. See You Again!!";
            // 
            // bt_scanqr
            // 
            this.bt_scanqr.BackColor = System.Drawing.Color.Transparent;
            this.bt_scanqr.BackgroundImage = global::WinFormsRestaurant.Properties.Resources.Voucher;
            this.bt_scanqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_scanqr.FlatAppearance.BorderSize = 0;
            this.bt_scanqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_scanqr.Location = new System.Drawing.Point(240, 519);
            this.bt_scanqr.Name = "bt_scanqr";
            this.bt_scanqr.Size = new System.Drawing.Size(75, 49);
            this.bt_scanqr.TabIndex = 15;
            this.bt_scanqr.UseVisualStyleBackColor = false;
            this.bt_scanqr.Click += new System.EventHandler(this.bt_scanqr_Click);
            // 
            // bt_qrpay
            // 
            this.bt_qrpay.BackColor = System.Drawing.Color.Transparent;
            this.bt_qrpay.BackgroundImage = global::WinFormsRestaurant.Properties.Resources.MoMo_Logo;
            this.bt_qrpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_qrpay.FlatAppearance.BorderSize = 0;
            this.bt_qrpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_qrpay.Location = new System.Drawing.Point(113, 498);
            this.bt_qrpay.Name = "bt_qrpay";
            this.bt_qrpay.Size = new System.Drawing.Size(90, 90);
            this.bt_qrpay.TabIndex = 14;
            this.bt_qrpay.UseVisualStyleBackColor = false;
            this.bt_qrpay.Click += new System.EventHandler(this.bt_qrpay_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::WinFormsRestaurant.Properties.Resources.logo_winforms_mini;
            this.pb_logo.Location = new System.Drawing.Point(13, 47);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(109, 75);
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // bt_cancle
            // 
            this.bt_cancle.BackColor = System.Drawing.Color.Red;
            this.bt_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancle.Location = new System.Drawing.Point(333, 5);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(92, 39);
            this.bt_cancle.TabIndex = 16;
            this.bt_cancle.Text = "X";
            this.bt_cancle.UseVisualStyleBackColor = false;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 664);
            this.Controls.Add(this.bt_cancle);
            this.Controls.Add(this.bt_scanqr);
            this.Controls.Add(this.bt_qrpay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_bilnumber);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_cashier);
            this.Controls.Add(this.dv_bill);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reciept";
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.Reciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_table;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.DataGridView dv_bill;
        private System.Windows.Forms.Label lb_cashier;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_bilnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_qrpay;
        private System.Windows.Forms.Button bt_scanqr;
        public System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.Button bt_cancle;
    }
}