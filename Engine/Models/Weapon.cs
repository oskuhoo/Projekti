using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDmg { get; set; }
        public int MaximumDmg { get; set; }
        public int Strikes { get; set; }

        public Weapon(int itemTypeID, string name, int price, int minDmg, int maxDmg, int strikes) : base(itemTypeID, name, price)
        {
            MinimumDmg = minDmg;
            MaximumDmg = maxDmg;
            Strikes = strikes;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDmg, MaximumDmg, Strikes);
        }
    }
}
