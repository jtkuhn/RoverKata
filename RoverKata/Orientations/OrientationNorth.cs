using System;

namespace RoverKata.Orientations
{
    class OrientationNorth : IOrientation
    {
        public override String ToString()
        {
            return "north";
        }
        public void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationWest());
        }

        public void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationEast());
        }

        public virtual bool MoveForward(Rover rover)
        {
            return rover.map.ToNorth(rover);
        }

        public virtual bool MoveBackward(Rover rover)
        {
            return rover.map.ToSouth(rover);
        }
    }
}