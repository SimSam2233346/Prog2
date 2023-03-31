using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

class Robot
        {
            public int ID { get; }
            public List<string> Pieces { get; }

            public Robot(int id, List<string> pieces)
            {
                ID = id;
                Pieces = pieces;
            }
        }

        class Building
        {
            public int ID { get; }
            public int X { get; }
            public int Y { get; }
            public string Status { get; set; }
            public int Resources { get; set; }
            public int Priority { get; }

            public Building(int id, int x, int y, string status, int resources, int priority)
            {
                ID = id;
                X = x;
                Y = y;
                Status = status;
                Resources = resources;
                Priority = priority;
            }
        }

        class City
        {
            public List<Building> Buildings { get; }
            public int Width { get; }
            public int Height { get; }
            public int FactoryX { get; }
            public int FactoryY { get; }

            public City(List<Building> buildings, int width, int height, int factoryX, int factoryY)
            {
                Buildings = buildings;
                Width = width;
                Height = height;
                FactoryX = factoryX;
                FactoryY = factoryY;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Partie sans défi : ville avec 5 bâtiments
                Building b1 = new Building(1, 1, 1, "Parfait", 0, 1);
                Building b2 = new Building(2, 2, 2, "Nécessite réparation", 10, 2);
                Building b3 = new Building(3, 3, 3, "Doit être démoli", 0, 3);
                Building b4 = new Building(4, 4, 4, "Parfait", 0, 4);
                Building b5 = new Building(5, 5, 5, "Nécessite réparation", 5, 5);

                List<Building> buildings = new List<Building>();
                buildings.Add(b1);
                buildings.Add(b2);
                buildings.Add(b3);
                buildings.Add(b4);
                buildings.Add(b5);

                City city = new City(buildings, 10, 10, 0, 0);

                List<Robot> robots = new List<Robot>();

                while (!IsCityComplete(city))
                {
                    // Évaluation de l'état des bâtiments
                    foreach (Building b in city.Buildings)
                    {
                        if (b.Status == "Doit être démoli")
                        {
                            DestroyBuilding(b);
                        }
                        else if (b.Status == "Nécessite réparation" && b.Resources >= 5)
                        {
                            RepairBuilding(b);
                        }
                        else if (b.Status == "Parfait
        
        }
                }
}
