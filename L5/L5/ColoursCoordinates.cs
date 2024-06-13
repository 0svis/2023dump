using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    public class ColoursCoordinates
    {
        public string Colour { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        /// <summary>
        /// Colour Coordinates constructor without parameters
        /// </summary>
        public ColoursCoordinates()
        {
            Colour = "";
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Colour Coordinates constructor with parameters
        /// </summary>
        /// <param name="colour">Colour name</param>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public ColoursCoordinates(string colour, int x, int y)
        {
            Colour = colour;
            X = x;
            Y = y;
        }
        /// <summary>
        /// Overrided ToString method
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string line = string.Format("| {0, -8} | {1,-2} |" +
                " {2,-2} |", Colour, X, Y);
            return line;
        }
    }
}