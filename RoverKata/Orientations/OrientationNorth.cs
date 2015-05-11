using System;

namespace RoverKata.Orientations
{
    class OrientationNorth : IOrientation
    {
        public override String ToString()
        {
            return "north";
        }
        public virtual void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationWest());
        }

        public virtual void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationEast());
        }

        public virtual bool MoveForward(Rover rover)
        {
            return rover.map.toNorth(rover);
        }

        public virtual bool MoveBackward(Rover rover)
        {
            return rover.map.toSouth(rover);
        }
    }
}