using _16_RPG_Exercise;

//We start the necessary clasees
Hero character = new Hero();
Shop shop = new Shop();
//Variables

Console.WriteLine("What is your hero's name?");
character.Name = Console.ReadLine();
while(string.IsNullOrWhiteSpace(character.Name) || int.TryParse(character.Name, out _))
{
    Console.WriteLine("Try to write a valid name.");
    character.Name = Console.ReadLine();
}
character.Name = char.ToUpper(character.Name[0]) + character.Name.Substring(1).ToLower();
bool finalBossDefeated = false;

while (!finalBossDefeated)
{
    Console.Clear();
    Console.WriteLine($"Where do you want to go?{Environment.NewLine}1 - Shop {Environment.NewLine}2 - Tavern {Environment.NewLine}3 - Dungeon{Environment.NewLine}4 - Inventory");
    int userChoice;
    while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 4)
    {
        Console.WriteLine("Not a valid number, try again.");
    }
    Console.Clear();
    switch (userChoice)
    {
        case 1:
            Console.WriteLine("You have entered the shop.");
            bool isInShop = true;
            while (isInShop)
            {
                Console.WriteLine($"What do you want to do?{Environment.NewLine}1 - Buy.{Environment.NewLine}2 - Sell.{Environment.NewLine}3 - Leave.");
                int userChoiceShop;
                while (!int.TryParse(Console.ReadLine(), out userChoiceShop) || userChoiceShop < 1 || userChoiceShop > 3)
                {
                    Console.WriteLine("Not a valid number, try again.");
                }
                Console.Clear();
                switch (userChoiceShop)
                {
                    case 1:
                        Console.WriteLine("Available items:");
                        for (int i = 0; i < shop.shopItems.Items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {shop.shopItems.Items[i].Name} {shop.shopItems.Items[i].Price} gold coins.");
                        }
                        Console.WriteLine($"{Environment.NewLine}");
                        int itemToBuy;
                        while (!int.TryParse(Console.ReadLine(), out itemToBuy) || itemToBuy < 1 || itemToBuy > shop.shopItems.Items.Count)
                        {
                            Console.WriteLine("You need to write a valid number.");
                        }
                        itemToBuy--;
                        Console.Clear();
                        shop.CharacterBuys(shop.shopItems.Items[itemToBuy], character);
                        break;
                    case 2:
                        Console.WriteLine("Select wich item to sell:");
                        for (int i = 0; i < character.Backpack.Items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {character.Backpack.Items[i].Name} {character.Backpack.Items[i].SellingPrice} gold coins.");
                        }
                        int itemToSell = int.Parse(Console.ReadLine()) - 1;
                        shop.CharacterSells(character.Backpack.Items[itemToSell], character);
                        Console.Clear();
                        break;
                    case 3:
                        isInShop = false;
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
        case 4:
            break;
        default:
            Console.WriteLine("Type a number between 1 and 3");
            break;
    }
}