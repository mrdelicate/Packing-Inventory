using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class Container
    {
        public int MaxItems { get; set; }
        public int CurrentItems { get; set; }
        public float MaxWeight { get; set; }
        public float CurrentWeight { get; set; }
        public float MaxVolume { get; set; }
        public float CurrentVolume { get; set; }
        public ContainerStatus Status { get; set; }

        public List<InventoryItem> Items { get; set; }

        public void Update()
        {
            CurrentItems = 0;
            CurrentWeight = 0;
            CurrentVolume = 0;
            Status = ContainerStatus.Available;
            foreach (var item in Items)
            {
                CurrentItems++;
                CurrentWeight += item.Weight;
                CurrentVolume += item.Volume;
            }
            if (CurrentItems == MaxItems || CurrentWeight == MaxWeight || CurrentVolume == MaxVolume)
                Status = ContainerStatus.Full;
        }
        
    }
    enum ContainerStatus { Available, Full }
}
