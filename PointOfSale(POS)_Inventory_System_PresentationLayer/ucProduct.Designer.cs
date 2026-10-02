namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class ucProduct
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
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblProductManagment = new System.Windows.Forms.Label();
            this.datagrdvwProducts = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlSearchAndTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbxSearchProduct = new System.Windows.Forms.TextBox();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdvwProducts)).BeginInit();
            this.pnlSearchAndTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.lblProductManagment);
            this.pnlProduct.Controls.Add(this.datagrdvwProducts);
            this.pnlProduct.Controls.Add(this.btnDeleteProduct);
            this.pnlProduct.Controls.Add(this.btnEditProduct);
            this.pnlProduct.Controls.Add(this.btnAddProduct);
            this.pnlProduct.Location = new System.Drawing.Point(3, 75);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(822, 407);
            this.pnlProduct.TabIndex = 7;
            // 
            // lblProductManagment
            // 
            this.lblProductManagment.AutoSize = true;
            this.lblProductManagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductManagment.ForeColor = System.Drawing.Color.White;
            this.lblProductManagment.Location = new System.Drawing.Point(12, 49);
            this.lblProductManagment.Name = "lblProductManagment";
            this.lblProductManagment.Size = new System.Drawing.Size(170, 20);
            this.lblProductManagment.TabIndex = 8;
            this.lblProductManagment.Text = "Products Management";
            // 
            // datagrdvwProducts
            // 
            this.datagrdvwProducts.AllowUserToAddRows = false;
            this.datagrdvwProducts.AllowUserToDeleteRows = false;
            this.datagrdvwProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagrdvwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdvwProducts.Location = new System.Drawing.Point(15, 72);
            this.datagrdvwProducts.MultiSelect = false;
            this.datagrdvwProducts.Name = "datagrdvwProducts";
            this.datagrdvwProducts.ReadOnly = true;
            this.datagrdvwProducts.RowHeadersVisible = false;
            this.datagrdvwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrdvwProducts.Size = new System.Drawing.Size(793, 313);
            this.datagrdvwProducts.TabIndex = 6;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(237, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(121, 25);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.DimGray;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditProduct.Location = new System.Drawing.Point(126, 3);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(105, 25);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(15, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 25);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnlSearchAndTitle
            // 
            this.pnlSearchAndTitle.BackColor = System.Drawing.Color.Teal;
            this.pnlSearchAndTitle.Controls.Add(this.lblTitle);
            this.pnlSearchAndTitle.Controls.Add(this.txtbxSearchProduct);
            this.pnlSearchAndTitle.Location = new System.Drawing.Point(0, 3);
            this.pnlSearchAndTitle.Name = "pnlSearchAndTitle";
            this.pnlSearchAndTitle.Size = new System.Drawing.Size(828, 66);
            this.pnlSearchAndTitle.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Products";
            // 
            // txtbxSearchProduct
            // 
            this.txtbxSearchProduct.Location = new System.Drawing.Point(669, 23);
            this.txtbxSearchProduct.Name = "txtbxSearchProduct";
            this.txtbxSearchProduct.Size = new System.Drawing.Size(142, 20);
            this.txtbxSearchProduct.TabIndex = 1;
            this.txtbxSearchProduct.TextChanged += new System.EventHandler(this.txtbxSearchProduct_TextChanged);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlSearchAndTitle);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(829, 486);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdvwProducts)).EndInit();
            this.pnlSearchAndTitle.ResumeLayout(false);
            this.pnlSearchAndTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblProductManagment;
        private System.Windows.Forms.DataGridView datagrdvwProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlSearchAndTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxSearchProduct;
    }
}
