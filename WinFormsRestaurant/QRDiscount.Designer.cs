namespace WinFormsRestaurant
{
    partial class QRDiscount
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
            this.pb_scan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scan)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_scan
            // 
            this.pb_scan.Location = new System.Drawing.Point(54, 42);
            this.pb_scan.Name = "pb_scan";
            this.pb_scan.Size = new System.Drawing.Size(490, 333);
            this.pb_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_scan.TabIndex = 0;
            this.pb_scan.TabStop = false;
            // 
            // QRDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 435);
            this.Controls.Add(this.pb_scan);
            this.Name = "QRDiscount";
            this.Text = "QRDiscount";
            this.Load += new System.EventHandler(this.QRDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_scan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_scan;
    }
}