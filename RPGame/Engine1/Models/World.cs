using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location location = new Location()
            {
                XCoordinate = xCoordinate,
                YCoordinate = yCoordinate,
                Name = name,
                Description = description,
                ImageName = String.Format(@"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Locations\{0}", imageName)
            };

            _locations.Add(location);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
