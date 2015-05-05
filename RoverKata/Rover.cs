using System;
using RoverKata.Orientations;

namespace RoverKata
{
    public class Rover
    {
        private IOrientation orientation;
        public int ObstacleLocX = 3;
        public int ObstacleLocY = 3;

        public Map map = new Map();

        public Rover(int x, int y)
        {
            orientation = new OrientationNorth();
            X = x;
            Y = y;
        }



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

        public int X { get; set; }

        public int Y { get; set; }

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
