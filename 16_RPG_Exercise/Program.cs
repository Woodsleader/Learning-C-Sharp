using _16_RPG_Exercise;

bool finalBossDefeated = false;
Hero character = new Hero();
Shop shop = new Shop();

Console.WriteLine("What's your name, traveller?");
character.Name = InputHelper.ReadName(Console.ReadLine());

while (!finalBossDefeated)
{
    Console.Clear();
    Console.WriteLine($"Where do you want to go?{Environment.NewLine}1 - Shop {Environment.NewLine}2 - Tavern {Environment.NewLine}3 - Dungeon{Environment.NewLine}4 - Inventory");
    int userChoiceMenu = InputHelper.ReadInt(1, 4);
    Console.Clear();
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
                Console.Clear();
                switch (userChoiceShop)
                {
                    case 1:
                        // Buy item
                        Console.WriteLine("Available items:");
                        for (int i = 0; i < shop.shopItems.Items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {shop.shopItems.Items[i].Name} {shop.shopItems.Items[i].Price} gold coins.");
                        }
                        Console.WriteLine($"{Environment.NewLine}");
                        int itemToBuy = InputHelper.ReadInt(1, shop.shopItems.Items.Count);
                        Console.Clear();
                        shop.CharacterBuys(shop.shopItems.Items[itemToBuy - 1], character);
                        break;
                    case 2:
                        // Sell item
                        Console.WriteLine("Select wich item to sell:");
                        for (int i = 0; i < character.Backpack.Items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {character.Backpack.Items[i].Name} {character.Backpack.Items[i].SellingPrice} gold coins.");
                        }
                        int itemToSell = InputHelper.ReadInt(1, character.Backpack.Items.Count);
                        shop.CharacterSells(character.Backpack.Items[itemToSell - 1], character);
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
                int userInventory;
                while (!int.TryParse(Console.ReadLine(), out userInventory) || userInventory < 1 || userInventory > 5)
                {
                    Console.WriteLine("Write a valid number.");
                }
                switch (userInventory)
                {
                    case 1:
                        // See equipped items
                        Console.Clear();
                        Console.WriteLine($"Sword: {character.EquippedSword?.Name ?? "No weapon equipped"}");
                        Console.WriteLine($"Armor: {character.EquippedArmor?.Name ?? "No armor equipped"}");
                        break;
                    case 2:
                        // Equip item
                        Console.Clear();
                        character.EquipItem();
                        break;
                    case 3:
                        // Unequip item
                        Console.Clear();
                        Console.WriteLine($"Equipped items:{Environment.NewLine}1 - Weapon: {character.EquippedSword?.Name ?? "No sword equipped"}{Environment.NewLine}2 - Armor: {character.EquippedArmor?.Name ?? "No armor equipped"}");
                        Console.WriteLine("Select wich item to unequip:");
                        int unequipChoice = InputHelper.ReadInt(1, 2);
                        if (unequipChoice == 1)
                        {
                            character.UnequipItem(character.EquippedSword);
                        }
                        else
                        {
                            character.UnequipItem(character.EquippedArmor);
                        }
                        Console.Clear();
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