using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    class Enchantment
    {
        public int Level;
        public Enchantment(int Level)
        {
            this.Level = Level;
        }
    }

    interface IEnchantment
    {
        void Modify(Damage damage);
    }

    class WeaponEnchantment : Enchantment, IEnchantment
    {

        public WeaponEnchantment(int Level) : base(Level)
        {

        }

        void IEnchantment.Modify(Damage damage) {}
    }

    class Sharpness : WeaponEnchantment
    {
        public void Modify(Damage damage)
        {
            damage.damage *= (float)Math.Pow(1.2, Level);
        }

        public Sharpness(int Level) : base(Level)
        {
            this.Level = Level;
        }
    }

    class Flaming : WeaponEnchantment
    {
        public void Modify(Damage damage)
        {
            damage.AddModifier(new Flame(Level));
        }

        public Flaming(int Level) : base(Level)
        {
            this.Level = Level;
        }
    }
}
