using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrusher
{
    public class Item
    {
        public int Value;   
        public int ItemLevel;   
        public int Rarity; //0 for white, 1 for green, 2 for blue, 3 for purple, 4 for legendary - so far.


        public Item(int value, int itemlevel, int rarity)
        {
            Value = value;
            ItemLevel = itemlevel;
            Rarity = rarity;
        }
    }
}
