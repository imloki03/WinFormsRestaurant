namespace WinFormsRestaurant
{
    partial class CheckIN_OUT
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
            this.pb_camera = new System.Windows.Forms.PictureBox();
            this.lb_notification = new System.Windows.Forms.Label();
            this.pb_checkin_out = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_camera
            // 
            this.pb_camera.Location = new System.Drawing.Point(19, 13);
            this.pb_camera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(777, 415);
            this.pb_camera.TabIndex = 0;
            this.pb_camera.TabStop = false;
            // 
            // lb_notification
            // 
            this.lb_notification.AutoSize = true;
            this.lb_notification.Location = new System.Drawing.Point(76, 506);
            this.lb_notification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_notification.Name = "lb_notification";
            this.lb_notification.Size = new System.Drawing.Size(65, 16);
            this.lb_notification.TabIndex = 1;
            this.lb_notification.Text = "label_noti";
            // 
            // pb_checkin_out
            // 
            this.pb_checkin_out.Location = new System.Drawing.Point(80, 449);
            this.pb_checkin_out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_checkin_out.Name = "pb_checkin_out";
            this.pb_checkin_out.Size = new System.Drawing.Size(645, 28);
            this.pb_checkin_out.TabIndex = 2;
            // 
            // CheckIN_OUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 551);
            this.Controls.Add(this.pb_checkin_out);
            this.Controls.Add(this.lb_notification);
            this.Controls.Add(this.pb_camera);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckIN_OUT";
            this.Text = "CheckIN_OUT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckIN_OUT_FormClosing);
            this.Load += new System.EventHandler(this.CheckIN_OUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_camera;
        private System.Windows.Forms.Label lb_notification;
        private System.Windows.Forms.ProgressBar pb_checkin_out;
    }
}