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
    public partial class frmLoginScreen : Form
    {
    
        public frmLoginScreen()
        {
            InitializeComponent();
        }


        string GetUserRole(string Role)
        {
           
            if(Role == "Cashier")
            {
                return "Cashier";
            }

            return "Admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if(string.IsNullOrWhiteSpace(txtbxUserID.Text) || string.IsNullOrWhiteSpace(txtbxPassword.Text))
            {
                return;
            }



   




            int UserID = int.Parse(txtbxUserID.Text);
            string Password = txtbxPassword.Text.Trim();

            DataTable UserInfo = clsUsers.GetUserInfo(UserID,Password); //I Should Make Check If Password Or ID Is Wrong

            string UserRole = GetUserRole(UserInfo.Rows[0]["UserRole"].ToString());
            string FullName = UserInfo.Rows[0]["FullName"].ToString();


            if (UserInfo.Rows.Count > 0 )
            {
                frmMainForm frmMainForm = new frmMainForm(UserID,FullName,UserRole);
                this.Hide();
                frmMainForm.ShowDialog();
                this.Show();
                txtbxUserID.Text = "";
                txtbxPassword.Text = "";
            }


        }





        private void txtbxUserID_KeyPress(object sender, KeyPressEventArgs e)

        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                return;
            }
        }


    }
}
