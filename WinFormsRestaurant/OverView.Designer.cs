namespace WinFormsRestaurant
{
    partial class OverView
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
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_birth = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_jobtitle = new System.Windows.Forms.Label();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_state = new System.Windows.Forms.PictureBox();
            this.lb_state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pb_state1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_state3 = new System.Windows.Forms.PictureBox();
            this.pb_state4 = new System.Windows.Forms.PictureBox();
            this.pb_state2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_checkin = new System.Windows.Forms.Button();
            this.bt_checkout = new System.Windows.Forms.Button();
            this.bt_changepassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::WinFormsRestaurant.Properties.Resources.logo_winforms_mini;
            this.pb_logo.Location = new System.Drawing.Point(4, 2);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(109, 75);
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // pb_avatar
            // 
            this.pb_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_avatar.Location = new System.Drawing.Point(137, 74);
            this.pb_avatar.Margin = new System.Windows.Forms.Padding(4);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(133, 157);
            this.pb_avatar.TabIndex = 2;
            this.pb_avatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "FullName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Job title:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(417, 74);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(210, 16);
            this.lb_fullname.TabIndex = 9;
            this.lb_fullname.Text = "_____________________________";
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Location = new System.Drawing.Point(417, 135);
            this.lb_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(210, 16);
            this.lb_birth.TabIndex = 10;
            this.lb_birth.Text = "_____________________________";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(417, 166);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(210, 16);
            this.lb_phone.TabIndex = 11;
            this.lb_phone.Text = "_____________________________";
            // 
            // lb_jobtitle
            // 
            this.lb_jobtitle.AutoSize = true;
            this.lb_jobtitle.Location = new System.Drawing.Point(417, 197);
            this.lb_jobtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_jobtitle.Name = "lb_jobtitle";
            this.lb_jobtitle.Size = new System.Drawing.Size(210, 16);
            this.lb_jobtitle.TabIndex = 12;
            this.lb_jobtitle.Text = "_____________________________";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(421, 105);
            this.rb_male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(58, 20);
            this.rb_male.TabIndex = 13;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(548, 105);
            this.rb_female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 14;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "State:";
            // 
            // pb_state
            // 
            this.pb_state.Location = new System.Drawing.Point(404, 235);
            this.pb_state.Margin = new System.Windows.Forms.Padding(4);
            this.pb_state.Name = "pb_state";
            this.pb_state.Size = new System.Drawing.Size(21, 20);
            this.pb_state.TabIndex = 16;
            this.pb_state.TabStop = false;
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(436, 239);
            this.lb_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(140, 16);
            this.lb_state.TabIndex = 17;
            this.lb_state.Text = "___________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Profile";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(949, 209);
            this.dataGridView1.TabIndex = 19;
            // 
            // pb_state1
            // 
            this.pb_state1.Location = new System.Drawing.Point(244, 511);
            this.pb_state1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_state1.Name = "pb_state1";
            this.pb_state1.Size = new System.Drawing.Size(21, 20);
            this.pb_state1.TabIndex = 20;
            this.pb_state1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 513);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Scheduled";
            // 
            // pb_state3
            // 
            this.pb_state3.Location = new System.Drawing.Point(548, 511);
            this.pb_state3.Margin = new System.Windows.Forms.Padding(4);
            this.pb_state3.Name = "pb_state3";
            this.pb_state3.Size = new System.Drawing.Size(21, 20);
            this.pb_state3.TabIndex = 22;
            this.pb_state3.TabStop = false;
            // 
            // pb_state4
            // 
            this.pb_state4.Location = new System.Drawing.Point(683, 511);
            this.pb_state4.Margin = new System.Windows.Forms.Padding(4);
            this.pb_state4.Name = "pb_state4";
            this.pb_state4.Size = new System.Drawing.Size(21, 20);
            this.pb_state4.TabIndex = 23;
            this.pb_state4.TabStop = false;
            // 
            // pb_state2
            // 
            this.pb_state2.Location = new System.Drawing.Point(404, 511);
            this.pb_state2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_state2.Name = "pb_state2";
            this.pb_state2.Size = new System.Drawing.Size(21, 20);
            this.pb_state2.TabIndex = 24;
            this.pb_state2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 511);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Part-time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Full-time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(707, 511);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Absent";
            // 
            // bt_checkin
            // 
            this.bt_checkin.Location = new System.Drawing.Point(292, 555);
            this.bt_checkin.Margin = new System.Windows.Forms.Padding(4);
            this.bt_checkin.Name = "bt_checkin";
            this.bt_checkin.Size = new System.Drawing.Size(133, 49);
            this.bt_checkin.TabIndex = 28;
            this.bt_checkin.Text = "Check-IN";
            this.bt_checkin.UseVisualStyleBackColor = true;
            this.bt_checkin.Click += new System.EventHandler(this.bt_checkin_Click);
            // 
            // bt_checkout
            // 
            this.bt_checkout.Location = new System.Drawing.Point(548, 555);
            this.bt_checkout.Margin = new System.Windows.Forms.Padding(4);
            this.bt_checkout.Name = "bt_checkout";
            this.bt_checkout.Size = new System.Drawing.Size(133, 49);
            this.bt_checkout.TabIndex = 29;
            this.bt_checkout.Text = "Check-OUT";
            this.bt_checkout.UseVisualStyleBackColor = true;
            this.bt_checkout.Click += new System.EventHandler(this.bt_checkout_Click);
            // 
            // bt_changepassword
            // 
            this.bt_changepassword.Location = new System.Drawing.Point(772, 27);
            this.bt_changepassword.Name = "bt_changepassword";
            this.bt_changepassword.Size = new System.Drawing.Size(165, 33);
            this.bt_changepassword.TabIndex = 30;
            this.bt_changepassword.Text = "Change Password";
            this.bt_changepassword.UseVisualStyleBackColor = true;
            this.bt_changepassword.Click += new System.EventHandler(this.bt_changepassword_Click);
            // 
            // OverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 626);
            this.Controls.Add(this.bt_changepassword);
            this.Controls.Add(this.bt_checkout);
            this.Controls.Add(this.bt_checkin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pb_state2);
            this.Controls.Add(this.pb_state4);
            this.Controls.Add(this.pb_state3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb_state1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.pb_state);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.lb_jobtitle);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_birth);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_avatar);
            this.Controls.Add(this.pb_logo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OverView";
            this.Text = "OverView";
            this.Load += new System.EventHandler(this.OverView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_state2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_state;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pb_state1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_state3;
        private System.Windows.Forms.PictureBox pb_state4;
        private System.Windows.Forms.PictureBox pb_state2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_checkin;
        private System.Windows.Forms.Button bt_checkout;
        private System.Windows.Forms.Button bt_changepassword;
        public System.Windows.Forms.PictureBox pb_avatar;
        public System.Windows.Forms.Label lb_fullname;
        public System.Windows.Forms.Label lb_birth;
        public System.Windows.Forms.Label lb_phone;
        public System.Windows.Forms.Label lb_jobtitle;
        public System.Windows.Forms.RadioButton rb_male;
        public System.Windows.Forms.RadioButton rb_female;
    }
}