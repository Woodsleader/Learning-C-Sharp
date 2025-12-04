string[] inventory = new string[5];
inventory[0] = "Dragon slayer";
inventory[1] = "Crossbow";
inventory[2] = "Cannon";
inventory[3] = "Map";
inventory[4] = "Beer";
Console.WriteLine("You got 5 inventory slots(1-5). Which one do you choose?");
int answer = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine($"Chosen item: {inventory[answer]}");