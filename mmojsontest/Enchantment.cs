using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    abstract class Enchantment
    {
        public int Level;

        public abstract void Modify(Damage d); //let the derived class change the method
    }

    class Sharpness : Enchantment
    {
        public override void Modify(Damage damage)
        {
            damage.damage *= (float)Math.Pow(1.2, Level);
        }

        public Sharpness(int Level)
        {
            this.Level = Level;
        }
    }

    class Flaming : Enchantment
    {
        public override void Modify(Damage damage)
        {
            damage.AddModifier(new Flame(Level));
        }

        public Flaming(int Level)
        {
            this.Level = Level;
        }
    }
}
