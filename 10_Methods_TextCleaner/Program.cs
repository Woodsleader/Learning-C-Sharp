string[] inventory = new string[5];
inventory[0] = "Dragon slayer";
inventory[1] = "Crossbow";
inventory[2] = "Cannon";
inventory[3] = "Map";
inventory[4] = "Beer";
Console.WriteLine("What item are you searching for?");
string userItem = CleanInput(Console.ReadLine());
bool isFound = false;
for (int i = 0; i < inventory.Length; i++)
{
    if (userItem == CleanInput(inventory[i]))
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
static string CleanInput(string rawText)
{
    return rawText.ToLower().Trim();
}