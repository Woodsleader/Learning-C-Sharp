Console.WriteLine("What's your character's name?");
string name = Console.ReadLine();
Console.WriteLine("How many gold coins do you have?");
int coins = int.Parse(Console.ReadLine());
coins += 50;
Console.WriteLine($"Okay {name}, after selling your old rusty sword you have {coins} gold coins");