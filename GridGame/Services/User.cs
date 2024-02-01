using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame.Services
{
    public class User
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public bool Adult { get; set; }
        public object Picture { get; set; }
        public User() { }
        public User(string name, string sex, bool adult, object picture) 
        { 
            Name = name;
            Sex = sex;
            Adult = adult;
            Picture = picture;
        }
    }

    public class Cheracter : User// a cheractes class for you and enemies
    {
        public int Level { get; set; }
        public int Xp { get; set; }
        public Stats Stats { get; set; }
        public static Point Position { get; set; } = new Point();
        public Equipment Equip {get; set;}
        public Cheracter Companion { get; set;}
        public List<Equipment> Inventory { get; set;}

        public Cheracter(User user) : base(user.Name, user.Sex, user.Adult, user.Picture) { Level = 1; Xp = 0; Equip = new Equipment(); Companion = null; Inventory = new List<Equipment>(); Stats = new Stats(); }

        public Cheracter(string sex, object pic, int lv, Equipment equip, Stats stats) { Sex = sex; Picture = pic; Level = lv; Equip = equip; Stats = stats; }//for companions and enemies
    }


}
