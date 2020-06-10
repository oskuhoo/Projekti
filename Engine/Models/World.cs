using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;

            locations.Add(loc);
        }

        public Location LocationAt(int XCoordinate, int yCoordinate)
        {
            foreach (Location loc in locations)
            {
                if (loc.XCoordinate == XCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
