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
    



    public partial class frmAddEditProduct : Form
    {
        enum enMode { AddMode = 1,EditMode = 2}
        enMode Mode = enMode.AddMode;
        private int ProductID;
        private string PicturePath = string.Empty;
        public frmAddEditProduct()
        {
            InitializeComponent();
            Mode = enMode.AddMode;
            LoadCategoryInfo();
        }

         public frmAddEditProduct(int ProductID,string ProductName,decimal ProductPrice,int CurrentStock,int CategoryID,string Picture)
        {
            InitializeComponent();
            Mode = enMode.EditMode;
            PicturePath = Picture;

            LoadCategoryInfo();
            LoadProductScreenInfo(ProductID,ProductName,ProductPrice,CurrentStock, CategoryID);
        }

        void LoadCategoryInfo()
        {
            combxCategories.DataSource = clsCategory.GetAllCategories();
            combxCategories.DisplayMember = "CategoryName";
            combxCategories.ValueMember = "CategoryID";
        }

        void LoadProductScreenInfo(int ProductID,string ProductName, decimal ProductPrice, int CurrentStock,int CategoryID)
        {
            this.ProductID = ProductID;
           

            btnAddEditProduct.Text = "Edit Product";
            btnAddEditProduct.ImageIndex = 2;
            lblProductTitle.Text = "Edit Product";

            txtbxProductName.Text = ProductName;
            txtbxProductPrice.Text = ProductPrice.ToString();
            txtbxCurrentStock.Text = CurrentStock.ToString();

            if(!string.IsNullOrWhiteSpace(PicturePath))
            {
                picbxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                picbxProduct.Image = Image.FromFile(PicturePath);
            }
            combxCategories.SelectedValue = CategoryID;
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {



            this.Close();
        }




        void AddOrEditProduct()
        {

            if(string.IsNullOrWhiteSpace(txtbxProductName.Text))
            {
               return;
            }


            if(string.IsNullOrWhiteSpace(txtbxProductPrice.Text) || decimal.Parse(txtbxProductPrice.Text) > 214748)
            {
                errorProvider1.SetError(txtbxProductPrice, "Price Cannot Exceed 214,748.3647");
                return;

            }
            if (string.IsNullOrWhiteSpace(txtbxCurrentStock.Text))
            {
                return;

            }

            if (combxCategories.SelectedValue == null)
            {
                return;
            }

            switch (Mode)
            {

                case enMode.AddMode:
                    clsProducts AddProduct = new clsProducts();

                    AddProduct.ProductName = txtbxProductName.Text;
                    AddProduct.ProductPrice = decimal.Parse(txtbxProductPrice.Text);
                    AddProduct.CurrentStock = int.Parse(txtbxCurrentStock.Text);
                    AddProduct.CategoryID = Convert.ToInt32(combxCategories.SelectedValue);
                    AddProduct.PicturePath = PicturePath;
                    AddProduct.Save();
                    MessageBox.Show("Product Added Succeffully");
                    break;


                case enMode.EditMode:

                    string ProductName = txtbxProductName.Text;
                    decimal ProductPrice = decimal.Parse(txtbxProductPrice.Text);
                    int CurrentStock = int.Parse(txtbxCurrentStock.Text);
                    int CategoryID = Convert.ToInt32(combxCategories.SelectedValue);
                    clsProducts EditProduct = new clsProducts(ProductID, ProductName, ProductPrice, CurrentStock, CategoryID,PicturePath);


                    EditProduct.Save();
                    MessageBox.Show("Product Updated Succeffully");
                    break;
            }
            this.Close();

        }



        private void btnAddEditProduct_Click(object sender, EventArgs e)
        {
            AddOrEditProduct();
            
        }

        private void txtbxProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar) )
            {
                return;

            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if(e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtbxCurrentStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;

            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }


            e.Handled = true;
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog PictureDialog = new OpenFileDialog())
            {
                PictureDialog.Title = "Choose Product Picture";
                PictureDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files(*.*)|*.*";

                if(PictureDialog.ShowDialog() == DialogResult.OK)
                {

                    PicturePath = PictureDialog.FileName;
                    picbxProduct.SizeMode = PictureBoxSizeMode.Zoom;

                  
                        picbxProduct.Image = Image.FromFile(PicturePath);

               
                }
            }

        }
    }
}
