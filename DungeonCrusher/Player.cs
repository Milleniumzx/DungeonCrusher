using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrusher
{
    class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int LevelCap = 500;
        public int Health { get; set; }
        private int ConvertedVitality { get; set; }
        public int SkillExperience { get; set; }
        public int SkillPoints { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public Stats PlayerStats;

        //Stats are available in Stats.cs -> we could do a has-a relationship, thoughts?
        public Player(string name)
        {
            Name = name;
            Level = 1;
            Health = 100 + VitalityBonus();
            Experience = 0;
            SkillPoints = 0; //1 SkillPoint is gained for a level-up
            SkillExperience = 0; //Stored as currency to buy active skills at trainer
            Gold = 0;
            PlayerStats = new Stats();


        }




        public int VitalityBonus() //set to public to allow UI to show how much you gain from Vitality
        {
            ConvertedVitality = PlayerStats.Vitality * 10; //set to 10 as a placeholder

            return ConvertedVitality;
        }
    }
}
