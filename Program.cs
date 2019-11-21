using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // city DogCity = new City()
            List<Building> buildings = new List<Building>();
            Building Lilo = new Building("123 Lilo Street")
            {
                Width = 1_000,
                Depth = 3_000,
                Stories = 8
            };
            Building Tango = new Building("123 Tango Road")
            {
                Width = 3_000,
                Depth = 900,
                Stories = 4
            };

            Building Cash = new Building("123 Cash Court")
            {
                Width = 2_000,
                Depth = 800,
                Stories = 10
            };

            Lilo.Construct();
            Tango.Construct();
            Cash.Construct();
            Lilo.Purchase("Aryn");
            Tango.Purchase("Dylan");
            Cash.Purchase("Phil");

            City megalopolis = new City("Nashville", "Phil", 1799);
            megalopolis.ListOfBuildings.Add(Lilo);
            megalopolis.ListOfBuildings.Add(Tango);
            megalopolis.ListOfBuildings.Add(Cash);

            foreach (Building building in megalopolis.ListOfBuildings)
            {
                Console.WriteLine(building.Description);
            }
        }

    }
}