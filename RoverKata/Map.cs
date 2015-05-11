using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{
    public class Map
    {
        public int XUpperLim { get; set; }
        public int XLowerLim { get; set; }
        public int YUpperLim { get; set; }
        public int YLowerLim { get; set; }
        public Coordinate obstacle1 = new Coordinate(3, 3);

        public Map(int lowerX, int lowerY, int upperX, int upperY)
        {
            XUpperLim = upperX;
            XLowerLim = lowerX;
            YUpperLim = upperY;
            YLowerLim = lowerY;
        }

        public bool ToEast(Rover rover)
        {
            int nextX = 0;
            if (rover.X == XUpperLim) nextX = XLowerLim;
            else nextX = rover.X + 1;

            if (nextX == obstacle1.X && rover.Y == obstacle1.Y) return false;

            rover.X = nextX;
            return true;
        }

        public bool ToWest(Rover rover)
        {
            int nextX = 0;
            if (rover.X == XLowerLim) nextX = XUpperLim;
            else nextX = rover.X - 1;

            if (nextX == obstacle1.X && rover.Y == obstacle1.Y) return false;

            rover.X = nextX;
            return true;
        }

        public bool ToNorth(Rover rover)
        {
            int nextY;
            if (rover.Y == YUpperLim) nextY = YLowerLim;
            else nextY = rover.Y + 1;

            if (nextY == obstacle1.Y && rover.X == obstacle1.X) return false;

            rover.Y = nextY;
            return true;
        }

        public bool ToSouth(Rover rover)
        {
            int nextY;
            if (rover.Y == YLowerLim) nextY = YUpperLim;
            else nextY = rover.Y - 1;

            if (nextY == obstacle1.Y && rover.X == obstacle1.X) return false;

            rover.Y = nextY;
            return true;
        }
    }
}
