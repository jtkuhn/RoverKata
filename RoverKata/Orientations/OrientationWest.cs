using System;

namespace RoverKata.Orientations
{
    class OrientationWest : IOrientation
    {
        public override String ToString()
        {
            return "west";
        }
        public void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationSouth());
        }

        public void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationNorth());
        }

        public virtual bool MoveForward(Rover rover)
        {
            return rover.map.ToWest(rover);
        }

        public virtual bool MoveBackward(Rover rover)
        {
            return rover.map.ToEast(rover);
        }
    }
}