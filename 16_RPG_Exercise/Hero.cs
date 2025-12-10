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
        public int Gold = 1000;
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
        // Check for enough gold
        public bool EnoughGold(int price)
        {
            if (this.Gold > price)
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
