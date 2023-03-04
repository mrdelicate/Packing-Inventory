using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    public class Inventory
    {
        public List<InventoryItem> Items { get; set; }

        public Inventory()
        {
            Items = new List<InventoryItem>();
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory: ");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.UpperName}");
            }
        }

        public static void AddInventory(InventoryItem item, Inventory inventory)
        {
            inventory.Items.Add(item);
        }

        public static void RemoveInventory(InventoryItem item, Inventory inventory)
        {
            inventory.Items.Remove(item); 
        }
    }
}
