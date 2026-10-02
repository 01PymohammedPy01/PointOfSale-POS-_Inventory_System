using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS__Inventory_System_PresentationLayer
{
    public class clsEventHub
    {

        public static event EventHandler DataChange;


        public static void NotifyDataChange()
        {
            DataChange?.Invoke(null, EventArgs.Empty);
        }
    }

}
