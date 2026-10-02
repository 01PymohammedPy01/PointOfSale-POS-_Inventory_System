using PointOfSale_POS_Inventory_System_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddMode = 1, EditMode = 2 }
        enMode Mode = enMode.AddMode;
        int UserID;

     


       



        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = enMode.AddMode;
        }

    
        public frmAddEditUser(int userId, string fullName, string userRole, string password)
        {
            InitializeComponent();
            Mode = enMode.EditMode;
            LoadUserInfo(userId, fullName, userRole, password);
        }

        void LoadUserInfo(int userId, string fullName, string userRole, string password)
        {
            this.UserID = userId;

      
            btnAddEditUser.Text = "Edit User";
            lblUserTitle.Text = "Edit User";

            txtbxFullName.Text = fullName;
            txtbxRole.Text = userRole;
            txtbxPassword.Text = password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void AddOrEditUser()
        {
     
            if (string.IsNullOrWhiteSpace(txtbxFullName.Text))
            {
                errorProvider1.SetError(txtbxFullName, "Full Name cannot be blank.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtbxRole.Text))
            {
                errorProvider1.SetError(txtbxRole, "User Role cannot be blank.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtbxPassword.Text))
            {
                errorProvider1.SetError(txtbxPassword, "Password cannot be blank.");
                return;
            }

            switch (Mode)
            {
                case enMode.AddMode:
                    clsUsers addUser = new clsUsers();
                    addUser.FullName = txtbxFullName.Text;
                    addUser.UserRole = txtbxRole.Text; 
                    addUser.Password = txtbxPassword.Text; 

                    addUser.Save();
                    MessageBox.Show("User Added Successfully");
                    break;

                case enMode.EditMode:
                    clsUsers editUser = new clsUsers(UserID, txtbxFullName.Text, txtbxRole.Text, txtbxPassword.Text);
                    MessageBox.Show("User Updated Successfully");
                    editUser.Save();
                    break;
            }

            this.Close();
        }

        private void btnAddEditUser_Click(object sender, EventArgs e)
        {
            AddOrEditUser();
        }
    }
}