using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City awesomeCity = new City("awesomeCity")
            {
                Mayor = "Phil",
                Established = 1830
            };

            City funnyTown = new City("funnyTown")
            {
                Mayor = "Sage",
                Established = 1630
            };

            Building Old = new Building("123 smokey way", "Old")
            {
                Width = 10,
                Depth = 10,
                Stories = 20
            };
            Building New = new Building("222 heck yeah", "New")
            {
                Width = 1234,
                Depth = 543,
                Stories = 123
            };
            Building Haunted = new Building("666 spooky lane", "Haunted")
            {
                Width = 666,
                Depth = 800,
                Stories = 6
            };
            Building PhilTower = new Building("100 phil drive", "PhilTower")
            {
                Width = 123,
                Depth = 456,
                Stories = 50
            };
            Building KeatonHouse = new Building("123 Keaton Court", "KeatonHouse")
            {
                Width = 200,
                Depth = 200,
                Stories = 20
            };
            Building DylanPlaza = new Building("100 Pickle Drive", "DylanPlaza")
            {
                Width = 100,
                Depth = 200,
                Stories = 20
            };

            Old.Construct();
            Old.Purchase("Nate");
            //Console.WriteLine(Old.Description);
            awesomeCity.AddBuilding(Old);

            New.Construct();
            New.Purchase("Taylor");
            //Console.WriteLine(New.Description);
            awesomeCity.AddBuilding(New);

            Haunted.Construct();
            Haunted.Purchase("Heidi");
            //Console.WriteLine(Haunted.Description);
            awesomeCity.AddBuilding(Haunted);

            PhilTower.Construct();
            PhilTower.Purchase("Phil");
            //Console.WriteLine(PhilTower.Description);
            funnyTown.AddBuilding(PhilTower);

            KeatonHouse.Construct();
            KeatonHouse.Purchase("keaton");
            //Console.WriteLine(KeatonHouse.Description);
            funnyTown.AddBuilding(KeatonHouse);

            DylanPlaza.Construct();
            DylanPlaza.Purchase("Dylan");
            //Console.WriteLine(DylanPlaza.Description);
            funnyTown.AddBuilding(DylanPlaza);

            foreach (Building building in awesomeCity.Buildings)
            {
                Console.WriteLine($"{awesomeCity.Name} has the following buildings: {building.Name}");
            };

            foreach (Building building in funnyTown.Buildings)
            {
                Console.WriteLine($"{funnyTown.Name} has the following buildings: {building.Name}");
            };

        }
    }
}