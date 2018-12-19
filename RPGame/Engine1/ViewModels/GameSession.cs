using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Stanis",
                Class = "Warrior",
                HitPoints = 10,
                Level = 1,
                ExperiencePoints = 0,
                Gold = 100
            };

            CurrentLocation = new Location
            {
                Name = "Home",
                XCoordinate = 0,
                YCoordinate = -1,
                Description = "This is your house"
            };
        }
    }
}
