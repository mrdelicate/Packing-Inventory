using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.Packs
{
    internal class HeroPack : Container
    {
        public HeroPack()
        {
            Name      = "A Hero's Pack";
            LowerName = "a hero's pack";
            MaxItems  = 6;
            MaxVolume = 14;
            MaxWeight = 11;
        }
    }
}
