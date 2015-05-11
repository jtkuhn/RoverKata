using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverKata
{
    public class Coordinate
    {
        private int _xCoord;
        private int _yCoord;


        public int X
        {
            get { return _xCoord; }
        }

        public int Y
        {
            get { return _yCoord; }
        }

        public Coordinate(int xCoord, int yCoord)
        {
            _xCoord = xCoord;
            _yCoord = yCoord;
        }

        public void AddToX(int delta)
        {
            _xCoord += delta;
        }

        public void AddToY(int delta)
        {
            _yCoord += delta;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", _xCoord, _yCoord);
        }
    }
}
