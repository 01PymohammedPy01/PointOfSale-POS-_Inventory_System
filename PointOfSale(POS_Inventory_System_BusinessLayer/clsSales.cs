using PointOfSale_POS_Inventory_System_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_BusinessLayer
{
    public class clsSales
    {
    


        public static int AddNewSale(int UserID, DateTime SaleDate, decimal TotalAmount)
        {
            return clsSalesData.AddNewSale(UserID,SaleDate,TotalAmount);
        }

        public static decimal GetTotalSalesOfToday()
        {
            return clsSalesData.GetSalesOfToday();
        }
       public static DataTable GetLast10SaleItems()
        {
            return clsSalesData.GetLast10SaleItems();
        }

    }


}
