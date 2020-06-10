using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Models.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

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
        }
    }
   
}