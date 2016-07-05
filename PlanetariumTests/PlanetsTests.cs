using PlanetariumNS;
using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlanetariumTests
{
    [TestClass]
    public class PlanetsTests
    {
        // Re-factored arrange
        Planet p = new Planet();
        
        [TestMethod]
        public void Planet_Exists()
        {
            // arrange
            
            // act
            
            // assert
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void Planet_Name_SetsCorrectly()
        {
            // arrange

            // act
            p.Name = "Earth";

            // assert
            Assert.AreEqual("Earth", p.Name);
        }

        [TestMethod]
        public void Planet_Name_SetsCorrectly_Blank()
        {
            // arrange

            // act
            p.Name = "";

            // assert
            Assert.AreEqual("", p.Name);
        }

        [TestMethod]
        public void Planet_OrbitalPeriodInEarthDays_SetsCorrectly()
        {
            // arrange

            // act
            p.OrbitalPeriodInEarthDays = 365;

            // assert
            Assert.AreEqual(365, p.OrbitalPeriodInEarthDays);
        }

        [TestMethod]
        public void Planet_OrbitalPeriodInEarthDays_SetsCorrectlyZero()
        {
            // arrange

            // act
            p.OrbitalPeriodInEarthDays = 0;

            // assert
            Assert.AreEqual(0, p.OrbitalPeriodInEarthDays);
        }

        [TestMethod]
        public void Planet_OrbitalPeriodInEarthDays_Invalid()
        {
            // arrange

            try
            {
                // act
                p.OrbitalPeriodInEarthDays = -365;
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, Planet.OrbitalPeriodInEarthDaysOutOfRangeMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void Planet_RadiansPerTick_ReturnsCorrectValue()
        {
            // arrange
            p.Name = "Earth";
            p.OrbitalPeriodInEarthDays = 365;

            // act
            double result = p.RadiansPerTick();

            // assert
            Assert.AreEqual((2 * Math.PI) / 365, result);
        }

        [TestMethod]
        public void Planet_OrbitAngle_SetsCorrectly()
        {
            // arrange

            // act
            p.OrbitAngle = 0;

            // assert
            Assert.AreEqual(0, p.OrbitAngle);
        }

        [TestMethod]
        public void Planet_OrbitAngle_SetsCorrectly_Negative()
        {
            // arrange

            // act
            p.OrbitAngle = -1;

            // assert
            Assert.AreEqual(-1, p.OrbitAngle);
        }

        [TestMethod]
        public void Planet_IncOrbitAngle_ReturnsCorrectValue()
        {
            // arrange
            p.Name = "Earth";
            p.OrbitalPeriodInEarthDays = 365;
            p.OrbitAngle = 0;

            // act
            p.IncOrbitAngle();

            // assert
            Assert.AreEqual((0 + (2 * Math.PI) / 365), p.OrbitAngle);
        }

        [TestMethod]
        public void Planet_OrbitInAU_SetsCorrectly()
        {
            // arrange

            // act
            p.OrbitInAU = 1.0;

            // assert
            Assert.AreEqual(1.0, p.OrbitInAU);
        }

        [TestMethod]
        public void Planet_OrbitInAU_ReturnsErrorIfInvalid()
        {
            // arrange
                                    
            try
            {
                // act
                p.OrbitInAU = -1.0;
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, Planet.OrbitInAUOutOfRangeMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void Planet_SizeRelativeToEarth_SetsCorrectly()
        {
            // arrange

            // act
            p.SizeRelativeToEarth = 1.0;

            // assert
            Assert.AreEqual(1.0, p.SizeRelativeToEarth);
        }

        [TestMethod]
        public void Planet_SizeRelativeToEarth_Invalid()
        {
            // arrange

            try
            {
                // act
                p.SizeRelativeToEarth = -1.0;
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, Planet.SizeRelativeToEarthOutOfRangeMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void Planet_DrawOrbit_ReturnsCorrectValue()
        {
            // arrange
            int oneAUInPixels = 100;
            p.OrbitInAU = 1.0;
            
            // act
            int result = p.DrawOrbit(oneAUInPixels);

            // assert
            Assert.AreEqual(100, result);                        
        }

        [TestMethod]
        public void Planet_DrawSize_ReturnsCorrectValue()
        {
            // arrange
            int baseRadiusInPixels = 20;
            p.SizeRelativeToEarth = 1.0;

            // act
            int result = p.DrawSize(baseRadiusInPixels);

            // assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Planet_DrawSize_Given1Returns2()
        {
            // arrange
            int baseRadiusInPixels = 1;
            p.SizeRelativeToEarth = 1.0;

            // act
            int result = p.DrawSize(baseRadiusInPixels);

            // assert
            Assert.AreEqual(2, result);
        }
                
    }
}
