using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RoverKata;

namespace UnitTestProject1
{
    [TestFixture]
    internal class CoordinateTest
    {
        private Coordinate testCoordinate;

        [Test]
        public void WhenConstructorFires_NoExceptionsAreThrown()
        {
            testCoordinate = new Coordinate(1, 1);
        }

        [Test]
        public void WhenConstructorFires_XIsInitialized()
        {
            const int expected = -4;
            testCoordinate = new Coordinate(expected, 6);
            Assert.AreEqual(expected, testCoordinate.X);
        }


        [Test]
        public void WhenConstructorFires_YIsInitialized()
        {
            const int expected = 112;
            testCoordinate = new Coordinate(2, expected);
            Assert.AreEqual(expected, testCoordinate.Y);
        }

        [Test]
        public void AddToX_WorksWithPositiveNumber()
        {
            testCoordinate = new Coordinate(1, 1);
            testCoordinate.AddToX(1);
            Assert.AreEqual(2, testCoordinate.X);
        }

        [Test]
        public void AddToX_WorksWithNegativeNumber()
        {
            testCoordinate = new Coordinate(1, 1);
            testCoordinate.AddToX(-2);
            Assert.AreEqual(-1, testCoordinate.X);
        }


        [Test]
        public void AddToY_WorksWithPositiveNumber()
        {
            testCoordinate = new Coordinate(1, 1);
            testCoordinate.AddToY(1);
            Assert.AreEqual(2, testCoordinate.Y);
        }

        [Test]
        public void AddToY_WorksWithNegatives()
        {
            testCoordinate = new Coordinate(1, 1);
            testCoordinate.AddToY(-3);
            Assert.AreEqual(-2, testCoordinate.Y);
        }
    }
}
