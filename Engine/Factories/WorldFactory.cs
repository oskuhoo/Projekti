using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home", "HAUS!!!");
            newWorld.AddLocation(0, 0, "Big Center", "Center of the map (NOT!)");
            newWorld.AddLocation(-1, -1, "Cave Entrance", "Some side are or something");

            newWorld.LocationAt(-1, -1).AddMonster(1, 100);

            newWorld.AddLocation(-2, -1, "Cave Shop", "Hey I found a shop, there's bunch of rocks, maybe Shungite. I should put those around La Casa");
            newWorld.AddLocation(0, 1, "Mountain", "Somehow you ended up here");

            newWorld.LocationAt(0, 1).AddMonster(2, 100);

            newWorld.AddLocation(0, 2, "Nothing", "Absolutely nothing");

            newWorld.LocationAt(0, 2).AddMonster(3, 100);

            return newWorld;
        }
    }
}
