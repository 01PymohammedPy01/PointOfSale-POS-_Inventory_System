using PointOfSale_POS_Inventory_System_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_BusinessLayer
{
    public class clsCategory
    {
        public int CategoryID {  get; set; }
        public string CategoryName { get; set; }

        public static DataTable GetAllCategories()
        {
            return clsCategoryData.GetAllCategories();
          

         
        }
    }
}
