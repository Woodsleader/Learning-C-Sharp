using _16_RPG_Exercise;

//We start the necessary clasees
Hero character = new Hero();
Shop shop = new Shop();
Inventory inventory = new Inventory();

//Variables

Console.WriteLine("What is your hero's name?");
character.Name = Console.ReadLine();
bool finalBossDefeated = false;

while (!finalBossDefeated)
{
    Console.WriteLine($"{Environment.NewLine}Where do you want to go?{Environment.NewLine}1 - Shop {Environment.NewLine}2 - Tavern {Environment.NewLine}3 - Dungeon{Environment.NewLine}");
    int userChoice = int.Parse(Console.ReadLine());
    switch (userChoice)
    {
        case 1:
            Console.WriteLine($"{Environment.NewLine}You have entered the shop.");
            bool isInShop = true;
            while (isInShop)
            {
                Console.WriteLine($"{Environment.NewLine}What do you want to do?{Environment.NewLine}1 - Buy.{Environment.NewLine}2 - Sell.{Environment.NewLine}3 - Leave.{Environment.NewLine}");
                int userChoiceShop = int.Parse(Console.ReadLine());
                switch (userChoiceShop)
                {
                    case 1:
                        Console.WriteLine($"{Environment.NewLine}Available items:");
                        for (int i = 0; i < shop.availableItems.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {shop.availableItems[i].Name} {shop.availableItems[i].Price} gold coins.");
                        }
                        Console.WriteLine($"{Environment.NewLine}");
                        int itemToBuy = int.Parse(Console.ReadLine()) - 1;
                        shop.CharacterBuys(shop.availableItems[itemToBuy], character, inventory);
                        break;
                    case 2:
                        Console.WriteLine($"{Environment.NewLine}Select wich item to sell:");
                        for (int i = 0; i < inventory.characterInventory.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {inventory.characterInventory[i].Name} {inventory.characterInventory[i].SellingPrice} gold coins.");
                        }
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