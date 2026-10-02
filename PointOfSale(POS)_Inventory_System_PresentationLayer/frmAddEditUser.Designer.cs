namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    partial class frmAddEditUser
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddEditUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRoles = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtbxRole = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAddEditUser);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(17, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 71);
            this.panel3.TabIndex = 5;
            // 
            // btnAddEditUser
            // 
            this.btnAddEditUser.BackColor = System.Drawing.Color.Green;
            this.btnAddEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddEditUser.ImageIndex = 0;
            this.btnAddEditUser.Location = new System.Drawing.Point(640, 23);
            this.btnAddEditUser.Name = "btnAddEditUser";
            this.btnAddEditUser.Size = new System.Drawing.Size(107, 30);
            this.btnAddEditUser.TabIndex = 0;
            this.btnAddEditUser.Text = "Add";
            this.btnAddEditUser.UseVisualStyleBackColor = false;
            this.btnAddEditUser.Click += new System.EventHandler(this.btnAddEditUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.ImageIndex = 3;
            this.btnCancel.Location = new System.Drawing.Point(504, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.txtbxRole);
            this.panel2.Controls.Add(this.lblRoles);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblFullName);
            this.panel2.Controls.Add(this.txtbxFullName);
            this.panel2.Controls.Add(this.txtbxPassword);
            this.panel2.Location = new System.Drawing.Point(17, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 371);
            this.panel2.TabIndex = 4;
            // 
            // lblRoles
            // 
            this.lblRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRoles.ImageIndex = 9;
            this.lblRoles.Location = new System.Drawing.Point(498, 165);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(48, 20);
            this.lblRoles.TabIndex = 9;
            this.lblRoles.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblUserTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 95);
            this.panel1.TabIndex = 1;
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.ForeColor = System.Drawing.Color.White;
            this.lblUserTitle.Location = new System.Drawing.Point(270, 29);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(159, 37);
            this.lblUserTitle.TabIndex = 0;
            this.lblUserTitle.Text = "Add User";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblPassword.ImageIndex = 7;
            this.lblPassword.Location = new System.Drawing.Point(208, 289);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 25);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFullName.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFullName.ImageIndex = 8;
            this.lblFullName.Location = new System.Drawing.Point(106, 165);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(93, 20);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "UserName";
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFullName.ForeColor = System.Drawing.Color.White;
            this.txtbxFullName.Location = new System.Drawing.Point(110, 188);
            this.txtbxFullName.MaxLength = 50;
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(178, 20);
            this.txtbxFullName.TabIndex = 4;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPassword.ForeColor = System.Drawing.Color.White;
            this.txtbxPassword.Location = new System.Drawing.Point(294, 289);
            this.txtbxPassword.MaxLength = 8;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(148, 20);
            this.txtbxPassword.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtbxRole
            // 
            this.txtbxRole.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxRole.ForeColor = System.Drawing.Color.White;
            this.txtbxRole.Location = new System.Drawing.Point(502, 188);
            this.txtbxRole.MaxLength = 50;
            this.txtbxRole.Name = "txtbxRole";
            this.txtbxRole.Size = new System.Drawing.Size(162, 20);
            this.txtbxRole.TabIndex = 10;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmAddEditUser";
            this.Text = "frmAddEditUser";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddEditUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtbxRole;
    }
}