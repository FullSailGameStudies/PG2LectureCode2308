using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public class Knife : Weapon
    {
        public Knife(int range, int damage, bool serrated) : base(range, damage)
        {
            Serrated = serrated;
        }

        public bool Serrated { get; set; }
    }
}
