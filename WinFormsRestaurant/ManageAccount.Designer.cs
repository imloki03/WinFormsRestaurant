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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_manageAccount = new System.Windows.Forms.Panel();
            this.list_account = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_manageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_account)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_manageAccount
            // 
            this.pn_manageAccount.Controls.Add(this.list_account);
            this.pn_manageAccount.Controls.Add(this.bt_delete);
            this.pn_manageAccount.Controls.Add(this.bt_edit);
            this.pn_manageAccount.Controls.Add(this.bt_add);
            this.pn_manageAccount.Controls.Add(this.bt_search);
            this.pn_manageAccount.Controls.Add(this.tb_search);
            this.pn_manageAccount.Controls.Add(this.label1);
            this.pn_manageAccount.Location = new System.Drawing.Point(1, -1);
            this.pn_manageAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_manageAccount.Name = "pn_manageAccount";
            this.pn_manageAccount.Size = new System.Drawing.Size(1431, 817);
            this.pn_manageAccount.TabIndex = 0;
            // 
            // list_account
            // 
            this.list_account.AllowUserToAddRows = false;
            this.list_account.AllowUserToDeleteRows = false;
            this.list_account.AllowUserToResizeColumns = false;
            this.list_account.AllowUserToResizeRows = false;
            this.list_account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.list_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_account.DefaultCellStyle = dataGridViewCellStyle2;
            this.list_account.Location = new System.Drawing.Point(51, 116);
            this.list_account.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_account.Name = "list_account";
            this.list_account.RowHeadersVisible = false;
            this.list_account.RowHeadersWidth = 51;
            this.list_account.Size = new System.Drawing.Size(1097, 655);
            this.list_account.TabIndex = 14;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(1175, 231);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(153, 50);
            this.bt_delete.TabIndex = 13;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(1175, 174);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(153, 50);
            this.bt_edit.TabIndex = 12;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(1175, 116);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(153, 50);
            this.bt_add.TabIndex = 11;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(1027, 58);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(121, 39);
            this.bt_search.TabIndex = 9;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(52, 64);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(965, 26);
            this.tb_search.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Account:";
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 804);
            this.Controls.Add(this.pn_manageAccount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1447, 851);
            this.MinimumSize = new System.Drawing.Size(1447, 851);
            this.Name = "ManageAccount";
            this.Text = "ManageAccount";
            this.Load += new System.EventHandler(this.ManageAccount_Load);
            this.pn_manageAccount.ResumeLayout(false);
            this.pn_manageAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_manageAccount;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView list_account;
    }
}