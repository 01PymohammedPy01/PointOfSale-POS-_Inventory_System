using PointOfSale_POS_Inventory_System_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    public partial class ucSales : UserControl
    {
        public ucSales()
        {
            InitializeComponent();

            ImplimentProductCartDT();
            LoadProductsCards();
            clsEventHub.DataChange += _Sales_DataChange;
        }
        public int LoggedInUserID { get; set; }
        DataTable ProductsCart ;

        private void _Sales_DataChange(object sender ,EventArgs e)
        {
            LoadProductsCards();
        }
   

        void ImplimentProductCartDT()
        {
            ProductsCart = new DataTable();

            ProductsCart.Columns.Add("ProductID", typeof(int));
            ProductsCart.Columns.Add("ProductName", typeof(string));
            ProductsCart.Columns.Add("ProductPrice", typeof(decimal));
            ProductsCart.Columns.Add("Quantity", typeof(int));
            ProductsCart.Columns.Add("TotalPrice", typeof(decimal));

            
            datagrdvwProductsCart.DataSource = ProductsCart;
            datagrdvwProductsCart.Columns["ProductID"].Visible = false;
        }


        void LoadProductsCards()
        {
            flwlayoutpnlProducts.Controls.Clear();

            DataTable ProductsCardsDT = clsProducts.GetAllProducts();

            if(ProductsCardsDT == null || ProductsCardsDT.Rows.Count == 0)
            {
                return;
            }

            foreach(DataRow Row in ProductsCardsDT.Rows)
            {
                ucProductCard Card = new ucProductCard();

                Card.ProductID = Convert.ToInt32(Row["ProductID"]);
                Card.ProductName = Row["ProductName"].ToString();
                Card.ProductPrice = Convert.ToDecimal(Row["ProductPrice"]);
                Card.InventoryStockQuantity = Convert.ToInt32(Row["CurrentStock"]);

                string ImagePath = Row["PicturePath"].ToString();
                
                if(!string.IsNullOrEmpty(ImagePath) && System.IO.File.Exists(ImagePath))
                {
                    using(Image TempImage = Image.FromFile(ImagePath))
                    {
                        Card.ProductImage = new Bitmap(TempImage);

                    }
                }

                foreach (Control C in Card.Controls)
                {
                    C.Click += (sender, e) => AddProductToCart(Card);
                }

                flwlayoutpnlProducts.Controls.Add(Card);
            }

        }

        void LoadTotalDue()
        {
            decimal Total = 0;
            foreach (DataRow ProductRow in ProductsCart.Rows)
            {
                 Total += Convert.ToDecimal(ProductRow["TotalPrice"]);
            }
            lblTotalDue.Text = "Total Due: "+ Total.ToString("C2");
        }


        void AddProductToCart(ucProductCard Card)
        {

         



            int Quantity = 1;
            decimal TotalPrice = 0;
            foreach(DataRow ProductRow in ProductsCart.Rows)
            {


                

                if (Card.ProductID == Convert.ToInt32(ProductRow["ProductID"]))
                {

                    

                    Quantity =Convert.ToInt32(ProductRow["Quantity"]) + 1;
                    if (Quantity > Card.InventoryStockQuantity)
                    {
                        errorProvider1.SetError(Card,"Quantity Excced inventory Stock");
                        return;
                    }
                    TotalPrice = clsCalculatePrices.GetTotalPrice(Quantity,Card.ProductPrice);
                    ProductRow["Quantity"] = Quantity;
                    ProductRow["TotalPrice"] = TotalPrice;

                    LoadTotalDue();
                    return;
                }


            }

            

            if(Card.InventoryStockQuantity == 0)
            {
                errorProvider1.SetError(Card,"Out Of Stock");
                return;
            }
            ProductsCart.Rows.Add(Card.ProductID, Card.ProductName, Card.ProductPrice, Quantity, Card.ProductPrice);

            datagrdvwProductsCart.DataSource = ProductsCart;
            LoadTotalDue();
         

        }


        decimal GetTotalPriceAmount()
        {
            decimal total = 0;
            foreach(DataRow PriceRow in  ProductsCart.Rows)
            {
               decimal Price = Convert.ToDecimal(PriceRow["ProductPrice"]);
                int Quantity = Convert.ToInt32(PriceRow["Quantity"]);
                total += clsCalculatePrices.GetTotalPrice(Quantity,Price);
            }
            return total;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {


            if (datagrdvwProductsCart.Rows.Count == 0)
                return;


            DialogResult result = MessageBox.Show("Do you want to process the transaction?",
                                                  "Confirm Checkout",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question
                                                   );

            if (result == DialogResult.Yes)
            {
                decimal TotalCartPrice = GetTotalPriceAmount();


                int SaleID = clsSales.AddNewSale(LoggedInUserID, DateTime.Now, TotalCartPrice);


                foreach(DataRow ItemInCart in ProductsCart.Rows)
                {
                    int ProductID = Convert.ToInt32(ItemInCart["ProductID"]);
                    int Quantity = Convert.ToInt32(ItemInCart["Quantity"]);
                    decimal UnitPrice = Convert.ToDecimal(ItemInCart["ProductPrice"]);

                    clsProducts.DeductStock(ProductID,Quantity);
                    clsSaleItems.AddNewSaleItem(SaleID,ProductID,Quantity,UnitPrice);
                }

                ProductsCart.Rows.Clear();
               datagrdvwProductsCart.DataSource = ProductsCart;
                clsEventHub.NotifyDataChange();

            }
            else
                return;
        }



       private void btnVoidItem_Click(object sender, EventArgs e)
        {
            if (datagrdvwProductsCart.SelectedRows.Count > 0)
            {
                int SelectedItemInCart = Convert.ToInt32(datagrdvwProductsCart.SelectedRows[0].Cells["ProductID"].Value);
                foreach (DataRow ItemInCart in ProductsCart.Rows)
                {
                    if (SelectedItemInCart == Convert.ToInt32(ItemInCart["ProductID"]))
                    {
                        ItemInCart.Delete();
                        break;
                    }
                }

            }
            datagrdvwProductsCart.DataSource= ProductsCart;
            LoadTotalDue();

        }

        private void txtbxSearchProduct_TextChanged(object sender, EventArgs e)
        {


            foreach (Control control in flwlayoutpnlProducts.Controls)
            {

                if(control is ucProductCard ProductCard)
                {

                    if (ProductCard.ProductName.ToLower().Contains(txtbxSearchProduct.Text.ToLower()))
                    {
                        ProductCard.Visible = true;
                    }

                    else
                    {
                        ProductCard.Visible = false;
                    }
                }

            }
        
        }



    }

}
