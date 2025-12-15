using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_RPG_Exercise
{
    internal class LivingEntity
    {
        public string Name { get; set; }
        private int _health;

        public int Health
        {
            get { return _health; }
            set
            {
                if (value > MaxHealth) _health = MaxHealth;
                else if (value < 0) _health = 0;
                else _health = value;
            }
        }
        public int MaxHealth { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }

    }
}
