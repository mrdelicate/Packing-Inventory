using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.InventoryItems
{
    internal class Food : InventoryItem
    {
        public Food()
        {
            Name      = "Some Food";
            LowerName = "some food";
            Weight    = 1f;
            Volume    = 0.5f;
        }
    }
}
