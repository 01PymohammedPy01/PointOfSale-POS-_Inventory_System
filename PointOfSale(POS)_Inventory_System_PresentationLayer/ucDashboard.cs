using PointOfSale_POS_Inventory_System_BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    public partial class ucDashboard : UserControl
    {
        

        public event EventHandler ProcessSaleRequested;
        public event EventHandler ProcessUserRequested;


        public ucDashboard()
        {
            InitializeComponent();
            clsEventHub.DataChange += ucDashboard_DataChanged;
            _RefreshRecentActivites();
            _FillDashboardLabels();
        }

        private void ucDashboard_DataChanged(object sender,EventArgs e)
        {
            _RefreshRecentActivites();
            _FillDashboardLabels();
        }

        private void btnQuickViewUsers_Click(object sender, EventArgs e)
        {
            
            if(ProcessUserRequested != null)
            {
                ProcessUserRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnQuickAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct AddProduct = new frmAddEditProduct();
            
            AddProduct.ShowDialog();
            clsEventHub.NotifyDataChange();


        }

        private void btnQuickProcessSale_Click(object sender, EventArgs e)
        {

            if(ProcessSaleRequested != null)
            {
                ProcessSaleRequested(this, EventArgs.Empty);
            }

        }


        private void _FillDashboardLabels()
        {

            lblStockAmount.Text = clsProducts.GetLowStockProducts().ToString();
            lblTotalProducts.Text = clsProducts.GetTotalProducts().ToString();
            lblTotalSales.Text = clsSales.GetTotalSalesOfToday().ToString();

        }

        private void _RefreshRecentActivites()
        {

            using (DataTable RecentActivites = clsSales.GetLast10SaleItems())
            {
                lstvwActivity.Items.Clear();

                foreach (DataRow Row in RecentActivites.Rows)
                {
                    string Activity = "Sold At :"+ Row["SaleDate"].ToString() +" Product " + Row["ProductName"].ToString();
                    lstvwActivity.Items.Add(Activity);

                }
            }


        }













    }
}
