using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public abstract class Weapon
    {
        public Weapon(int range, int damage)
        {
            Range = range;
            Damage = damage;
        }

        public int Range { get; }
        public int Damage { get; }

        public void ShowMe()
        {
            Console.WriteLine($"Range: {Range} Damage: {Damage}");
        }
    }
}
