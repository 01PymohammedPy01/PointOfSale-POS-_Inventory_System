namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class ucSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductCatalogTitle = new System.Windows.Forms.Label();
            this.txtbxSearchProduct = new System.Windows.Forms.TextBox();
            this.flwlayoutpnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrdvwProductsCart = new System.Windows.Forms.DataGridView();
            this.lblCurrentTransaction = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.btnVoidItem = new System.Windows.Forms.Button();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdvwProductsCart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblProductCatalogTitle);
            this.panel1.Controls.Add(this.txtbxSearchProduct);
            this.panel1.Controls.Add(this.flwlayoutpnlProducts);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 512);
            this.panel1.TabIndex = 0;
            // 
            // lblProductCatalogTitle
            // 
            this.lblProductCatalogTitle.AutoSize = true;
            this.lblProductCatalogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCatalogTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductCatalogTitle.Location = new System.Drawing.Point(3, 3);
            this.lblProductCatalogTitle.Name = "lblProductCatalogTitle";
            this.lblProductCatalogTitle.Size = new System.Drawing.Size(115, 18);
            this.lblProductCatalogTitle.TabIndex = 1;
            this.lblProductCatalogTitle.Text = "Product Catalog";
            // 
            // txtbxSearchProduct
            // 
            this.txtbxSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxSearchProduct.ForeColor = System.Drawing.Color.White;
            this.txtbxSearchProduct.Location = new System.Drawing.Point(13, 26);
            this.txtbxSearchProduct.Name = "txtbxSearchProduct";
            this.txtbxSearchProduct.Size = new System.Drawing.Size(486, 20);
            this.txtbxSearchProduct.TabIndex = 1;
            this.txtbxSearchProduct.Text = "ssss";
            this.txtbxSearchProduct.TextChanged += new System.EventHandler(this.txtbxSearchProduct_TextChanged);
            // 
            // flwlayoutpnlProducts
            // 
            this.flwlayoutpnlProducts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flwlayoutpnlProducts.Location = new System.Drawing.Point(3, 52);
            this.flwlayoutpnlProducts.Name = "flwlayoutpnlProducts";
            this.flwlayoutpnlProducts.Size = new System.Drawing.Size(496, 457);
            this.flwlayoutpnlProducts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.datagrdvwProductsCart);
            this.panel2.Controls.Add(this.lblCurrentTransaction);
            this.panel2.Location = new System.Drawing.Point(521, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 258);
            this.panel2.TabIndex = 1;
            // 
            // datagrdvwProductsCart
            // 
            this.datagrdvwProductsCart.AllowUserToAddRows = false;
            this.datagrdvwProductsCart.AllowUserToDeleteRows = false;
            this.datagrdvwProductsCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdvwProductsCart.Location = new System.Drawing.Point(6, 23);
            this.datagrdvwProductsCart.Name = "datagrdvwProductsCart";
            this.datagrdvwProductsCart.ReadOnly = true;
            this.datagrdvwProductsCart.Size = new System.Drawing.Size(462, 232);
            this.datagrdvwProductsCart.TabIndex = 3;
            // 
            // lblCurrentTransaction
            // 
            this.lblCurrentTransaction.AutoSize = true;
            this.lblCurrentTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTransaction.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTransaction.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentTransaction.Name = "lblCurrentTransaction";
            this.lblCurrentTransaction.Size = new System.Drawing.Size(139, 18);
            this.lblCurrentTransaction.TabIndex = 2;
            this.lblCurrentTransaction.Text = "Current Transaction";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnProcessPayment);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btnAddCustomer);
            this.panel3.Controls.Add(this.btnApplyDiscount);
            this.panel3.Controls.Add(this.btnVoidItem);
            this.panel3.Controls.Add(this.lblTotalDue);
            this.panel3.Location = new System.Drawing.Point(521, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 248);
            this.panel3.TabIndex = 2;
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.Green;
            this.btnProcessPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(3, 200);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(465, 45);
            this.btnProcessPayment.TabIndex = 7;
            this.btnProcessPayment.Text = "[Process Payment]";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(243, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 35);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 154);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(234, 35);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "[Add Customer]";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyDiscount.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnApplyDiscount.Location = new System.Drawing.Point(243, 113);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(225, 35);
            this.btnApplyDiscount.TabIndex = 4;
            this.btnApplyDiscount.Text = "[Apply Discount]";
            this.btnApplyDiscount.UseVisualStyleBackColor = false;
            // 
            // btnVoidItem
            // 
            this.btnVoidItem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVoidItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoidItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidItem.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnVoidItem.Location = new System.Drawing.Point(3, 113);
            this.btnVoidItem.Name = "btnVoidItem";
            this.btnVoidItem.Size = new System.Drawing.Size(234, 35);
            this.btnVoidItem.TabIndex = 3;
            this.btnVoidItem.Text = "[Void Item]";
            this.btnVoidItem.UseVisualStyleBackColor = false;
            this.btnVoidItem.Click += new System.EventHandler(this.btnVoidItem_Click);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.Color.White;
            this.lblTotalDue.Location = new System.Drawing.Point(73, 16);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(124, 29);
            this.lblTotalDue.TabIndex = 2;
            this.lblTotalDue.Text = "Total Due:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(995, 584);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdvwProductsCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flwlayoutpnlProducts;
        private System.Windows.Forms.Label lblProductCatalogTitle;
        private System.Windows.Forms.TextBox txtbxSearchProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVoidItem;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Label lblCurrentTransaction;
        private System.Windows.Forms.DataGridView datagrdvwProductsCart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
