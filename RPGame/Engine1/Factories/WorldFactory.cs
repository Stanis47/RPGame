using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\FarmFields.png");

            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\Farmhouse.png");

            newWorld.AddLocation(0, -1, "Home",
                "This is your home",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\Home.png");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\Trader.png");

            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\SpiderForest.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                @"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\HerbalistsGarden.png");

            return newWorld;
        }
    }
}
