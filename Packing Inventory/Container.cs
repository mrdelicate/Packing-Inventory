using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    public class Container
    {
        public string UpperName { get; set; }
        public string LowerName { get; set; }
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

        public void ShowContainerMenu()
        {
            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"Container: {UpperName}");
            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"Items : {CurrentItems}/{MaxItems}");
            Console.WriteLine($"Weight: {CurrentWeight}/{MaxWeight}");
            Console.WriteLine($"Volume: {CurrentVolume}/{MaxWeight}");
            Console.WriteLine($"\nContainer Status: {Status}");
            Console.WriteLine($"\nPacked Items:");
            if (Items.Count == 0)
                Console.WriteLine("Empty");
            else
                {
                foreach (var item in Items)
                    Console.WriteLine($"{item.UpperName}");
                }
            Console.WriteLine($"\n-------------------------------------\n");

        }

        public void AddToContainer(InventoryItem item, Inventory inventory)
        {
            if (CurrentItems + 1 > MaxItems)
                Console.WriteLine($"Too many items already in {LowerName}.");
            if (CurrentWeight + item.Weight > MaxWeight)
                Console.WriteLine($"{UpperName} can't carry that much weight!");
            if (CurrentVolume + item.Volume > MaxVolume)
                Console.WriteLine($"There is not enough available volume in {LowerName} for that!");
            else if (CurrentWeight + item.Weight <= MaxWeight && CurrentVolume + item.Volume <= MaxVolume && CurrentItems + 1 <= MaxItems)
            {
                Console.WriteLine($"You put {item.LowerName} in {LowerName}.");
                Items.Add(item);
                Inventory.RemoveInventory(item, inventory);
            }
            Console.ReadLine();
            Update();
            ShowContainerMenu();
            inventory.ShowInventory();
        }

        public void RemoveFromContainer(InventoryItem item, Inventory inventory)
        {
            Items.Remove(item);
            Inventory.AddInventory(item, inventory);
            Console.WriteLine($"You remove {item.LowerName} from {LowerName}.");
            Console.ReadLine();
            Update();
            ShowContainerMenu();
            inventory.ShowInventory();
        }

        public enum ContainerStatus
        {
            Available,
            Full
        }
    }
}
