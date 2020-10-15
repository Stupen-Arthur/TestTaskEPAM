using System;

namespace FigureLibrary
{
    /// <summary>
    /// An abstract class for defining general parameters of figures.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// The variable stores information about the existence of the figure.
        /// </summary>
        protected bool IsValidFigureForCreate = true;

        /// <summary>
        /// Figure area. Returns 0, if the figure does not exist.
        /// </summary>
        public double Area
        {
            get
            {
                if (IsValidFigureForCreate)
                    return MathFunctionArea();
                else
                    return 0;
            }
        }

        /// <summary>
        /// Figure perimeter. Returns 0, if the figure does not exist.
        /// </summary>
        public double Perimeter 
        {
            get
            {
                if (IsValidFigureForCreate)
                    return MathFunctionPerimeter();
                else
                    return 0;
            }
        }

        /// <summary>
        /// Figure points.
        /// </summary>
        public Point[] Points { get; set; }

        /// <summary>
        /// A method for checking points for equality.
        /// </summary>
        /// <param name="points">An array of points to check.</param>
        /// <returns>If there are no identical points - true. If there are identical points - false.</returns>
        protected bool IsValidPoints(Point[] points)
        {
            bool isValid = true;

            for (int indexOne = 0; indexOne < points.Length && isValid; indexOne++)
            {
                for (int indexTwo = indexOne + 1; indexTwo < points.Length && isValid; indexTwo++)
                {
                    if (points[indexOne] == points[indexTwo])
                        isValid = false;
                }
            }

            return isValid;
        }

        /// <summary>
        /// Method for calculating the side length of a figure.
        /// </summary>
        /// <param name="pointOne">Point - 1</param>
        /// <param name="pointTwo">Point - 2</param>
        /// <returns>Side length.</returns>
        public double LengthSide(Point pointOne, Point pointTwo)
        {
            double x = 0;
            double y = 0;

            x = Math.Pow((pointTwo.X - pointOne.X), 2);
            y = Math.Pow((pointTwo.Y - pointOne.Y), 2);

            return Math.Sqrt(x + y);
        }

        /// <summary>
        /// Mathematical function of area.
        /// </summary>
        protected abstract double MathFunctionArea();

        /// <summary>
        /// Mathematical function of perimeter.
        /// </summary>
        protected abstract double MathFunctionPerimeter();
    }
}
