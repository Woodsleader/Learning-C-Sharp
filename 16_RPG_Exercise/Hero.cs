using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Hero
    {
        public string Name;
        public int Health = 100;
        public int Level = 1;
        public int Experience = 0;
        public int Gold = 1000;
        public int Attack = 10;
        public int Armor = 5;
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
        // See if there are equippable items
        public bool HasEquippableItems()
        {
            foreach (Item item in this.Backpack.Items)
            {
                if (item is Sword || item is Armor)
                {
                    return true;
                }
            }
            return false;
        }
        // Equip items
        public void EquipItem(Item itemToEquip)
        {
            bool equippableItems = false;
            foreach (Item item in this.Backpack.Items)
            {
                if (item is Sword || item is Armor)
                {
                    equippableItems = true;
                    break;
                }
            }
            if (equippableItems == true)
            {
                if (itemToEquip is Sword newSword)
                {
                    if (this.EquippedSword != null)
                    {
                        this.Backpack.AddItem(EquippedSword);
                    }
                    this.EquippedSword = newSword;
                    this.Backpack.RemoveItem(itemToEquip);
                }
                else if (itemToEquip is Armor newArmor)
                {
                    if (this.EquippedArmor != null)
                    {
                        this.Backpack.AddItem(EquippedArmor);
                    }
                    this.EquippedArmor = newArmor;
                    this.Backpack.RemoveItem(itemToEquip);
                }
                else
                {
                    Console.WriteLine("You cannot equip that item!");
                }
            }
            else
            {
                Console.WriteLine("You don't have any items to equip");
            }
        }
        //Unequip item
        public void UnequipItem(Item itemToUnequip)
        {
            if (itemToUnequip is Sword newSword)
            {
                if (this.EquippedSword != null)
                {
                    this.EquippedSword = null;
                    this.Backpack.AddItem(itemToUnequip);
                }
                else
                {
                    Console.WriteLine("You don't have any sword equipped!");
                }
            }
            else if (itemToUnequip is Armor newArmor)
            {
                if (this.EquippedArmor != null)
                {
                    this.EquippedArmor = null;
                    this.Backpack.AddItem(itemToUnequip);
                }
                else
                {
                    Console.WriteLine("You don't have any armor equipped!");
                }
            }
            else
            {
                Console.WriteLine("This error is impossible to get, how did you manage to do it?");
            }

        }
        //Add/remove gold
        public void AddGold(int amount)
        {
            this.Gold += amount;
        }
        public void RemoveGold(int amount)
        {
            this.Gold -= amount;
        }
        //Add/remove health
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
