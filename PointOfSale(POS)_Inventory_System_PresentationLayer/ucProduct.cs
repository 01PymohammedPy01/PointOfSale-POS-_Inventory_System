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
    public partial class ucProduct : UserControl
    {

   



        public ucProduct()
        {
            InitializeComponent();
            RefreshProducts();
            clsEventHub.DataChange += _ucProducts_DataChange;
        }

        private void _ucProducts_DataChange(object sender ,EventArgs e)
        {
            RefreshProducts();
        }
   

        DataTable ProductDT;
        void RefreshProducts()
        {
            ProductDT = clsProducts.GetAllProducts();
            datagrdvwProducts.DataSource = ProductDT;

            datagrdvwProducts.Columns["CategoryID"].Visible = false;
       

        }
        void EditProduct()
        {
            if (datagrdvwProducts.SelectedRows.Count > 0)
            {
                int ProductID = Convert.ToInt32(datagrdvwProducts.SelectedRows[0].Cells["ProductID"].Value);
                string ProductName = datagrdvwProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                decimal ProductPrice = Convert.ToDecimal(datagrdvwProducts.SelectedRows[0].Cells["ProductPrice"].Value);
                int CurrentStock = Convert.ToInt32(datagrdvwProducts.SelectedRows[0].Cells["CurrentStock"].Value);
                int CategoryID = Convert.ToInt32(datagrdvwProducts.SelectedRows[0].Cells["CategoryID"].Value);
                string Picture = datagrdvwProducts.SelectedRows[0].Cells["PicturePath"].Value.ToString();

                frmAddEditProduct addEditProduct = new frmAddEditProduct(ProductID, ProductName, ProductPrice, CurrentStock, CategoryID,Picture);
                this.Hide();
                addEditProduct.ShowDialog();
                this.Show();
            }

            RefreshProducts();
            clsEventHub.NotifyDataChange();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addEditProduct = new frmAddEditProduct();
            this.Hide();
            addEditProduct.ShowDialog();
            this.Show();
            RefreshProducts();
            clsEventHub.NotifyDataChange();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (datagrdvwProducts.SelectedRows.Count > 0)
            {
                int ProductID = Convert.ToInt32(datagrdvwProducts.SelectedRows[0].Cells["ProductID"].Value);
                clsProducts.RemoveProduct(ProductID);
                clsEventHub.NotifyDataChange();

            }
            else
            {
                MessageBox.Show("No Product Selected");
            }
            RefreshProducts();

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void txtbxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            ProductDT.DefaultView.RowFilter = $"ProductName Like '%{txtbxSearchProduct.Text}%' ";

          

        }
    }
}
