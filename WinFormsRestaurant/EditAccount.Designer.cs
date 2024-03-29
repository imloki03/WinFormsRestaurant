﻿namespace WinFormsRestaurant
{
    partial class EditAccount
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
            this.pg_scan = new System.Windows.Forms.ProgressBar();
            this.bt_scan = new System.Windows.Forms.Button();
            this.pb_camera = new System.Windows.Forms.PictureBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.cb_ward = new System.Windows.Forms.ComboBox();
            this.cb_district = new System.Windows.Forms.ComboBox();
            this.cb_province = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_birthday = new System.Windows.Forms.DateTimePicker();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // pg_scan
            // 
            this.pg_scan.Location = new System.Drawing.Point(615, 538);
            this.pg_scan.Margin = new System.Windows.Forms.Padding(4);
            this.pg_scan.Name = "pg_scan";
            this.pg_scan.Size = new System.Drawing.Size(639, 28);
            this.pg_scan.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pg_scan.TabIndex = 45;
            // 
            // bt_scan
            // 
            this.bt_scan.Location = new System.Drawing.Point(855, 580);
            this.bt_scan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_scan.Name = "bt_scan";
            this.bt_scan.Size = new System.Drawing.Size(145, 50);
            this.bt_scan.TabIndex = 44;
            this.bt_scan.Text = "Scan";
            this.bt_scan.UseVisualStyleBackColor = true;
            this.bt_scan.Click += new System.EventHandler(this.bt_scan_Click);
            // 
            // pb_camera
            // 
            this.pb_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_camera.Location = new System.Drawing.Point(560, 135);
            this.pb_camera.Margin = new System.Windows.Forms.Padding(4);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(746, 387);
            this.pb_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_camera.TabIndex = 43;
            this.pb_camera.TabStop = false;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(308, 538);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(107, 43);
            this.bt_cancel.TabIndex = 42;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(165, 538);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(107, 43);
            this.bt_edit.TabIndex = 41;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // cb_ward
            // 
            this.cb_ward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ward.FormattingEnabled = true;
            this.cb_ward.Location = new System.Drawing.Point(152, 428);
            this.cb_ward.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ward.Name = "cb_ward";
            this.cb_ward.Size = new System.Drawing.Size(280, 24);
            this.cb_ward.TabIndex = 40;
            // 
            // cb_district
            // 
            this.cb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_district.FormattingEnabled = true;
            this.cb_district.Location = new System.Drawing.Point(152, 379);
            this.cb_district.Margin = new System.Windows.Forms.Padding(4);
            this.cb_district.Name = "cb_district";
            this.cb_district.Size = new System.Drawing.Size(280, 24);
            this.cb_district.TabIndex = 39;
            this.cb_district.SelectedIndexChanged += new System.EventHandler(this.cb_district_SelectedIndexChanged);
            // 
            // cb_province
            // 
            this.cb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_province.FormattingEnabled = true;
            this.cb_province.Location = new System.Drawing.Point(152, 330);
            this.cb_province.Margin = new System.Windows.Forms.Padding(4);
            this.cb_province.Name = "cb_province";
            this.cb_province.Size = new System.Drawing.Size(280, 24);
            this.cb_province.TabIndex = 38;
            this.cb_province.SelectedIndexChanged += new System.EventHandler(this.cb_province_SelectedIndexChanged);
            this.cb_province.Click += new System.EventHandler(this.cb_province_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ward:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "District:";
            // 
            // dt_birthday
            // 
            this.dt_birthday.CustomFormat = "dd/MM/yyyy";
            this.dt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_birthday.Location = new System.Drawing.Point(152, 229);
            this.dt_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dt_birthday.MaximumSize = new System.Drawing.Size(399, 24);
            this.dt_birthday.MinimumSize = new System.Drawing.Size(65, 24);
            this.dt_birthday.Name = "dt_birthday";
            this.dt_birthday.Size = new System.Drawing.Size(144, 24);
            this.dt_birthday.TabIndex = 35;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(295, 183);
            this.rb_female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 34;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(152, 183);
            this.rb_male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(58, 20);
            this.rb_male.TabIndex = 33;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // tb_street
            // 
            this.tb_street.Location = new System.Drawing.Point(152, 474);
            this.tb_street.Margin = new System.Windows.Forms.Padding(4);
            this.tb_street.Multiline = true;
            this.tb_street.Name = "tb_street";
            this.tb_street.Size = new System.Drawing.Size(280, 29);
            this.tb_street.TabIndex = 32;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(152, 277);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(280, 29);
            this.tb_phone.TabIndex = 31;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(152, 133);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(280, 29);
            this.tb_name.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Street:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Province:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Edit Employee Information";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 804);
            this.Controls.Add(this.pg_scan);
            this.Controls.Add(this.bt_scan);
            this.Controls.Add(this.pb_camera);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.cb_ward);
            this.Controls.Add(this.cb_district);
            this.Controls.Add(this.cb_province);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_birthday);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.tb_street);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1447, 851);
            this.MinimumSize = new System.Drawing.Size(1447, 851);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar pg_scan;
        public System.Windows.Forms.Button bt_scan;
        public System.Windows.Forms.PictureBox pb_camera;
        public System.Windows.Forms.Button bt_cancel;
        public System.Windows.Forms.Button bt_edit;
        public System.Windows.Forms.ComboBox cb_ward;
        public System.Windows.Forms.ComboBox cb_district;
        public System.Windows.Forms.ComboBox cb_province;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dt_birthday;
        public System.Windows.Forms.RadioButton rb_female;
        public System.Windows.Forms.RadioButton rb_male;
        public System.Windows.Forms.TextBox tb_street;
        public System.Windows.Forms.TextBox tb_phone;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}