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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pb_logo.Location = new System.Drawing.Point(3, 2);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(82, 61);
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(103, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FullName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Job title:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(313, 60);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(181, 13);
            this.lb_fullname.TabIndex = 9;
            this.lb_fullname.Text = "_____________________________";
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.Location = new System.Drawing.Point(313, 110);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(181, 13);
            this.lb_birth.TabIndex = 10;
            this.lb_birth.Text = "_____________________________";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(313, 135);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(181, 13);
            this.lb_phone.TabIndex = 11;
            this.lb_phone.Text = "_____________________________";
            // 
            // lb_jobtitle
            // 
            this.lb_jobtitle.AutoSize = true;
            this.lb_jobtitle.Location = new System.Drawing.Point(313, 160);
            this.lb_jobtitle.Name = "lb_jobtitle";
            this.lb_jobtitle.Size = new System.Drawing.Size(181, 13);
            this.lb_jobtitle.TabIndex = 12;
            this.lb_jobtitle.Text = "_____________________________";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(316, 85);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 13;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(411, 85);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 14;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "State:";
            // 
            // pb_state
            // 
            this.pb_state.Location = new System.Drawing.Point(303, 191);
            this.pb_state.Name = "pb_state";
            this.pb_state.Size = new System.Drawing.Size(16, 16);
            this.pb_state.TabIndex = 16;
            this.pb_state.TabStop = false;
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(327, 194);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(121, 13);
            this.lb_state.TabIndex = 17;
            this.lb_state.Text = "___________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Loko", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "ProFile";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 170);
            this.dataGridView1.TabIndex = 19;
            // 
            // pb_state1
            // 
            this.pb_state1.Location = new System.Drawing.Point(183, 415);
            this.pb_state1.Name = "pb_state1";
            this.pb_state1.Size = new System.Drawing.Size(16, 16);
            this.pb_state1.TabIndex = 20;
            this.pb_state1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Scheduled";
            // 
            // pb_state3
            // 
            this.pb_state3.Location = new System.Drawing.Point(411, 415);
            this.pb_state3.Name = "pb_state3";
            this.pb_state3.Size = new System.Drawing.Size(16, 16);
            this.pb_state3.TabIndex = 22;
            this.pb_state3.TabStop = false;
            // 
            // pb_state4
            // 
            this.pb_state4.Location = new System.Drawing.Point(512, 415);
            this.pb_state4.Name = "pb_state4";
            this.pb_state4.Size = new System.Drawing.Size(16, 16);
            this.pb_state4.TabIndex = 23;
            this.pb_state4.TabStop = false;
            // 
            // pb_state2
            // 
            this.pb_state2.Location = new System.Drawing.Point(303, 415);
            this.pb_state2.Name = "pb_state2";
            this.pb_state2.Size = new System.Drawing.Size(16, 16);
            this.pb_state2.TabIndex = 24;
            this.pb_state2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Part-time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Full-time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Absent";
            // 
            // bt_checkin
            // 
            this.bt_checkin.Location = new System.Drawing.Point(219, 451);
            this.bt_checkin.Name = "bt_checkin";
            this.bt_checkin.Size = new System.Drawing.Size(100, 40);
            this.bt_checkin.TabIndex = 28;
            this.bt_checkin.Text = "Check-IN";
            this.bt_checkin.UseVisualStyleBackColor = true;
            // 
            // bt_checkout
            // 
            this.bt_checkout.Location = new System.Drawing.Point(411, 451);
            this.bt_checkout.Name = "bt_checkout";
            this.bt_checkout.Size = new System.Drawing.Size(100, 40);
            this.bt_checkout.TabIndex = 29;
            this.bt_checkout.Text = "Check-OUT";
            this.bt_checkout.UseVisualStyleBackColor = true;
            // 
            // OverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 509);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_logo);
            this.Name = "OverView";
            this.Text = "OverView";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_birth;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_jobtitle;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
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
    }
}