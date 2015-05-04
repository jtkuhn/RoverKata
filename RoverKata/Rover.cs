using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{

    abstract public class Orientation
    {
        public abstract void TurnLeft(Rover rover);
        public abstract void TurnRight(Rover rover);
        public abstract void MoveForward(Rover rover);
        public abstract void MoveBackward(Rover rover);
    }

    class OrientationEast : Orientation
    {
        public override String ToString()
        {
            return "east";
        }
        public override void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationNorth());
        }

        public override void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationSouth());
        }

        public override void MoveForward(Rover rover)
        {
            if (rover.X == rover.XLimitHigh) rover.X = rover.XLimitLow;
            else rover.X++;
        }

        public override void MoveBackward(Rover rover)
        {
            if (rover.X == rover.XLimitLow) rover.X = rover.XLimitHigh;
            else rover.X--;
        }
    }

    class OrientationWest : Orientation
    {
        public override String ToString()
        {
            return "west";
        }
        public override void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationSouth());
        }

        public override void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationNorth());
        }

        public override void MoveForward(Rover rover)
        {
            if (rover.X == rover.XLimitLow) rover.X = rover.XLimitHigh;
            else rover.X --;
        }

        public override void MoveBackward(Rover rover)
        {
            if (rover.X == rover.XLimitHigh) rover.X = rover.XLimitLow;
            else rover.X++;
        }
    }

    class OrientationNorth : Orientation
    {
        public override String ToString()
        {
            return "north";
        }
        public override void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationWest());
        }

        public override void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationEast());
        }

        public override void MoveForward(Rover rover)
        {
            if (rover.Y == rover.YLimitHigh) rover.Y = rover.YLimitLow;
            else rover.Y++;
        }

        public override void MoveBackward(Rover rover)
        {
            if (rover.Y == rover.YLimitLow) rover.Y = rover.YLimitHigh;
            else rover.Y--;
        }
    }

    class OrientationSouth : Orientation
    {

        public override String ToString()
        {
            return "south";
        }
        public override void TurnLeft(Rover rover)
        {
            rover.SetOrientation(new OrientationEast());
        }

        public override void TurnRight(Rover rover)
        {
            rover.SetOrientation(new OrientationWest());
        }

        public override void MoveForward(Rover rover)
        {
            if (rover.Y == rover.YLimitLow) rover.Y = rover.YLimitHigh;
            else rover.Y--;
        }

        public override void MoveBackward(Rover rover)
        {
            if (rover.Y == rover.YLimitHigh) rover.Y = rover.YLimitLow;
            else rover.Y++;
        }
    }


    public class Rover
    {
        private Orientation orientation;
        private int _x;
        private int _y;
        public int XLimitHigh = 5;
        public int XLimitLow = -5;
        public int YLimitHigh = 5;
        public int YLimitLow = -5;

        public Rover(int x, int y)
        {
            orientation = new OrientationNorth();
            _x = x;
            _y = y;
        }



        public void ReadCommands(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == 'f') MoveForward();
                else if (c == 'b') MoveBackward();
                else if (c == 'r') TurnRight();
                else if (c == 'l') TurnLeft();
            }
        }

        public void SetOrientation(Orientation o)
        {
            orientation = o;
        }
        public String GetOrientation()
        {
            return orientation.ToString();
        }

        public int X
        {
            get { return _x;}
            set { _x = value;}
        }

        public int Y    
        { 
            get { return _y; } 
            set { _y = value; } 
        }

        public void MoveForward()
        {
            orientation.MoveForward(this);
        }

        public void MoveBackward()
        {
            orientation.MoveBackward(this);
        }
        public void TurnLeft()
        {
            orientation.TurnLeft(this);
        }
        public void TurnRight()
        {
            orientation.TurnRight(this);
        }

    }
}
