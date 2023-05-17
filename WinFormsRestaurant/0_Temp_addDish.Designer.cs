namespace WinFormsRestaurant
{
    partial class _0_Temp_addDish
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
            this.pic_picture = new System.Windows.Forms.PictureBox();
            this.bt_upload = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_picture
            // 
            this.pic_picture.Location = new System.Drawing.Point(161, 115);
            this.pic_picture.Name = "pic_picture";
            this.pic_picture.Size = new System.Drawing.Size(100, 50);
            this.pic_picture.TabIndex = 0;
            this.pic_picture.TabStop = false;
            // 
            // bt_upload
            // 
            this.bt_upload.Location = new System.Drawing.Point(170, 142);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(41, 23);
            this.bt_upload.TabIndex = 1;
            this.bt_upload.Text = "up";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(217, 238);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 2;
            this.bt_update.Text = "update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // _0_Temp_addDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.pic_picture);
            this.Name = "_0_Temp_addDish";
            this.Text = "_0_Temp_addDish";
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_picture;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.Button bt_update;
    }
}