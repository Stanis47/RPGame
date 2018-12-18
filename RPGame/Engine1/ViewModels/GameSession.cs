using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

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
        }
    }
}
