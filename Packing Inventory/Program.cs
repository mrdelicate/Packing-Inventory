using Packing_Inventory.Packs;
using System.Security.Cryptography;

while (true)
{
    Console.WriteLine("Type the corresponding number to hoose your pack:\n\n1. Beginner's Pack\n2. Adventurer's Pack\n3. Hero's Pack\n>> ");
    var input = Console.ReadLine();
    bool valid = int.TryParse(input, out int number);
    if (valid)
    {
        if (number == 1)
            Container pack =new BeginnerPack();
    }
}
