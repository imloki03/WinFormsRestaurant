namespace WinFormsRestaurant
{
    partial class AddNewAccount
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.dt_birthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_province = new System.Windows.Forms.ComboBox();
            this.cb_district = new System.Windows.Forms.ComboBox();
            this.cb_ward = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.pb_camera = new System.Windows.Forms.PictureBox();
            this.bt_scan = new System.Windows.Forms.Button();
            this.pg_scan = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Province:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(114, 108);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(211, 24);
            this.tb_name.TabIndex = 7;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(114, 225);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(211, 24);
            this.tb_phone.TabIndex = 8;
            // 
            // tb_street
            // 
            this.tb_street.Location = new System.Drawing.Point(114, 385);
            this.tb_street.Multiline = true;
            this.tb_street.Name = "tb_street";
            this.tb_street.Size = new System.Drawing.Size(211, 24);
            this.tb_street.TabIndex = 9;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(114, 149);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 10;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(221, 149);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 11;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // dt_birthday
            // 
            this.dt_birthday.CustomFormat = "dd/MM/yyyy";
            this.dt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_birthday.Location = new System.Drawing.Point(114, 186);
            this.dt_birthday.MaximumSize = new System.Drawing.Size(300, 24);
            this.dt_birthday.MinimumSize = new System.Drawing.Size(50, 24);
            this.dt_birthday.Name = "dt_birthday";
            this.dt_birthday.Size = new System.Drawing.Size(109, 24);
            this.dt_birthday.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "District:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ward:";
            // 
            // cb_province
            // 
            this.cb_province.FormattingEnabled = true;
            this.cb_province.Location = new System.Drawing.Point(114, 268);
            this.cb_province.Name = "cb_province";
            this.cb_province.Size = new System.Drawing.Size(211, 21);
            this.cb_province.TabIndex = 15;
            this.cb_province.SelectedIndexChanged += new System.EventHandler(this.cb_province_SelectedIndexChanged);
            this.cb_province.Click += new System.EventHandler(this.cb_province_Click);
            // 
            // cb_district
            // 
            this.cb_district.FormattingEnabled = true;
            this.cb_district.Location = new System.Drawing.Point(114, 308);
            this.cb_district.Name = "cb_district";
            this.cb_district.Size = new System.Drawing.Size(211, 21);
            this.cb_district.TabIndex = 16;
            this.cb_district.SelectedIndexChanged += new System.EventHandler(this.cb_district_SelectedIndexChanged);
            // 
            // cb_ward
            // 
            this.cb_ward.FormattingEnabled = true;
            this.cb_ward.Location = new System.Drawing.Point(114, 348);
            this.cb_ward.Name = "cb_ward";
            this.cb_ward.Size = new System.Drawing.Size(211, 21);
            this.cb_ward.TabIndex = 17;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(124, 437);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(80, 35);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(231, 437);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(80, 35);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // pb_camera
            // 
            this.pb_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_camera.Location = new System.Drawing.Point(420, 110);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(560, 315);
            this.pb_camera.TabIndex = 20;
            this.pb_camera.TabStop = false;
            // 
            // bt_scan
            // 
            this.bt_scan.Location = new System.Drawing.Point(641, 471);
            this.bt_scan.Name = "bt_scan";
            this.bt_scan.Size = new System.Drawing.Size(109, 41);
            this.bt_scan.TabIndex = 21;
            this.bt_scan.Text = "Scan";
            this.bt_scan.UseVisualStyleBackColor = true;
            // 
            // pg_scan
            // 
            this.pg_scan.Location = new System.Drawing.Point(461, 437);
            this.pg_scan.Name = "pg_scan";
            this.pg_scan.Size = new System.Drawing.Size(479, 23);
            this.pg_scan.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pg_scan.TabIndex = 22;
            // 
            // AddNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.pg_scan);
            this.Controls.Add(this.bt_scan);
            this.Controls.Add(this.pb_camera);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
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
            this.MaximumSize = new System.Drawing.Size(1090, 700);
            this.MinimumSize = new System.Drawing.Size(1090, 700);
            this.Name = "AddNewAccount";
            this.Text = "AddNewAccount";
            this.Load += new System.EventHandler(this.AddNewAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_street;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.DateTimePicker dt_birthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_province;
        private System.Windows.Forms.ComboBox cb_district;
        private System.Windows.Forms.ComboBox cb_ward;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.PictureBox pb_camera;
        private System.Windows.Forms.Button bt_scan;
        private System.Windows.Forms.ProgressBar pg_scan;
    }
}