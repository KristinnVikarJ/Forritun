using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmojsontest
{
    class Player : Entity
    {
        public List<Item> Inventory;
        public int SlotSize = 100;
        public int Mana = 100;

        public Player()
        {
            Inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if(Inventory.Count < SlotSize)
            {
                Inventory.Add(item);
            }
        }
    }
}
