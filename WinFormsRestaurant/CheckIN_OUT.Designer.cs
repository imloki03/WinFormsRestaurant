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
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_camera
            // 
            this.pb_camera.Location = new System.Drawing.Point(15, 13);
            this.pb_camera.Margin = new System.Windows.Forms.Padding(4);
            this.pb_camera.Name = "pb_camera";
            this.pb_camera.Size = new System.Drawing.Size(777, 415);
            this.pb_camera.TabIndex = 0;
            this.pb_camera.TabStop = false;
            // 
            // CheckIN_OUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 435);
            this.Controls.Add(this.pb_camera);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckIN_OUT";
            this.Text = "CheckIN_OUT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckIN_OUT_FormClosing);
            this.Load += new System.EventHandler(this.CheckIN_OUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_camera;
    }
}