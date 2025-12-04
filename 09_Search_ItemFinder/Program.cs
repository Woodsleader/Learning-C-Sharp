string[] inventory = new string[5];
inventory[0] = "Dragon slayer";
inventory[1] = "Crossbow";
inventory[2] = "Cannon";
inventory[3] = "Map";
inventory[4] = "Beer";
Console.WriteLine("What item are you searching?");
string userItem = Console.ReadLine().ToLower();
bool isFound = false;
for (int i = 0; i < inventory.Length; i++)
{
    if (userItem == inventory[i].ToLower())
    {
        isFound = true;
        userItem = inventory[i];
        break;
    }
}
if (isFound)
{
    Console.WriteLine($"{userItem} is in your inventory.");
}
else
{
    Console.WriteLine($"{userItem} is not in your inventory.");
}