using PlanetariumNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetariumNS
{
    // Bit flags used, so moons not shown when parent planets not shown
    public enum PlanetType { None = 0x0, Star = 0x1, InnerPlanet = 0x2, Asteroid = 0x4, OuterPlanet = 0x8, DwarfPlanet = 0x10, Moon = 0x20 }

    class SolarSystem
    {
        public List<Planet> Planets;
        
        // Constructor
        public SolarSystem()
        {
            Random r = new Random();
            Planets = new List<Planet>();

            // Sun and Planets 
            Planet sun = new Planet("Sun", 0, 0, 1, Color.Yellow, PlanetType.Star, 0, "c:/temp/sun.png");
            Planet mercury = new Planet("Mercury", 88, 0.4, 0.4, Color.Red, PlanetType.InnerPlanet, 0, "c:/temp/mercury.png");
            Planet venus = new Planet("Venus", 225, 0.73, 0.95, Color.Gray, PlanetType.InnerPlanet, 0, "c:/temp/venus.png");
            Planet earth = new Planet("Earth", 365, 1.0, 1.0, Color.Blue, PlanetType.InnerPlanet, 0, "c:/temp/earth.png");
            Planet mars = new Planet("Mars", 687, 1.5, 0.5, Color.Red, PlanetType.InnerPlanet, 0, "c:/temp/mars.png");
            Planet jupiter = new Planet("Jupiter", 4332, 5.2, 11.0, Color.Orange, PlanetType.OuterPlanet, 0, "c:/temp/jupiter.png");
            Planet saturn = new Planet("Saturn", 10759, 9.5, 9.4, Color.SandyBrown, PlanetType.OuterPlanet, 0, "c:/temp/saturn.png");
            Planet uranus = new Planet("Uranus", 30688, 19.2, 3.9, Color.LightBlue, PlanetType.OuterPlanet, 0, "c:/temp/uranus.png");
            Planet neptune = new Planet("Neptune", 60182, 30.1, 3.8, Color.LightBlue, PlanetType.OuterPlanet, 0, "c:/temp/neptune.png");
            
            Planets.Add(sun);
            Planets.Add(mercury);
            Planets.Add(venus);
            Planets.Add(earth);
            Planets.Add(mars);
            Planets.Add(jupiter);
            Planets.Add(saturn);
            Planets.Add(uranus);
            Planets.Add(neptune);
            
            // Dwarf Planets
            Planet ceres = new Planet("Ceres", 1681, 2.7, 0.1, Color.Gray, PlanetType.DwarfPlanet);
            Planet pluto = new Planet("Pluto", 90581, 39.5, 0.18, Color.Gray, PlanetType.DwarfPlanet);
            Planet haumea = new Planet("Haumea", 103774, 43.2, 0.1, Color.Gray, PlanetType.DwarfPlanet);
            Planet makemake = new Planet("Makemake", 112897, 45.7, 0.1, Color.Gray, PlanetType.DwarfPlanet);
            Planet eris = new Planet("Eris", 203830, 67.7, 0.1, Color.Gray, PlanetType.DwarfPlanet);

            Planets.Add(ceres);
            Planets.Add(pluto);
            Planets.Add(haumea);
            Planets.Add(makemake);
            Planets.Add(eris);

            // Moons
            Moon moon = new Moon("Moon", 27, 0.15, 0.1, Color.Gray, PlanetType.Moon | PlanetType.InnerPlanet, earth);
            Moon phobos = new Moon("Phobos", 10, 0.1, 0.1, Color.Gray, PlanetType.Moon | PlanetType.InnerPlanet, mars);
            Moon deimos = new Moon("Deimos", 20, 0.15, 0.1, Color.Gray, PlanetType.Moon | PlanetType.InnerPlanet, mars);
            Moon io = new Moon("Io", 10, 1.2, 0.3, Color.Gray, PlanetType.Moon | PlanetType.OuterPlanet, jupiter);
            Moon europa = new Moon("Europa", 20, 1.3, 0.2, Color.Gray, PlanetType.Moon | PlanetType.OuterPlanet, jupiter);
            Moon ganymede = new Moon("Ganymede", 40, 1.4, 0.4, Color.Gray, PlanetType.Moon | PlanetType.OuterPlanet, jupiter);
            Moon callisto = new Moon("Callisto", 94, 1.5, 0.37, Color.Gray, PlanetType.Moon | PlanetType.OuterPlanet, jupiter);
            Moon titan = new Moon("Titan", 15, 1.5, 0.4, Color.Gray, PlanetType.Moon | PlanetType.OuterPlanet, saturn);
            Moon charon = new Moon("Charon", 10, 0.1, 0.1, Color.Gray, PlanetType.Moon | PlanetType.DwarfPlanet, pluto);

            Planets.Add(moon);
            Planets.Add(phobos);
            Planets.Add(deimos);
            Planets.Add(io);
            Planets.Add(europa);
            Planets.Add(ganymede);
            Planets.Add(callisto);
            Planets.Add(titan);
            Planets.Add(charon);

            // Saturns Rings !!!
            for (int i = 1; i <= 1000; i++)
            {
                Planets.Add(new Moon("", 200, RandomOrbitInAU(r, 1.15, 1.25), 0.1, Color.SandyBrown, PlanetType.OuterPlanet, saturn, RandomOrbitAngle(r)));
            }
            for (int i = 1; i <= 500; i++)
            {
                Planets.Add(new Moon("", 200, RandomOrbitInAU(r, 1.27, 1.28), 0.1, Color.Red, PlanetType.OuterPlanet, saturn, RandomOrbitAngle(r)));
            }
            for (int i = 1; i <= 1000; i++)
            {
                Planets.Add(new Moon("", 200, RandomOrbitInAU(r, 1.30, 1.40), 0.1, Color.Orange, PlanetType.OuterPlanet, saturn, RandomOrbitAngle(r)));
            }
            for (int i = 1; i <= 500; i++)
            {
                Planets.Add(new Moon("", 200, RandomOrbitInAU(r, 1.40, 1.41), 0.1, Color.Red, PlanetType.OuterPlanet, saturn, RandomOrbitAngle(r)));
            }
            
            // Asteroids !!!
            for (int i = 1; i <= 250; i++)
            {
                Planets.Add(new Planet("", RandomOrbitInEarthDays(r, 1000, 2000), RandomOrbitInAU(r, 2.30, 3.30), 0.1, Color.Gray, PlanetType.Asteroid, RandomOrbitAngle(r)));
            }
        }

        private int RandomOrbitInEarthDays(Random r, int minDays, int maxDays)
        {
            return r.Next(minDays, maxDays);
        }
        
        private double RandomOrbitInAU(Random r, double minOrbit, double maxOrbit)
        {
            return r.NextDouble() * (maxOrbit - minOrbit) + minOrbit;
        }

        private double RandomOrbitAngle(Random r)
        {
            return r.NextDouble() * ((2 * Math.PI) - 0.0001) + 0.0001;
        }
    }
}
