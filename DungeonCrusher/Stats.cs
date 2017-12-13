using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrusher
{
    public class Stats
    {
        public int Vitality { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public double MoveSpeed { get; set; }



        public Stats()
        {
            MoveSpeed = 1;
            Strength = 1;
            Dexterity = 1;
            Vitality = 1;
        }
    }
}
