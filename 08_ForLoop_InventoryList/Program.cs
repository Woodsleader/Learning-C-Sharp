string[] inventory = new string[5];
inventory[0] = "Dragon slayer";
inventory[1] = "Crossbow";
inventory[2] = "Cannon";
inventory[3] = "Map";
inventory[4] = "Beer";
for (int i = 0; i < inventory.Length; i++)
{
    Console.WriteLine($"Slot {i + 1}: {inventory[i]}");
}
Console.WriteLine("Pick an item:");
int answer = int.Parse(Console.ReadLine());
Console.WriteLine($"{inventory[answer - 1]} selected.");