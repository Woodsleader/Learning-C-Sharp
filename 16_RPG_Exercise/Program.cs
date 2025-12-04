using _16_RPG_Exercise;

Hero character = new Hero();
Console.WriteLine("What is your hero's name?");
character.Name = Console.ReadLine();
bool finalBossDefeated = false;

while (!finalBossDefeated)
{
    Console.WriteLine($"Where do you want to go?{Environment.NewLine}1 - Shop {Environment.NewLine}2 - Tavern {Environment.NewLine}3 - Dungeon ");
    int userChoice = int.Parse(Console.ReadLine());
    switch (userChoice)
    {
        case 1:
            Console.WriteLine("You have entered the store.");
            break;
        case 2:
            Console.WriteLine("You have entered the tavern.");
            break;
        case 3:
            Console.WriteLine("You are outside the dungeon.");
            break;
        default:
            Console.WriteLine("Choose again.");
            break;
    }
}