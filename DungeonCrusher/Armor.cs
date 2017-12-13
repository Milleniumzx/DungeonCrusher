using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrusher
{
    class Armor : Item
    {
        public int ArmorValue;
        public double MoveSpeedPenalty; //do we want this?
        public int EquippedtoSlot; //do we want to have the slots as ints or strings? 1 could be body, 2 could be boots etc.

        public Armor(int value, int itemlevel, int rarity, int armorValue, double moveSpeedPenalty) : base(value, itemlevel, rarity)
        {
            ArmorValue = armorValue;
            MoveSpeedPenalty = moveSpeedPenalty;

        }
    }
}
