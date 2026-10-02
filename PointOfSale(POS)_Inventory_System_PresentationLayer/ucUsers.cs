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
    public partial class ucUsers : UserControl
    {
        public ucUsers()
        {
            InitializeComponent();
            RefreshUsers();
        }


    


        DataTable UsersDT;

        void RefreshUsers()
        {
            
            UsersDT = clsUsers.GetAllUsers();
            datagrdvwUsers.DataSource = UsersDT;

       
            if (datagrdvwUsers.Columns["Password"] != null)
            {
                datagrdvwUsers.Columns["Password"].Visible = false;
               

            }
        }

        void EditUser()
        {
            if (datagrdvwUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(datagrdvwUsers.SelectedRows[0].Cells["UserID"].Value);
                string fullName = datagrdvwUsers.SelectedRows[0].Cells["FullName"].Value.ToString();
                string userRole = datagrdvwUsers.SelectedRows[0].Cells["UserRole"].Value.ToString();
                string password = datagrdvwUsers.SelectedRows[0].Cells["Password"].Value.ToString();

           
                frmAddEditUser addEditUser = new frmAddEditUser(userId, fullName, userRole, password);

                this.Hide();
                addEditUser.ShowDialog();
                this.Show();

                RefreshUsers();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser addEditUser = new frmAddEditUser();

            this.Hide();
            addEditUser.ShowDialog();
            this.Show();

            RefreshUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (datagrdvwUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(datagrdvwUsers.SelectedRows[0].Cells["UserID"].Value);

       
                clsUsers.RemoveUser(userId);
            }
            else
            {
                MessageBox.Show("No User Selected");
            }

            RefreshUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void txtbxSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (UsersDT != null)
            {
            
                UsersDT.DefaultView.RowFilter = $"FullName LIKE '%{txtbxSearchUser.Text}%' OR UserRole LIKE '%{txtbxSearchUser.Text}%'";
            }
        }






    }
}
