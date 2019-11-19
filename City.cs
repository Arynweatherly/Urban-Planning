using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public City(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Mayor { get; set; }

        public int Established { get; set; }

        public List<Building> Buildings { get; set; } = new List<Building>();

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
    }
}