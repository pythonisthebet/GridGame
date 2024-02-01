using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame.Services
{
    public class Equipment//what is equiped
    {
        public Tag Weapon {  get; set; }
        public Tag Armour { get; set; }
        public Tag Ring { get; set; }

    }

    public class Tag//in inventory and not equiped equipment
    {
        public string name {  get; set; }
        public string description {  get; set; }
        public int weaponStr {  get; set; }
        public int armourDef {  get; set; }
        public Stats RingStats {  get; set; }

    }
}
