using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    class Weapon : Item, IEquippable
    {
        public int Damage;

        public Weapon(string Name, int Damage)
        {
            this.Name = Name;
            this.Damage = Damage;
        }
    }
}
