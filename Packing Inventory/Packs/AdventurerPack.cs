using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.Packs
{
    internal class AdventurerPack : Container
    {
        public AdventurerPack()
        {
            UpperName      = "An Adventure's Pack";
            LowerName = "an adventurer's pack";
            MaxItems  = 4;
            MaxVolume = 10;
            MaxWeight = 8;
            Items = new();
        }
    }
}
