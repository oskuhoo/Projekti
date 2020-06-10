using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.Models.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Osku",
                CharacterClass = "Mage",
                HitPoints = 1000,
                ExperiencePoints = 0,
                Level = 1,
                Gold = 1000000
            };

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }
    }
   
}