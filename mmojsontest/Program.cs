using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    class Program
    {
        public static Player P;
        static void Main(string[] args)
        {
            P = new Player();

            Weapon Sword = new Weapon("Sword", 10);
            Sword.Enchantments.Add(new Sharpness(5));
            var a = new JsonSerializerSettings();
            a.TypeNameHandling = TypeNameHandling.Objects;

            P.AddItem(Sword);
            string Convert = JsonConvert.SerializeObject(P, a);
            Console.WriteLine(Convert);

            Player P2 = JsonConvert.DeserializeObject<Player>(Convert, a);
            Weapon w = (Weapon)P2.Inventory[0];
            Console.WriteLine(w.Enchantments[0]);

            //LOAD PLAYER DATA

            //GAME LOGIC
            while (true)
            {

            }
        }
    }
}
