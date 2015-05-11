using System;
using RoverKata.Orientations;

namespace RoverKata
{
    public class Rover
    {
        private IOrientation orientation;

        public Map map = new Map(-5, -5, 5, 5);
        public Coordinate coordinate; 

        public Rover(int x, int y)
        {
            orientation = new OrientationNorth(); 
            X = x;
            Y = y;
            coordinate = new Coordinate(x, y);
        }


        public int X { get; set; }
        public int Y { get; set; }

        public void ReadCommands(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == 'f')
                {
                    if(!MoveForward()) break;
                }
                else if (c == 'b')
                {
                    if(!MoveBackward()) break;
                }
                else if (c == 'r') TurnRight();
                else if (c == 'l') TurnLeft();  
            }
        }

        public void SetOrientation(IOrientation o)
        {
            orientation = o;
        }

        public String GetOrientation()
        {
            return orientation.ToString();
        }

        public bool MoveForward()
        {
            return orientation.MoveForward(this);
        }

        public bool MoveBackward()
        {
            return orientation.MoveBackward(this);
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
