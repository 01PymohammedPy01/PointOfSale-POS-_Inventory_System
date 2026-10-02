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
    public partial class ucProductCard : UserControl
    {
        public ucProductCard()
        {
            InitializeComponent();
        }


        public string ProductName
        {
            get=>lblProductName.Text;
            set => lblProductName.Text = value;
        }


        private decimal _productPrice;
        public decimal ProductPrice
        {
            get => _productPrice;

            set
            {
                _productPrice = value;
                lblProductPrice.Text = _productPrice.ToString("C2");
            }
        }


        public Image ProductImage
        {
            get => picbxProduct.Image;
            set
            {
                picbxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                picbxProduct.Image = value;
            }
        }

        
        public int ProductID { get; set; }
        public int InventoryStockQuantity {  get; set; }
    }
}
