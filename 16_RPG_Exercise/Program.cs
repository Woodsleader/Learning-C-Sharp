using _16_RPG_Exercise;

bool finalBossDefeated = false;
Hero character = new Hero();
Shop shop = new Shop();

Console.WriteLine("What's your name, traveller?");
character.Name = InputHelper.ReadName(Console.ReadLine());

while (!finalBossDefeated)
{
    Console.WriteLine($"Where do you want to go?{Environment.NewLine}1 - Shop {Environment.NewLine}2 - Tavern {Environment.NewLine}3 - Dungeon{Environment.NewLine}4 - Inventory");
    int userChoiceMenu = InputHelper.ReadInt(1, 4);
    switch (userChoiceMenu)
    {
        case 1:
            // Shop entered
            Console.WriteLine("You have entered the shop.");
            bool isInShop = true;
            while (isInShop)
            {
                Console.WriteLine($"What do you want to do?{Environment.NewLine}1 - Buy.{Environment.NewLine}2 - Sell.{Environment.NewLine}3 - Leave.");
                int userChoiceShop = InputHelper.ReadInt(1, 3);
                switch (userChoiceShop)
                {
                    case 1:
                        // Buy item
                        shop.ShopBuy(character);
                        break;
                    case 2:
                        // Sell items
                        break;
                    case 3:
                        isInShop = false;
                        break; 
                }
            }
            break;
        case 2:
            Console.WriteLine("You have entered the tavern.");
            bool isInTavern = true;
            while (isInTavern)
            {
                Console.WriteLine($"What do you want to do?{Environment.NewLine}1 - Sleep (Fully heals for 100 gold){Environment.NewLine}2 - Leave");
                int userChoiceTavern = InputHelper.ReadInt(1, 2);
                if (userChoiceTavern == 1)
                {
                    if (character.EnoughGold(100) == true)
                    {
                        character.AddHealth(999);
                    }
                }
            }
            break;
        case 3:
            Console.WriteLine("You are outside the dungeon.");
            break;
        case 4:
            bool isInInventory = true;
            while (isInInventory)
            {
                Console.WriteLine($"You're in your inventory.{Environment.NewLine}1 - View equipped items{Environment.NewLine}2 - Equip items{Environment.NewLine}3 - Unequip item{Environment.NewLine}4 - View stats{Environment.NewLine}5 - Leave");
                int userInventory = InputHelper.ReadInt(1, 5);
                switch (userInventory)
                {
                    case 1:
                        // See equipped items
                        character.EquippedItems();
                        break;
                    case 2:
                        // Equip item
                        Console.Clear();
                        character.EquipItem();
                        break;
                    case 3:
                        // Unequip item
                        character.UnequipItem();
                        break;
                    case 4:
                        break;
                    case 5:
                        isInInventory = false;
                        break;
                }
            }
            break;
    }
}