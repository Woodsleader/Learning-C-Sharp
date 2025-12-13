using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Armor : Item
    {
        public int ArmorStat { set; get; }

        public Armor(string name, int price, int armorStat) : base(name, price)
        {
            this.ArmorStat = armorStat;
        }
    }
}
