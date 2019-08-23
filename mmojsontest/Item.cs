using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    class Item
    {
        public string Name;
        public List<Enchantment> Enchantments;
        public Item()
        {
            this.Enchantments = new List<Enchantment>();
        }
    }

    interface IEquippable
    {

    }

    class Damage
    {
        public float damage;

        public List<Modifier> Modifiers;

        public Damage(int Damage)
        {
            damage = Damage;
        }

        public void AddModifier(Modifier m)
        {
            Modifiers.Add(m);
        }
    }
}
