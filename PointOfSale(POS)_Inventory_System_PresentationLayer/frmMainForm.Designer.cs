namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class frmMainForm
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
            this.TabsControl1 = new System.Windows.Forms.TabControl();
            this.tabpgDashboard = new System.Windows.Forms.TabPage();
            this.ucDashboard1 = new PointOfSale_POS__Inventory_System_PresentationLayer.ucDashboard();
            this.tabpgProducts = new System.Windows.Forms.TabPage();
            this.ucProduct1 = new PointOfSale_POS__Inventory_System_PresentationLayer.ucProduct();
            this.tabpgUsers = new System.Windows.Forms.TabPage();
            this.ucUsers1 = new PointOfSale_POS__Inventory_System_PresentationLayer.ucUsers();
            this.tabpgSales = new System.Windows.Forms.TabPage();
            this.ucSales1 = new PointOfSale_POS__Inventory_System_PresentationLayer.ucSales();
            this.tabpgSetting = new System.Windows.Forms.TabPage();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.TabsControl1.SuspendLayout();
            this.tabpgDashboard.SuspendLayout();
            this.tabpgProducts.SuspendLayout();
            this.tabpgUsers.SuspendLayout();
            this.tabpgSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsControl1
            // 
            this.TabsControl1.Controls.Add(this.tabpgDashboard);
            this.TabsControl1.Controls.Add(this.tabpgProducts);
            this.TabsControl1.Controls.Add(this.tabpgUsers);
            this.TabsControl1.Controls.Add(this.tabpgSales);
            this.TabsControl1.Controls.Add(this.tabpgSetting);
            this.TabsControl1.Location = new System.Drawing.Point(1, 3);
            this.TabsControl1.Multiline = true;
            this.TabsControl1.Name = "TabsControl1";
            this.TabsControl1.SelectedIndex = 0;
            this.TabsControl1.Size = new System.Drawing.Size(963, 567);
            this.TabsControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabsControl1.TabIndex = 1;
            // 
            // tabpgDashboard
            // 
            this.tabpgDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabpgDashboard.Controls.Add(this.ucDashboard1);
            this.tabpgDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabpgDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabpgDashboard.Name = "tabpgDashboard";
            this.tabpgDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDashboard.Size = new System.Drawing.Size(955, 541);
            this.tabpgDashboard.TabIndex = 0;
            this.tabpgDashboard.Text = "Dashboard";
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDashboard1.Location = new System.Drawing.Point(3, 3);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(949, 535);
            this.ucDashboard1.TabIndex = 0;
            // 
            // tabpgProducts
            // 
            this.tabpgProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabpgProducts.Controls.Add(this.ucProduct1);
            this.tabpgProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabpgProducts.Location = new System.Drawing.Point(4, 22);
            this.tabpgProducts.Name = "tabpgProducts";
            this.tabpgProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgProducts.Size = new System.Drawing.Size(955, 541);
            this.tabpgProducts.TabIndex = 1;
            this.tabpgProducts.Text = "Products";
            // 
            // ucProduct1
            // 
            this.ucProduct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucProduct1.Location = new System.Drawing.Point(0, 0);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.Size = new System.Drawing.Size(822, 463);
            this.ucProduct1.TabIndex = 7;
            // 
            // tabpgUsers
            // 
            this.tabpgUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabpgUsers.Controls.Add(this.ucUsers1);
            this.tabpgUsers.Location = new System.Drawing.Point(4, 22);
            this.tabpgUsers.Name = "tabpgUsers";
            this.tabpgUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgUsers.Size = new System.Drawing.Size(955, 541);
            this.tabpgUsers.TabIndex = 2;
            this.tabpgUsers.Text = "Users";
            // 
            // ucUsers1
            // 
            this.ucUsers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucUsers1.Location = new System.Drawing.Point(0, 0);
            this.ucUsers1.Name = "ucUsers1";
            this.ucUsers1.Size = new System.Drawing.Size(830, 488);
            this.ucUsers1.TabIndex = 0;
            // 
            // tabpgSales
            // 
            this.tabpgSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabpgSales.Controls.Add(this.ucSales1);
            this.tabpgSales.Location = new System.Drawing.Point(4, 22);
            this.tabpgSales.Name = "tabpgSales";
            this.tabpgSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgSales.Size = new System.Drawing.Size(955, 541);
            this.tabpgSales.TabIndex = 3;
            this.tabpgSales.Text = "Sales";
            // 
            // ucSales1
            // 
            this.ucSales1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucSales1.Location = new System.Drawing.Point(8, 6);
            this.ucSales1.Name = "ucSales1";
            this.ucSales1.Size = new System.Drawing.Size(947, 529);
            this.ucSales1.TabIndex = 0;
            // 
            // tabpgSetting
            // 
            this.tabpgSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabpgSetting.Location = new System.Drawing.Point(4, 22);
            this.tabpgSetting.Name = "tabpgSetting";
            this.tabpgSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgSetting.Size = new System.Drawing.Size(955, 541);
            this.tabpgSetting.TabIndex = 4;
            this.tabpgSetting.Text = "Setting";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserInfo.Location = new System.Drawing.Point(263, 581);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(44, 16);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "label1";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(964, 606);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.TabsControl1);
            this.Name = "frmMainForm";
            this.Text = "Pos And Inventory Management";
            this.TabsControl1.ResumeLayout(false);
            this.tabpgDashboard.ResumeLayout(false);
            this.tabpgProducts.ResumeLayout(false);
            this.tabpgUsers.ResumeLayout(false);
            this.tabpgSales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabsControl1;
        private System.Windows.Forms.TabPage tabpgDashboard;
        private System.Windows.Forms.TabPage tabpgProducts;
        private System.Windows.Forms.TabPage tabpgSales;
        private System.Windows.Forms.TabPage tabpgSetting;
        private ucProduct ucProduct1;
        private System.Windows.Forms.TabPage tabpgUsers;
        private ucUsers ucUsers1;
        private ucDashboard ucDashboard1;
        private ucSales ucSales1;
        private System.Windows.Forms.Label lblUserInfo;
    }
}

