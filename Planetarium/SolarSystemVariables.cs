using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetariumNS
{
    // Static class for variables used by planets class and GUI
    public static class SolarSystemVariables
    {
        // Astronomical Unit, defined in pixels
        static int oneAU = 25;
        public static int OneAU
        {
            get
            {
                return oneAU;
            }
            set
            {
                oneAU = value;
            }
        }

        // Base radius of Earth, defined in pixels; all other planets sized relatively                     
        static int baseRadius = 5;
        public static int BaseRadius
        {
            get
            {
                return baseRadius;
            }
            set
            {
                baseRadius = value;
            }
        }
    }
}
