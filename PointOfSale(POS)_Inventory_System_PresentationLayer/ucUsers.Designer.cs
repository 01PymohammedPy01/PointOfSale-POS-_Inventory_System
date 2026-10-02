namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class ucUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrdvwUsers = new System.Windows.Forms.DataGridView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlTitleSearch = new System.Windows.Forms.Panel();
            this.lblTitleUsers = new System.Windows.Forms.Label();
            this.txtbxSearchUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdvwUsers)).BeginInit();
            this.pnlTitleSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datagrdvwUsers);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnEditUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Location = new System.Drawing.Point(3, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 407);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Users Management";
            // 
            // datagrdvwUsers
            // 
            this.datagrdvwUsers.AllowUserToAddRows = false;
            this.datagrdvwUsers.AllowUserToDeleteRows = false;
            this.datagrdvwUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagrdvwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdvwUsers.Location = new System.Drawing.Point(15, 72);
            this.datagrdvwUsers.Name = "datagrdvwUsers";
            this.datagrdvwUsers.ReadOnly = true;
            this.datagrdvwUsers.Size = new System.Drawing.Size(793, 313);
            this.datagrdvwUsers.TabIndex = 6;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteUser.Location = new System.Drawing.Point(237, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(121, 25);
            this.btnDeleteUser.TabIndex = 5;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.DimGray;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditUser.Location = new System.Drawing.Point(126, 3);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(105, 25);
            this.btnEditUser.TabIndex = 4;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DimGray;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddUser.Location = new System.Drawing.Point(15, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(105, 25);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pnlTitleSearch
            // 
            this.pnlTitleSearch.BackColor = System.Drawing.Color.Teal;
            this.pnlTitleSearch.Controls.Add(this.lblTitleUsers);
            this.pnlTitleSearch.Controls.Add(this.txtbxSearchUser);
            this.pnlTitleSearch.Location = new System.Drawing.Point(0, 3);
            this.pnlTitleSearch.Name = "pnlTitleSearch";
            this.pnlTitleSearch.Size = new System.Drawing.Size(828, 66);
            this.pnlTitleSearch.TabIndex = 10;
            // 
            // lblTitleUsers
            // 
            this.lblTitleUsers.AutoSize = true;
            this.lblTitleUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUsers.ForeColor = System.Drawing.Color.White;
            this.lblTitleUsers.Location = new System.Drawing.Point(13, 23);
            this.lblTitleUsers.Name = "lblTitleUsers";
            this.lblTitleUsers.Size = new System.Drawing.Size(86, 31);
            this.lblTitleUsers.TabIndex = 2;
            this.lblTitleUsers.Text = "Users";
            // 
            // txtbxSearchUser
            // 
            this.txtbxSearchUser.Location = new System.Drawing.Point(669, 23);
            this.txtbxSearchUser.Name = "txtbxSearchUser";
            this.txtbxSearchUser.Size = new System.Drawing.Size(142, 20);
            this.txtbxSearchUser.TabIndex = 1;
            this.txtbxSearchUser.TextChanged += new System.EventHandler(this.txtbxSearchUser_TextChanged);
            // 
            // ucUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleSearch);
            this.Name = "ucUsers";
            this.Size = new System.Drawing.Size(830, 488);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdvwUsers)).EndInit();
            this.pnlTitleSearch.ResumeLayout(false);
            this.pnlTitleSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrdvwUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel pnlTitleSearch;
        private System.Windows.Forms.Label lblTitleUsers;
        private System.Windows.Forms.TextBox txtbxSearchUser;
    }
}
