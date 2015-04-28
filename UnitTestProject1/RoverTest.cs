using System;
using NUnit.Framework;
using RoverKata;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class RoverTest
    {
        private Rover rover;

        [SetUp]
        public void Init()
        {
            rover = new Rover(1, 1);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreEqual(1, rover.GetX());
            Assert.AreEqual(1, rover.GetY());
        }
        

        
    }
}
