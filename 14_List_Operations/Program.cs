List<string> inventory = new List<string>();
inventory.Add("Master sword");
inventory.Add("Bomb");
inventory.Add("Potion");
inventory.Add("Ancient artifact");
inventory.Add("Bow");
foreach (string s in inventory)
{
    Console.WriteLine(s);
}
Console.WriteLine();
inventory.Sort();
foreach (string s in inventory)
{
    Console.WriteLine(s);
}
inventory.Clear();
Console.WriteLine("A bandit has robbed you of all your belongings!");
Console.WriteLine($"Number of items in inventory: {inventory.Count}");