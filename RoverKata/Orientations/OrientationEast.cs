using System;

namespace RoverKata.Orientations
{
    class OrientationEast : IOrientation
    {
        public override String ToString()
        {
            return "east";
        }

        public virtual void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationNorth());
        }

        public virtual void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationSouth());
        }

        public virtual bool MoveForward(Rover rover)
        {
            return rover.map.ToEast(rover);
        }

        public virtual bool MoveBackward(Rover rover)
        {
            return rover.map.ToWest(rover);
        }
    }
}