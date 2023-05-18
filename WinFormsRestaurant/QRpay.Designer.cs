namespace WinFormsRestaurant
{
    partial class QRpay
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
            this.pb_qr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_printtime = new System.Windows.Forms.Label();
            this.lb_billnumber = new System.Windows.Forms.Label();
            this.lb_bank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_qr
            // 
            this.pb_qr.Location = new System.Drawing.Point(155, 23);
            this.pb_qr.Name = "pb_qr";
            this.pb_qr.Size = new System.Drawing.Size(318, 241);
            this.pb_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_qr.TabIndex = 0;
            this.pb_qr.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Ammount";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_money.Location = new System.Drawing.Point(277, 315);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(65, 32);
            this.lb_money.TabIndex = 3;
            this.lb_money.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Banking Via";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bill Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Print Time";
            // 
            // lb_printtime
            // 
            this.lb_printtime.AutoSize = true;
            this.lb_printtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_printtime.Location = new System.Drawing.Point(379, 457);
            this.lb_printtime.Name = "lb_printtime";
            this.lb_printtime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_printtime.Size = new System.Drawing.Size(100, 25);
            this.lb_printtime.TabIndex = 9;
            this.lb_printtime.Text = "Print Time";
            this.lb_printtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_billnumber
            // 
            this.lb_billnumber.AutoSize = true;
            this.lb_billnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billnumber.Location = new System.Drawing.Point(378, 423);
            this.lb_billnumber.Name = "lb_billnumber";
            this.lb_billnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_billnumber.Size = new System.Drawing.Size(111, 25);
            this.lb_billnumber.TabIndex = 8;
            this.lb_billnumber.Text = "Bill Number";
            this.lb_billnumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_bank
            // 
            this.lb_bank.AutoSize = true;
            this.lb_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bank.Location = new System.Drawing.Point(465, 389);
            this.lb_bank.Name = "lb_bank";
            this.lb_bank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_bank.Size = new System.Drawing.Size(78, 25);
            this.lb_bank.TabIndex = 7;
            this.lb_bank.Text = "MOMO";
            // 
            // QRpay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 499);
            this.Controls.Add(this.lb_printtime);
            this.Controls.Add(this.lb_billnumber);
            this.Controls.Add(this.lb_bank);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_qr);
            this.Name = "QRpay";
            this.Text = "QRpay";
            this.Load += new System.EventHandler(this.QRpay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_qr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lb_printtime;
        public System.Windows.Forms.Label lb_billnumber;
        public System.Windows.Forms.Label lb_bank;
    }
}