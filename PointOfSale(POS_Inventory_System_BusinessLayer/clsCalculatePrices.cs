using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_BusinessLayer
{
    public class clsCalculatePrices
    {

        public static decimal GetTotalPrice(int Quantity, decimal Price)
        {
            return Price * Quantity;
        }

    }
}
