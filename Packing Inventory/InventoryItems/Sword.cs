using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.InventoryItems
{
    public class Sword : InventoryItem
    {
        public Sword()
        {
            Name = "sword";
            UpperName = "A Sword";
            LowerName = "a sword";
            Weight    = 5f;
            Volume    = 3f;
        }
    }
}
