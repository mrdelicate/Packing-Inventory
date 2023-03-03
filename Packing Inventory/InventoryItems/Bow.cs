using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.InventoryItems
{
    internal class Bow : InventoryItem
    {
        public Bow() 
        {
            Name      = "A Bow";
            LowerName = "a bow";
            Weight    = 1f;
            Volume    = 4f;
        }
    }
}
