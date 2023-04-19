namespace WinFormsRestaurant
{
    partial class ChangePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_currentpassword = new System.Windows.Forms.TextBox();
            this.tb_newpassword = new System.Windows.Forms.TextBox();
            this.tb_confirmpassword = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password:";
            // 
            // tb_currentpassword
            // 
            this.tb_currentpassword.Location = new System.Drawing.Point(143, 82);
            this.tb_currentpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_currentpassword.Name = "tb_currentpassword";
            this.tb_currentpassword.Size = new System.Drawing.Size(212, 22);
            this.tb_currentpassword.TabIndex = 4;
            // 
            // tb_newpassword
            // 
            this.tb_newpassword.Location = new System.Drawing.Point(143, 126);
            this.tb_newpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_newpassword.Name = "tb_newpassword";
            this.tb_newpassword.Size = new System.Drawing.Size(212, 22);
            this.tb_newpassword.TabIndex = 5;
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.Location = new System.Drawing.Point(143, 167);
            this.tb_confirmpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.Size = new System.Drawing.Size(212, 22);
            this.tb_confirmpassword.TabIndex = 6;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(127, 214);
            this.bt_submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(120, 42);
            this.bt_submit.TabIndex = 7;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 278);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_confirmpassword);
            this.Controls.Add(this.tb_newpassword);
            this.Controls.Add(this.tb_currentpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_currentpassword;
        private System.Windows.Forms.TextBox tb_newpassword;
        private System.Windows.Forms.TextBox tb_confirmpassword;
        private System.Windows.Forms.Button bt_submit;
    }
}