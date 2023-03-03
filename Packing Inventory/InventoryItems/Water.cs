using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.InventoryItems
{
    internal class Water : InventoryItem
    {
        public Water()
        {
            Name      = "Some Water";
            LowerName = "some water";
            Weight    = 2f;
            Volume    = 0.5f;
        }
    }
}
