using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrusher
{
    public class Monster
    {
        public int Level;
        public string Name;
        public int Health;
        public double Movespeed;



        public Monster(int level, string name, int health, int movespeed)
        {
            Level = level;
            Name = name;
            Health = health;
            Movespeed = movespeed;
        }
    }
}
