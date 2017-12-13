using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrusher
{
    public class Weapon : Item
    {
        public int MaxDamage;
        public int MinDamage;
        public double AttackSpeed;
        public int DmgType; //int or string?


        public Weapon(int value, int itemlevel, int rarity) : base(value, itemlevel, rarity)
        {
            //cba to do this now. committing.


        }
    }
}
