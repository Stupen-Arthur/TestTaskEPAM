using System;

namespace FigureLibrary
{
    /// <summary>
    /// Point class with x and y coordinates.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X coordinate.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Point class constructor.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }
    }
}
