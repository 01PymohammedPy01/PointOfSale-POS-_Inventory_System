namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class frmAddEditProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditProduct));
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.picbxProduct = new System.Windows.Forms.PictureBox();
            this.combxCategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtbxCurrentStock = new System.Windows.Forms.TextBox();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            this.txtbxProductPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddEditProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProduct)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductTitle.Location = new System.Drawing.Point(270, 29);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(206, 37);
            this.lblProductTitle.TabIndex = 0;
            this.lblProductTitle.Text = "Add Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblProductTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 95);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnChoosePicture);
            this.panel2.Controls.Add(this.picbxProduct);
            this.panel2.Controls.Add(this.combxCategories);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblCurrentStock);
            this.panel2.Controls.Add(this.lblProductPrice);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.txtbxCurrentStock);
            this.panel2.Controls.Add(this.txtbxProductName);
            this.panel2.Controls.Add(this.txtbxProductPrice);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 371);
            this.panel2.TabIndex = 2;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.BackColor = System.Drawing.Color.Gray;
            this.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicture.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChoosePicture.ImageIndex = 3;
            this.btnChoosePicture.Location = new System.Drawing.Point(362, 296);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(156, 30);
            this.btnChoosePicture.TabIndex = 12;
            this.btnChoosePicture.Text = "Choose Picture";
            this.btnChoosePicture.UseVisualStyleBackColor = false;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // picbxProduct
            // 
            this.picbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbxProduct.Location = new System.Drawing.Point(524, 180);
            this.picbxProduct.Name = "picbxProduct";
            this.picbxProduct.Size = new System.Drawing.Size(240, 188);
            this.picbxProduct.TabIndex = 11;
            this.picbxProduct.TabStop = false;
            // 
            // combxCategories
            // 
            this.combxCategories.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.combxCategories.ForeColor = System.Drawing.Color.White;
            this.combxCategories.FormattingEnabled = true;
            this.combxCategories.Location = new System.Drawing.Point(329, 151);
            this.combxCategories.Name = "combxCategories";
            this.combxCategories.Size = new System.Drawing.Size(150, 21);
            this.combxCategories.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCategory.ImageIndex = 9;
            this.lblCategory.ImageList = this.imageList1;
            this.lblCategory.Location = new System.Drawing.Point(325, 128);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 20);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "trash.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "cancel.png");
            this.imageList1.Images.SetKeyName(4, "dollar.png");
            this.imageList1.Images.SetKeyName(5, "boxes.png");
            this.imageList1.Images.SetKeyName(6, "package.png");
            this.imageList1.Images.SetKeyName(7, "coin.png");
            this.imageList1.Images.SetKeyName(8, "shipping-box.png");
            this.imageList1.Images.SetKeyName(9, "shopping.png");
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentStock.ImageIndex = 5;
            this.lblCurrentStock.ImageList = this.imageList1;
            this.lblCurrentStock.Location = new System.Drawing.Point(106, 281);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(131, 20);
            this.lblCurrentStock.TabIndex = 8;
            this.lblCurrentStock.Text = "Current Stock";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductPrice.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblProductPrice.ImageIndex = 7;
            this.lblProductPrice.ImageList = this.imageList1;
            this.lblProductPrice.Location = new System.Drawing.Point(106, 196);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(130, 25);
            this.lblProductPrice.TabIndex = 7;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductName.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblProductName.ImageIndex = 8;
            this.lblProductName.ImageList = this.imageList1;
            this.lblProductName.Location = new System.Drawing.Point(106, 128);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(130, 20);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name";
            // 
            // txtbxCurrentStock
            // 
            this.txtbxCurrentStock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxCurrentStock.ForeColor = System.Drawing.Color.White;
            this.txtbxCurrentStock.Location = new System.Drawing.Point(110, 304);
            this.txtbxCurrentStock.MaxLength = 16;
            this.txtbxCurrentStock.Name = "txtbxCurrentStock";
            this.txtbxCurrentStock.Size = new System.Drawing.Size(148, 20);
            this.txtbxCurrentStock.TabIndex = 5;
            this.txtbxCurrentStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCurrentStock_KeyPress);
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxProductName.ForeColor = System.Drawing.Color.White;
            this.txtbxProductName.Location = new System.Drawing.Point(110, 151);
            this.txtbxProductName.MaxLength = 50;
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(178, 20);
            this.txtbxProductName.TabIndex = 4;
            // 
            // txtbxProductPrice
            // 
            this.txtbxProductPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxProductPrice.ForeColor = System.Drawing.Color.White;
            this.txtbxProductPrice.Location = new System.Drawing.Point(110, 235);
            this.txtbxProductPrice.MaxLength = 6;
            this.txtbxProductPrice.Name = "txtbxProductPrice";
            this.txtbxProductPrice.Size = new System.Drawing.Size(148, 20);
            this.txtbxProductPrice.TabIndex = 3;
            this.txtbxProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCurrentStock_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.ImageIndex = 3;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(504, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddEditProduct
            // 
            this.btnAddEditProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditProduct.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddEditProduct.ImageIndex = 0;
            this.btnAddEditProduct.ImageList = this.imageList1;
            this.btnAddEditProduct.Location = new System.Drawing.Point(640, 23);
            this.btnAddEditProduct.Name = "btnAddEditProduct";
            this.btnAddEditProduct.Size = new System.Drawing.Size(107, 30);
            this.btnAddEditProduct.TabIndex = 0;
            this.btnAddEditProduct.Text = "Add";
            this.btnAddEditProduct.UseVisualStyleBackColor = false;
            this.btnAddEditProduct.Click += new System.EventHandler(this.btnAddEditProduct_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAddEditProduct);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(12, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 71);
            this.panel3.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(804, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmAddEditProduct";
            this.Text = "frmAddEditProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtbxCurrentStock;
        private System.Windows.Forms.TextBox txtbxProductName;
        private System.Windows.Forms.TextBox txtbxProductPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddEditProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox combxCategories;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.PictureBox picbxProduct;
    }
}