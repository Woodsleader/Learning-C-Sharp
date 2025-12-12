using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Hero
    {
        public string Name;
        private int _health = 100;
        public int Health
        {
            get { return  _health; }
            set
            {
                if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                else if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public int MaxHealth => 100 * (Level * 10);
        public int Level = 1;
        public int Experience = 0;
        private int _gold = 1000;
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
        public int AttackHeroStat = 10;
        public int AttackWithSword
        {
            get
            {
                return AttackHeroStat + (EquippedSword?.Damage ?? 0);
            }
        }
        public int ArmorHeroStat = 5;
        public int ArmorWithProtection
        {
            get
            {
                return ArmorHeroStat + (EquippedArmor?.ArmorStat ?? 0);
            }
        }
        public int Evasion = 0;
        public Sword? EquippedSword;
        public Armor? EquippedArmor;

        public Inventory Backpack = new Inventory();

        public Hero()
        {
            Sword rustySword = new Sword("Rusty sword", 0, 5);
            this.EquippedSword = rustySword;
            Armor leatherArmor = new Armor("Leather armor", 10, 3);
            this.EquippedArmor = leatherArmor;
        }
        // Equip items
        public void EquipItem()
        {
            List<Item> equipable = new List<Item>();
            foreach (Item i in this.Backpack.Items)
            {
                if (i is Sword || i is Armor)
                {
                    equipable.Add(i);
                }
            }
            if (equipable.Count > 0)
            {
                Console.WriteLine("Equipable items:");
                for (int i = 0; i < equipable.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {equipable[i].Name}");
                }
                int userChoice = InputHelper.ReadInt(1, equipable.Count) - 1;
                if (equipable[userChoice] is Sword newSword)
                {
                    if (this.EquippedSword != null)
                    {
                        this.Backpack.AddItem(EquippedSword);
                    }
                    this.EquippedSword = newSword;
                    this.Backpack.RemoveItem(newSword);
                }
                else if (equipable[userChoice] is Armor newArmor)
                {
                    if (this.EquippedArmor != null)
                    {
                        this.Backpack.AddItem(this.EquippedArmor);
                    }
                    this.EquippedArmor = newArmor;
                    this.Backpack.RemoveItem(newArmor);
                }
            }
            else
            {
                Console.WriteLine("You have nothing to equip!");
            }
            Console.Clear();
        }
        //Unequip item
        public void UnequipItem()
        {
            if (EquippedSword == null && EquippedArmor == null)
            {
                Console.WriteLine("You don't have anything equipped!");
                return;
            }
            else
            {
                EquippedItems();
                Console.WriteLine("Wich item do you want to unequip?");
                int userChoice = InputHelper.ReadInt(1, 2);
                if (userChoice == 1 || this.EquippedSword != null)
                {
                    Backpack.AddItem(this.EquippedSword);
                    this.EquippedSword = null;
                }
                else if (userChoice == 2 || this.EquippedArmor != null)
                {
                    Backpack.AddItem(this.EquippedArmor);
                    this.EquippedArmor = null;
                }
            }
        }
        //Display equipped items
        public void EquippedItems()
        {
            Console.WriteLine($"1 - Sword: {this.EquippedSword?.Name ?? "Empty"}");
            Console.WriteLine($"2 - Armor: {this.EquippedArmor?.Name ?? "Empty"}");
        }
        // Check for enough gold
        public bool EnoughGold(int price)
        {
            if (this.Gold >= price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Add/remove gold
        public void AddGold(int amount)
        {
            this.Gold += amount;
        }
        public void RemoveGold(int amount)
        {
            this.Gold -= amount;
        }
        // Add/remove health
        public void AddHealth(int amount)
        {
            this.Health += amount;
        }
        public void RemoveHealth(int amount)
        {
            this.Health -= amount;
        }
    }
}
