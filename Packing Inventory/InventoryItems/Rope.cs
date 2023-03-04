using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.InventoryItems
{
    internal class Rope : InventoryItem
    {
        public Rope()
        {
            Name = "rope";
            UpperName = "A Rope";
            LowerName = "a rope";
            Weight    = 1f;
            Volume    = 0.5f;
        }
    }
}
