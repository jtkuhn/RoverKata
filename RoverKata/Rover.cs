using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{

    abstract class Orientation
    {
        protected int x;
        protected int y;
        public abstract void MoveForward(Rover rover);
        public abstract void MoveBackward(Rover rover);
        public abstract void TurnLeft(Rover rover);
        public abstract void TurnRight(Rover rover);
    }

    class OrientationEast : Orientation
    {
        public override void MoveForward(Rover rover)
        {
            x++;
        }
        public override void MoveBackward(Rover rover)
        {
            x--;
        }
        public override void TurnLeft(Rover rover)
        {
            throw new NotImplementedException();
        }

        public override void TurnRight(Rover rover)
        {
            throw new NotImplementedException();
        }
    }

    class OrientationWest : Orientation
    {
        public override void MoveForward(Rover rover)
        {
            x--;
        }

        public override void MoveBackward(Rover rover)
        {
            x++;
        }

        public override void TurnLeft(Rover rover)
        {
            throw new NotImplementedException();
        }

        public override void TurnRight(Rover rover)
        {
            throw new NotImplementedException();
        }
    }

    class OrientationNorth : Orientation
    {
        public override void MoveForward(Rover rover)
        {
            y++;
        }

        public override void MoveBackward(Rover rover)
        {
            y--;
        }

        public override void TurnLeft(Rover rover)
        {
            throw new NotImplementedException();
        }

        public override void TurnRight(Rover rover)
        {
            throw new NotImplementedException();
        }
    }

    class OrientationSouth : Orientation
    {
        public override void MoveForward(Rover rover)
        {
            y++;
        }

        public override void MoveBackward(Rover rover)
        {
            y--;
        }

        public override void TurnLeft(Rover rover)
        {
            throw new NotImplementedException();
        }

        public override void TurnRight(Rover rover)
        {
            throw new NotImplementedException();
        }
    }


    public class Rover
    {
        private Orientation orientation = new OrientationEast();
        private int x;
        private int y;

        public Rover(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

    }
}
