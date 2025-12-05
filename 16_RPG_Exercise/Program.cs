using _16_RPG_Exercise;

//We start the necessary clasees
Hero character = new Hero();
Shop shop = new Shop();

//Variables

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
            Console.WriteLine($"You have entered the shop.{Environment.NewLine}");
            bool isInShop = true;
            while (isInShop)
            {
                Console.WriteLine($"What do you want to do?{Environment.NewLine}1 - Buy.{Environment.NewLine}2 - Sell.{Environment.NewLine}3 - Leave.");
                int userChoiceShop = int.Parse(Console.ReadLine());
                switch (userChoiceShop)
                {
                    case 1:
                        Console.WriteLine($"Available items:{Environment.NewLine}");
                        foreach (Item i in shop.AvailableItems)
                        {
                            int itemSlot = shop.AvailableItems.IndexOf(i) + 1;
                            Console.WriteLine($"{itemSlot} - {i.Name}");
                        }
                        int buyChoice = int.Parse(Console.ReadLine());
                        break;

                }
            }
            break;
        case 2:
            Console.WriteLine("You have entered the tavern.");
            break;
        case 3:
            Console.WriteLine("You are outside the dungeon.");
            break;
        default:
            Console.WriteLine("Type a number between 1 and 3");
            break;
    }
}