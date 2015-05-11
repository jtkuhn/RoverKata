using System;

namespace RoverKata.Orientations
{
    class OrientationSouth : IOrientation
    {

        public override String ToString()
        {
            return "south";
        }
        public virtual void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationEast());
        }

        public virtual void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationWest());
        }

        public virtual bool MoveForward(Rover rover)
        {
            return rover.map.ToSouth(rover);
        }

        public virtual bool MoveBackward(Rover rover)
        {
            return rover.map.ToNorth(rover);
        }
    }
}