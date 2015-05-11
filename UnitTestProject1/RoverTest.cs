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
            Assert.AreEqual(1, rover.X);
            Assert.AreEqual(1, rover.Y);
        }

        [Test]
        public void TestOrientationStart()
        {
            Assert.AreEqual("north", rover.GetOrientation());
        }

        [Test]
        public void TestTurnLeft()
        {
            rover.TurnLeft();
            Assert.AreEqual("west", rover.GetOrientation());
            rover.TurnLeft();
            Assert.AreEqual("south", rover.GetOrientation());
            rover.TurnLeft();
            Assert.AreEqual("east", rover.GetOrientation());
            rover.TurnLeft();
            Assert.AreEqual("north", rover.GetOrientation());
        }

        [Test]
        public void TestTurnRight()
        {
            rover.TurnRight();
            Assert.AreEqual("east", rover.GetOrientation());
            rover.TurnRight();
            Assert.AreEqual("south", rover.GetOrientation());
            rover.TurnRight();
            Assert.AreEqual("west", rover.GetOrientation());
            rover.TurnRight();
            Assert.AreEqual("north", rover.GetOrientation());
        }

        [Test]
        public void TestMoveForward()
        {
            rover.MoveForward();
            Assert.AreEqual(2, rover.Y); 
            rover.TurnLeft();
            rover.MoveForward();
            Assert.AreEqual(0, rover.X);
            rover.TurnLeft();
            rover.MoveForward();
            Assert.AreEqual(1, rover.Y);
            rover.TurnLeft();
            rover.MoveForward();
            Assert.AreEqual(1, rover.X);
        }

        [Test]
        public void TestMoveBackward()
        {
            rover.MoveBackward();
            Assert.AreEqual(0, rover.Y);
            rover.TurnRight();
            rover.MoveBackward();
            Assert.AreEqual(0, rover.X);
            rover.TurnRight();
            rover.MoveBackward();
            Assert.AreEqual(1, rover.Y);
            rover.TurnRight();
            rover.MoveBackward();
            Assert.AreEqual(1, rover.X);
        }

        [Test]
        public void TestReadCommands()
        {
            rover.ReadCommands("ffrrffflfrrbb");
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual(4, rover.X);
        }

        [Test]
        public void TestWrapAround()
        {
            rover.ReadCommands("fffffffffff");
            Assert.AreEqual(1, rover.Y);
            rover.ReadCommands("bbbbbbbbbbb");
            Assert.AreEqual(1, rover.Y);
            rover.ReadCommands("rfffffffffff");
            Assert.AreEqual(1, rover.X);
            rover.ReadCommands("bbbbbbbbbbb");
            Assert.AreEqual(1, rover.X);
        }

        [Test]
        public void IfRoverHitsObstacle_StopsMovingForward()
        {
            rover.ReadCommands("ffrffff");
            Assert.AreEqual(2, rover.X);
            Assert.AreEqual(3, rover.Y);
        }

        [Test]
        public void IfRoverHitsObstacle_ItStopsMovingBackward()
        {
            rover.map.obstacle1 = new Coordinate(1, -1);
            rover.ReadCommands("bbb");
            Assert.AreEqual(1, rover.X);
            Assert.AreEqual(0, rover.Y);
        }
    }
}
