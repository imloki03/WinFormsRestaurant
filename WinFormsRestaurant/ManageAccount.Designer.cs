namespace WinFormsRestaurant
{
    partial class ManageAccount
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
            this.pn_manageAccount = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.lv_account = new System.Windows.Forms.ListView();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_manageAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_manageAccount
            // 
            this.pn_manageAccount.Controls.Add(this.bt_delete);
            this.pn_manageAccount.Controls.Add(this.bt_edit);
            this.pn_manageAccount.Controls.Add(this.bt_add);
            this.pn_manageAccount.Controls.Add(this.lv_account);
            this.pn_manageAccount.Controls.Add(this.bt_search);
            this.pn_manageAccount.Controls.Add(this.tb_search);
            this.pn_manageAccount.Controls.Add(this.label1);
            this.pn_manageAccount.Location = new System.Drawing.Point(1, -1);
            this.pn_manageAccount.Name = "pn_manageAccount";
            this.pn_manageAccount.Size = new System.Drawing.Size(1073, 664);
            this.pn_manageAccount.TabIndex = 0;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(881, 188);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(115, 41);
            this.bt_delete.TabIndex = 13;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(881, 141);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(115, 41);
            this.bt_edit.TabIndex = 12;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(881, 94);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(115, 41);
            this.bt_add.TabIndex = 11;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lv_account
            // 
            this.lv_account.HideSelection = false;
            this.lv_account.Location = new System.Drawing.Point(39, 94);
            this.lv_account.Name = "lv_account";
            this.lv_account.Size = new System.Drawing.Size(822, 541);
            this.lv_account.TabIndex = 10;
            this.lv_account.UseCompatibleStateImageBehavior = false;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(770, 47);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(91, 32);
            this.bt_search.TabIndex = 9;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(39, 52);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(725, 22);
            this.tb_search.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Account:";
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.pn_manageAccount);
            this.MaximumSize = new System.Drawing.Size(1090, 700);
            this.MinimumSize = new System.Drawing.Size(1090, 700);
            this.Name = "ManageAccount";
            this.Text = "ManageAccount";
            this.pn_manageAccount.ResumeLayout(false);
            this.pn_manageAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_manageAccount;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ListView lv_account;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
    }
}