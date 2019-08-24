using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mmojsontest
{
    class Program
    {
        public static Player P;
        public static JsonSerializerSettings JsonSettings;
        static void Main(string[] args)
        {
            P = new Player();

            string weapons = string.Join("\n", FileManager.LoadFile(Environment.CurrentDirectory + "/Items/Weapons.json"));

            JsonSettings = new JsonSerializerSettings();
            JsonSettings.TypeNameHandling = TypeNameHandling.Objects;

            Dictionary<string, Weapon> Weapons = JsonConvert.DeserializeObject<Dictionary<string,Weapon>>(weapons, JsonSettings);
            foreach(KeyValuePair<string, Weapon> key in Weapons)
            {
                Console.WriteLine(key.Value.Name + " - " + key.Value.Damage);
            }

            /*
             * Create Selection Screen like
             * 
             * Slot 1
             * Slot 2
             * 
             * Movable with Arrow keys, run in game logic loop
             */

            while (true)
            {
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
            }
        }
    }
}
