using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home", "HAUS!!!");
            newWorld.AddLocation(0, 0, "Big Center", "Center of the map (NOT!)");
            newWorld.AddLocation(-1, -1, "Cave Entrance", "Some side are or something");
            newWorld.AddLocation(-2, -1, "Cave Shop", "Hey I found a shop, there's bunch of rocks, maybe Shungite. I should put those around La Casa");

            return newWorld;
        }
    }
}
