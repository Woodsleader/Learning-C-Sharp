using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Sword : Item
    {
        public int Damage { get; set; }

        public Sword(string name, int price, int damage) : base(name, price)
        {
            this.Damage = damage;
        }
    }
}
