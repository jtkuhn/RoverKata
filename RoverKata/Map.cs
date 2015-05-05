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

        public Map(int lowerX, int lowerY, int upperX, int upperY)
        {
            XUpperLim = upperX;
            XLowerLim = lowerX;
            YUpperLim = upperY;
            YLowerLim = lowerY;
        }

        //public toEast();
        //public toWest();
    }
}
