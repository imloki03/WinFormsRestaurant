namespace WinFormsRestaurant
{
    partial class SelectDishes
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
            this.bt_food = new System.Windows.Forms.Button();
            this.bt_drink = new System.Windows.Forms.Button();
            this.pn_dish = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_food
            // 
            this.bt_food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.bt_food.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_food.FlatAppearance.BorderSize = 2;
            this.bt_food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_food.Location = new System.Drawing.Point(18, 19);
            this.bt_food.Name = "bt_food";
            this.bt_food.Size = new System.Drawing.Size(93, 30);
            this.bt_food.TabIndex = 3;
            this.bt_food.Text = "Food";
            this.bt_food.UseVisualStyleBackColor = false;
            this.bt_food.Click += new System.EventHandler(this.bt_food_Click);
            // 
            // bt_drink
            // 
            this.bt_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.bt_drink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_drink.FlatAppearance.BorderSize = 2;
            this.bt_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_drink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_drink.Location = new System.Drawing.Point(109, 19);
            this.bt_drink.Name = "bt_drink";
            this.bt_drink.Size = new System.Drawing.Size(93, 30);
            this.bt_drink.TabIndex = 4;
            this.bt_drink.Text = "Drink";
            this.bt_drink.UseVisualStyleBackColor = false;
            this.bt_drink.Click += new System.EventHandler(this.bt_drink_Click);
            // 
            // pn_dish
            // 
            this.pn_dish.AutoScroll = true;
            this.pn_dish.BackColor = System.Drawing.SystemColors.Control;
            this.pn_dish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_dish.Location = new System.Drawing.Point(18, 49);
            this.pn_dish.Name = "pn_dish";
            this.pn_dish.Size = new System.Drawing.Size(765, 430);
            this.pn_dish.TabIndex = 5;
            // 
            // bt_order
            // 
            this.bt_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(203)))));
            this.bt_order.FlatAppearance.BorderSize = 2;
            this.bt_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_order.Location = new System.Drawing.Point(689, 10);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(93, 30);
            this.bt_order.TabIndex = 6;
            this.bt_order.Text = "Order";
            this.bt_order.UseVisualStyleBackColor = false;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // SelectDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.pn_dish);
            this.Controls.Add(this.bt_drink);
            this.Controls.Add(this.bt_food);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectDishes";
            this.Text = "SelectDishes";
            this.Load += new System.EventHandler(this.SelectDishes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_food;
        private System.Windows.Forms.Button bt_drink;
        public System.Windows.Forms.FlowLayoutPanel pn_dish;
        private System.Windows.Forms.Button bt_order;
    }
}