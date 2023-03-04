using Packing_Inventory;
using Packing_Inventory.Packs;
using Packing_Inventory.InventoryItems;

Inventory inventory = new();
Container container = new();
InventoryItem sword = new Sword();
InventoryItem arrow = new Arrow();
InventoryItem bow = new Bow();
InventoryItem food= new Food();
InventoryItem rope = new Rope();
InventoryItem water = new Water();
Inventory.AddInventory(sword, inventory);
Inventory.AddInventory(arrow, inventory);
Inventory.AddInventory(bow  , inventory);
Inventory.AddInventory(food , inventory);
Inventory.AddInventory(rope , inventory);
Inventory.AddInventory(water, inventory);
while (true)
{
    
    Console.Write("Type the corresponding number to choose your pack:\n\n1. Beginner's Pack\n2. Adventurer's Pack\n3. Hero's Pack\n>> ");
    var input = Console.ReadLine();
    bool valid = int.TryParse(input, out int number);
    if (valid && number >= 1 && number <= 3)
    {
        if (number == 1)
            container = new BeginnerPack();
        if (number == 2)
            container = new AdventurerPack();
        if (number == 3)
            container = new HeroPack();
        break;
    }
}
while (true)
{
    Console.Clear();
    container.ShowContainerMenu();
    inventory.ShowInventory();
    Console.WriteLine($"\nYou can \"add\" and \"remove\" an item from {container.LowerName}. Type \"?\" for help.");
    Console.Write(">");
    ActionHandler(inventory, container);
}

void ActionHandler(Inventory inventory, Container container)
{
    var input = Console.ReadLine();
    var words = input.Split(" ");
    if (words[0].ToLower() == "add")
    {
        if (inventory.Items.Exists(x => x.Name.ToLower() == words[1]))
        {
            //Console.WriteLine($"You put {inventory.Items[inventory.Items.FindIndex(x => x.Name.ToLower() == words[1])].LowerName} into {container.LowerName}.");
            container.AddToContainer(inventory.Items[inventory.Items.FindIndex(x => x.Name.ToLower() == words[1])], inventory);
        }
        else { Console.WriteLine("Add what? There doesn't seem to be that here."); }
    }
    else if (words[0].ToLower() == "remove")
    {
        if (container.Items.Exists(x => x.Name.ToLower() == words[1]))
        {
            //Console.WriteLine($"You remove {container.Items[container.Items.FindIndex(x => x.Name.ToLower() == words[1])].LowerName} from {container.LowerName}.");
            container.RemoveFromContainer(container.Items[container.Items.FindIndex(x => x.Name.ToLower() == words[1])], inventory);
        }
        else { Console.WriteLine("Remove what? There doesn't seem to be that here."); }
    }
    else if (words[0].ToLower() == "?")
    {
        Console.WriteLine();
        Console.WriteLine("The correct syntax would either be \"remove sword\" or \"add sword\".");
        Console.Write("Available item keywords are: ");
        foreach (var item in inventory.Items) { Console.Write($"{item.Name} "); }
        foreach (var item in container.Items) { Console.Write($"{item.Name} "); }
        Console.WriteLine();
        Console.ReadLine();
    }
}

