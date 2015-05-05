using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{
    public class Coordinate
    {
        private int xCoord;

        public int X
        {
            get { return xCoord; }
        }
        private int yCoord;

        public int Y
        {
            get { return yCoord; }
        }

        public Coordinate(int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public void AddToX(int delta)
        {
            xCoord += delta;
        }

        public void AddToY(int delta)
        {
            yCoord += delta;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", xCoord, yCoord);
        }
    }
}
