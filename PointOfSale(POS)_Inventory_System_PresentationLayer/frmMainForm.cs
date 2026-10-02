
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
using System.Windows.Forms.VisualStyles;

namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    
    public partial class frmMainForm : Form
    {

        


        public frmMainForm(int UserID,string FullName,string Role)
        {
            InitializeComponent();
            LoadUser(UserID,FullName,Role);
            ucSales1.LoggedInUserID = UserID;

            ucDashboard1.ProcessSaleRequested += ucDashboard1_ProcessSaleRequested;
            ucDashboard1.ProcessUserRequested += ucUser_ProcessUserRequest;
        }

        private void ucUser_ProcessUserRequest(object sender,EventArgs e)
        {
            TabsControl1.SelectedIndex = 2;
        }

        private void  ucDashboard1_ProcessSaleRequested(object sender, EventArgs e)
        {
            TabsControl1.SelectedIndex = 3;
        }




        void LoadUser(int UserID,string FullName,string Role)
        {

           lblUserInfo.Text = $"Logged In As {FullName}: {Role}(ID:{UserID})";

            if (Role == "Cashier")
            {
                TabsControl1.TabPages.Remove(tabpgDashboard);
                TabsControl1.TabPages.Remove(tabpgSetting);
                TabsControl1.TabPages.Remove(tabpgUsers);
            }

       
        }

    }
}
