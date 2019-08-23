using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    class Entity
    {
        public int Health = 100;

    }

    //Look into modifiers laters

    class Modifier
    {
        public int Level;
        public int Turns;

        public Modifier(int Level, int Turns)
        {
            this.Level = Level;
            this.Turns = Turns;
        }
    }

    class Flame : Modifier
    {
        public Flame(int Level) : base(Level, 2)
        {

        }
    }
}
