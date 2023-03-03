using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.Packs
{
    internal class BeginnerPack : Container
    {
        public BeginnerPack()
        {
            Name      = "A Beginner's Pack";
            LowerName = "a beginner's pack";
            MaxItems  = 3;
            MaxVolume = 8;
            MaxWeight = 6;
        }
    }
}
