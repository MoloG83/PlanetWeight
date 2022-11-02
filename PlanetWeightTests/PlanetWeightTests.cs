using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetWeights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWeights.Tests
{
    [TestClass()]
    public class PlanetWeightTests
    {
        private PlanetWeight? planetTest;

        [TestInitialize]
        public void testInit()
        {
            this.planetTest = new PlanetWeight();
        }

        //Testing calculations for each planet for equal and not equal
        [TestMethod()]
        public void WeightOnPlanetMercury_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.mercury;

            //Assert
            Assert.AreEqual(38, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetMercury_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.mercury;

            //Assert
            Assert.AreNotEqual(8, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetVenus_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.venus;

            //Assert
            Assert.AreEqual(91, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetVenus_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.venus;

            //Assert
            Assert.AreNotEqual(1, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetMoon_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.moon;

            //Assert
            Assert.AreEqual(17, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetMoon_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.moon;

            //Assert
            Assert.AreNotEqual(7, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetMars_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.mars;

            //Assert
            Assert.AreEqual(38, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetMars_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.mars;

            //Assert
            Assert.AreNotEqual(8, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetJupiter_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.jupiter;

            //Assert
            Assert.AreEqual(236, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetJupiter_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.jupiter;

            //Assert
            Assert.AreNotEqual(26, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetSaturn_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.saturn;

            //Assert
            Assert.AreEqual(92, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetSaturn_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.saturn;

            //Assert
            Assert.AreNotEqual(9, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetUranus_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.uranus;

            //Assert
            Assert.AreEqual(89, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetUranus_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.uranus;

            //Assert
            Assert.AreNotEqual(9, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetNeptune_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.neptune;

            //Assert
            Assert.AreEqual(112, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetNeptune_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.neptune;

            //Assert
            Assert.AreNotEqual(12, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetPluto_IsEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.pluto;

            //Assert
            Assert.AreEqual(7, Math.Round(weight.weightOnPlanet));
        }

        [TestMethod()]
        public void WeightOnPlanetPluto_IsNotEqual()
        {
            //Arrange
            PlanetWeight weight = new PlanetWeight();
            int newWeight = 100;

            //Act
            weight.weight = newWeight;
            weight.planet = Planets.pluto;

            //Assert
            Assert.AreNotEqual(77, Math.Round(weight.weightOnPlanet));
        }

    }

    [TestClass()]
    public class PlanetHeightTests
    {
        private PlanetWeight? heightTest;

        [TestInitialize]
        public void testInit()
        {
            this.heightTest = new PlanetWeight();
        }

        [TestMethod()]
        public void HeightOnPlanetMercury_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.mercury;

            //Assert
            Assert.AreEqual(110, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetVenus_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.venus;

            //Assert
            Assert.AreEqual(77.7, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetMoon_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.moon;

            //Assert
            Assert.AreEqual(320, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetMars_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.mars;

            //Assert
            Assert.AreEqual(244.5, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetJupiter_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.jupiter;

            //Assert
            Assert.AreEqual(90, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetSaturn_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.saturn;

            //Assert
            Assert.AreEqual(387, height.heightOnPlanet);
        }
        [TestMethod()]
        public void HeightOnPlanetUranus_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.uranus;

            //Assert
            Assert.AreEqual(533, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetNeptune_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.neptune;

            //Assert
            Assert.AreEqual(120.9, height.heightOnPlanet);
        }

        [TestMethod()]
        public void HeightOnPlanetPluto_IsEqual()
        {
            //Arrange
            PlanetWeight height = new PlanetWeight();
            int newHeight = 100;

            //Act
            height.height = newHeight;
            height.planet = Planets.pluto;

            //Assert
            Assert.AreEqual(730, height.heightOnPlanet);
        }
    }
}