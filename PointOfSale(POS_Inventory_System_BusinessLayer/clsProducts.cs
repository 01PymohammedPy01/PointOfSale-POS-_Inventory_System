using PointOfSale_POS_Inventory_System_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_BusinessLayer
{
    public class clsProducts
    {
        enum enMode { AddMode = 1,UpdateMode = 2}
        enMode Mode = enMode.AddMode;
        public int ProductID {  get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice {  get; set; }
        public int CurrentStock {  get; set; }
        public int CategoryID {  get; set; }
        public string PicturePath {  get; set; }


        public static DataTable GetAllProducts()
        {
            return clsProductsData.GetAllProduct();
        }


        public static int GetLowStockProducts()
        {
            return clsProductsData.GetLowStockItems();
        }

        public static int GetTotalProducts()
        {
            return clsProductsData.GetTotalProducts();
        }
        public static bool DeductStock(int ProductID,int DeductQuantity)
        {
            return clsProductsData.DeductStock(ProductID,DeductQuantity);
        }

        public static bool RemoveProduct(int ProductID)
        {
            return clsProductsData.RemoveProduct(ProductID);
        }


        public clsProducts(int ProductID,string ProductName,decimal ProductPrice,int CurrentStock,int CategoryID,string PicturePath)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.CurrentStock = CurrentStock;
            this.CategoryID = CategoryID;
            this.PicturePath = PicturePath;
            Mode = enMode.UpdateMode;
        }

        public clsProducts()
        {
            this.ProductID = -1;
            this.ProductName = "";
            this.ProductPrice = 0;
            this.CurrentStock = 0;
            this.CategoryID = -1;
            this.PicturePath = "";
            Mode = enMode.AddMode;
        }

        private bool _AddProduct()
        {
          return clsProductsData.AddNewProduct(this.ProductName,this.ProductPrice,this.CurrentStock,this.CategoryID,this.PicturePath);
        }

        private bool _UpdateProduct()
        {
            return clsProductsData.UpdateProduct(this.ProductID,this.ProductName,this.ProductPrice,this.CurrentStock,this.CategoryID,this.PicturePath);
        }

        public void Save()
        {
            switch(Mode)
            {
                case enMode.AddMode:
                if (_AddProduct())
             {
                Mode = enMode.UpdateMode;
                       
             }
                break;


                case enMode.UpdateMode:
                   _UpdateProduct();
                    break;
             }


        }




    }

}
