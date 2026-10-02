using PointOfSale_POS_Inventory_System_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_BusinessLayer
{
    public class clsSaleItems
    {

        //public int SaleItemID {  get; set; }
        //public int ProductID {  get; set; }
        //public int SaleID {  get; set; }
        //public decimal UnitPrice { get; set; }
        //public decimal Quantity {  get; set; }


        public static void AddNewSaleItem(int SaleID, int ProductID,int Quantity, decimal UnitPrice)
        {
            clsSaleItemsData.AddNewSaleItem(ProductID,SaleID,UnitPrice,Quantity);
        }
    }
}
