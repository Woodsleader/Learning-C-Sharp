using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Armor : Item
    {
        public int ArmorStat;

        public Armor(string name, int price, int armorStat)
        {
            this.Name = name;
            this.Price = price;
            this.ArmorStat = armorStat;
        }
    }
}
