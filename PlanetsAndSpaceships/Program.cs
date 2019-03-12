using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> outerPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(outerPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            //planetList.Remove("Pluto");

            List<string> mercuryProbes = new List<string> { "Mariner 10", "MESSENGER", "BepiColombo", "Mio" };
            List<string> venusProbes = new List<string> { "Tyazhely Sputnik", "Venera 1", "Mariner 1", "Cosmos 21" };
            List<string> earthProbes = new List<string> { "Mariner 10", "Pioneer 10", "Pioneer 11", "Voyager" };
            List<string> marsProbes = new List<string> { "Mars 2", "Mariner 9", "Viking", "Phoenix" };
            List<string> jupiterProbes = new List<string> { "Mariner 3", "Zond", "Balloon" };
            List<string> saturnProbes = new List<string> { "Cassini", "Voyager 1" };
            List<string> uranusProbes = new List<string> { "Voyager 2" };
            List<string> neptuneProbes = new List<string> { "Voyager 2" };
            List<string> plutoProbes = new List<string> { "New Horizons" };

            var spacecrafts = new Dictionary<string, List<string>>();

            spacecrafts.Add(planetList[0], mercuryProbes);
            spacecrafts.Add(planetList[1], venusProbes);
            spacecrafts.Add(planetList[2], earthProbes);
            spacecrafts.Add(planetList[3], marsProbes);
            spacecrafts.Add(planetList[4], jupiterProbes);
            spacecrafts.Add(planetList[5], saturnProbes);
            spacecrafts.Add(planetList[6], uranusProbes);
            spacecrafts.Add(planetList[7], neptuneProbes);
            spacecrafts.Add(planetList[8], plutoProbes);

            foreach (var planet in planetList)
            {
                string planetShuttles = "";
                foreach (var shuttle in spacecrafts[planet])
                {
                    planetShuttles += $"{shuttle}, ";
                }
                string finalString = planetShuttles.Remove(planetShuttles.Length - 2);
                Console.WriteLine($"{ planet}: {finalString}");
            }

            Console.ReadKey();

        }
    }
}
