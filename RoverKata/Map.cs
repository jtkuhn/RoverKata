using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{
    public class Map
    {
        public static int XUpperLim { get; set; }
        public static int XLowerLim { get; set; }
        public int YUpperLim { get; set; }
        public int YLowerLim { get; set; }


        public Map(int lowerX, int lowerY, int upperX, int upperY)
        {
            XUpperLim = upperX;
            XLowerLim = lowerX;
            YUpperLim = upperY;
            YLowerLim = lowerY;
        }

        public static bool toEast(Rover rover)
        {
            int nextX = 0;
            if (rover.X == XUpperLim) nextX = XLowerLim;
            else nextX = rover.X + 1;

            if (nextX == rover.ObstacleLocX && rover.Y == rover.ObstacleLocY) return false;

            rover.X = nextX;
            return true;
        }

        public static bool toWest(Rover rover)
        {
            int nextX = 0;
            if (rover.X == XLowerLim) nextX = XUpperLim;
            else nextX = rover.X - 1;

            if (nextX == rover.ObstacleLocX && rover.Y == rover.ObstacleLocY) return false;

            rover.X = nextX;
            return true;
        }

        public bool toNorth(Rover rover)
        {
            int nextY;
            if (rover.Y == YUpperLim) nextY = YLowerLim;
            else nextY = rover.Y + 1;

            if (nextY == rover.ObstacleLocY && rover.X == rover.ObstacleLocX) return false;

            rover.Y = nextY;
            return true;
        }

        public bool toSouth(Rover rover)
        {
            int nextY;
            if (rover.Y == YLowerLim) nextY = YUpperLim;
            else nextY = rover.Y - 1;

            if (nextY == rover.ObstacleLocY && rover.X == rover.ObstacleLocX) return false;

            rover.Y = nextY;
            return true;
        }
    }
}
