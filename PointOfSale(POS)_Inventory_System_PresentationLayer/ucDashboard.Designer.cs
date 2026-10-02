namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class ucDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblWeeks = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActionRequired = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblStockWarning = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSalesTodayImprovementPrecentage = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnQuickViewUsers = new System.Windows.Forms.Button();
            this.btnQuickProcessSale = new System.Windows.Forms.Button();
            this.btnQuickAddNewProduct = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstvwActivity = new System.Windows.Forms.ListView();
            this.colHeadRecentSalesFeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblWeeks);
            this.panel1.Controls.Add(this.lblTotalProducts);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 102);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageKey = "package.png";
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 64);
            this.label4.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Warning.png");
            this.imageList1.Images.SetKeyName(1, "package.png");
            this.imageList1.Images.SetKeyName(2, "coin.png");
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeks.ForeColor = System.Drawing.Color.White;
            this.lblWeeks.Location = new System.Drawing.Point(83, 80);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(0, 16);
            this.lblWeeks.TabIndex = 2;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.White;
            this.lblTotalProducts.Location = new System.Drawing.Point(81, 46);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(66, 25);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "1,245";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(82, 16);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(111, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Total Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblActionRequired);
            this.panel2.Controls.Add(this.lblStockAmount);
            this.panel2.Controls.Add(this.lblStockWarning);
            this.panel2.Location = new System.Drawing.Point(270, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 102);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageKey = "Warning.png";
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 64);
            this.label5.TabIndex = 3;
            // 
            // lblActionRequired
            // 
            this.lblActionRequired.AutoSize = true;
            this.lblActionRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionRequired.ForeColor = System.Drawing.Color.White;
            this.lblActionRequired.Location = new System.Drawing.Point(83, 80);
            this.lblActionRequired.Name = "lblActionRequired";
            this.lblActionRequired.Size = new System.Drawing.Size(103, 16);
            this.lblActionRequired.TabIndex = 2;
            this.lblActionRequired.Text = "Action Required";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAmount.ForeColor = System.Drawing.Color.White;
            this.lblStockAmount.Location = new System.Drawing.Point(81, 46);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(36, 25);
            this.lblStockAmount.TabIndex = 1;
            this.lblStockAmount.Text = "20";
            // 
            // lblStockWarning
            // 
            this.lblStockWarning.AutoSize = true;
            this.lblStockWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWarning.ForeColor = System.Drawing.Color.White;
            this.lblStockWarning.Location = new System.Drawing.Point(82, 16);
            this.lblStockWarning.Name = "lblStockWarning";
            this.lblStockWarning.Size = new System.Drawing.Size(127, 20);
            this.lblStockWarning.TabIndex = 0;
            this.lblStockWarning.Text = "Low Stock Items";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblSalesTodayImprovementPrecentage);
            this.panel3.Controls.Add(this.lblTotalSales);
            this.panel3.Controls.Add(this.lblTodaySales);
            this.panel3.Location = new System.Drawing.Point(524, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 102);
            this.panel3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageKey = "coin.png";
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(9, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 64);
            this.label9.TabIndex = 3;
            // 
            // lblSalesTodayImprovementPrecentage
            // 
            this.lblSalesTodayImprovementPrecentage.AutoSize = true;
            this.lblSalesTodayImprovementPrecentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTodayImprovementPrecentage.ForeColor = System.Drawing.Color.White;
            this.lblSalesTodayImprovementPrecentage.Location = new System.Drawing.Point(83, 80);
            this.lblSalesTodayImprovementPrecentage.Name = "lblSalesTodayImprovementPrecentage";
            this.lblSalesTodayImprovementPrecentage.Size = new System.Drawing.Size(0, 16);
            this.lblSalesTodayImprovementPrecentage.TabIndex = 2;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(81, 46);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(108, 25);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "$3,450.75";
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.White;
            this.lblTodaySales.Location = new System.Drawing.Point(82, 16);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(107, 20);
            this.lblTodaySales.TabIndex = 0;
            this.lblTodaySales.Text = "Today\'s Sales";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnQuickViewUsers);
            this.panel4.Controls.Add(this.btnQuickProcessSale);
            this.panel4.Controls.Add(this.btnQuickAddNewProduct);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(15, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 162);
            this.panel4.TabIndex = 4;
            // 
            // btnQuickViewUsers
            // 
            this.btnQuickViewUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuickViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnQuickViewUsers.Location = new System.Drawing.Point(17, 122);
            this.btnQuickViewUsers.Name = "btnQuickViewUsers";
            this.btnQuickViewUsers.Size = new System.Drawing.Size(326, 32);
            this.btnQuickViewUsers.TabIndex = 3;
            this.btnQuickViewUsers.Text = "[View Users Management]";
            this.btnQuickViewUsers.UseVisualStyleBackColor = false;
            this.btnQuickViewUsers.Click += new System.EventHandler(this.btnQuickViewUsers_Click);
            // 
            // btnQuickProcessSale
            // 
            this.btnQuickProcessSale.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuickProcessSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickProcessSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickProcessSale.ForeColor = System.Drawing.Color.White;
            this.btnQuickProcessSale.Location = new System.Drawing.Point(17, 84);
            this.btnQuickProcessSale.Name = "btnQuickProcessSale";
            this.btnQuickProcessSale.Size = new System.Drawing.Size(326, 32);
            this.btnQuickProcessSale.TabIndex = 2;
            this.btnQuickProcessSale.Text = "[+ Process Sale]";
            this.btnQuickProcessSale.UseVisualStyleBackColor = false;
            this.btnQuickProcessSale.Click += new System.EventHandler(this.btnQuickProcessSale_Click);
            // 
            // btnQuickAddNewProduct
            // 
            this.btnQuickAddNewProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuickAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnQuickAddNewProduct.Location = new System.Drawing.Point(17, 46);
            this.btnQuickAddNewProduct.Name = "btnQuickAddNewProduct";
            this.btnQuickAddNewProduct.Size = new System.Drawing.Size(326, 32);
            this.btnQuickAddNewProduct.TabIndex = 1;
            this.btnQuickAddNewProduct.Text = "[+Add New Product]";
            this.btnQuickAddNewProduct.UseVisualStyleBackColor = false;
            this.btnQuickAddNewProduct.Click += new System.EventHandler(this.btnQuickAddNewProduct_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Quick Options";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lstvwActivity);
            this.panel5.Location = new System.Drawing.Point(450, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 277);
            this.panel5.TabIndex = 6;
            // 
            // lstvwActivity
            // 
            this.lstvwActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstvwActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadRecentSalesFeed});
            this.lstvwActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwActivity.ForeColor = System.Drawing.Color.White;
            this.lstvwActivity.HideSelection = false;
            this.lstvwActivity.Location = new System.Drawing.Point(3, 0);
            this.lstvwActivity.Name = "lstvwActivity";
            this.lstvwActivity.Size = new System.Drawing.Size(460, 274);
            this.lstvwActivity.TabIndex = 2;
            this.lstvwActivity.UseCompatibleStateImageBehavior = false;
            this.lstvwActivity.View = System.Windows.Forms.View.Details;
            // 
            // colHeadRecentSalesFeed
            // 
            this.colHeadRecentSalesFeed.Text = "Recent Sales Feed";
            this.colHeadRecentSalesFeed.Width = 429;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(928, 540);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblActionRequired;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblStockWarning;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSalesTodayImprovementPrecentage;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnQuickAddNewProduct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnQuickViewUsers;
        private System.Windows.Forms.Button btnQuickProcessSale;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lstvwActivity;
        private System.Windows.Forms.ColumnHeader colHeadRecentSalesFeed;
        private System.Windows.Forms.ImageList imageList1;
    }
}
