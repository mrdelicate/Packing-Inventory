using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.InventoryItems
{
    class Arrow : InventoryItem
    {
        public Arrow()
        {
            Name = "An Arrow";
            LowerName = "an arrow";
            Weight = 0.1f;
            Volume = 0.005f;
        }
    }
}
