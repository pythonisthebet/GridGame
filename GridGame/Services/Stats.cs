using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame.Services
{
    public class Stats
    {
        public int Strength {  get; set; }
        public int Dexterity { get; set; }
        public int Intelligence {  get; set; }
        public int Luck {  get; set; }
        public int Charm {  get; set; }
        public static Random Random = new Random();
        public Stats() { Strength = Random.Next(1, 3); Dexterity = Random.Next(1, 3); Intelligence = Random.Next(1, 3); Luck = Random.Next(1, 3); Charm = 15 - (Strength + Dexterity + Intelligence + Luck); }//new cheracter
        public Stats(int str,int dex, int intel,int luk, int cha) { Strength = str; Dexterity = dex; Intelligence = intel; Luck = luk; Charm = cha; }//new companion/monster

    }
}
