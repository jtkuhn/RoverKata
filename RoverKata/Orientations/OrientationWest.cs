using System;

namespace RoverKata.Orientations
{
    class OrientationWest : IOrientation
    {
        public override String ToString()
        {
            return "west";
        }
        public virtual void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationSouth());
        }

        public virtual void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationNorth());
        }

        public virtual bool MoveForward(Rover rover)
        {
            return Map.toWest(rover);
        }

        public virtual bool MoveBackward(Rover rover)
        {
            return Map.toEast(rover);
        }
    }
}