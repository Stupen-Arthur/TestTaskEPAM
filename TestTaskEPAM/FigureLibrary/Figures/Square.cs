using System;

namespace FigureLibrary.Figures
{
    public class Square : Figure
    {
        /// <summary>
        /// The sides of the square.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Constructor for the figure - square.
        /// </summary>
        /// <param name="points">The corners of a square, its points.</param>
        public Square(Point[] points)
        {
            if (IsValidFigure(points))
            {
                this.Points = points;
            }
            else
            {
                this.IsValidFigureForCreate = false;
            }
        }

        protected override bool IsValidFigure(Point[] points)
        {
            bool isValid = true;

            if (points.Length == 4)
            {
                if (IsValidPoints(points))
                {
                    _sides = CountSide(points);
                    if (LengthSide(points[0], points[2]) != LengthSide(points[1], points[3]))
                        isValid = false;
                }

                for (int indexOne = 0; indexOne < _sides.Length && isValid; indexOne++)
                {
                    for (int indexTwo = indexOne + 1; indexTwo < _sides.Length && isValid; indexTwo++)
                    {
                        if (_sides[indexOne] != _sides[indexTwo])
                            isValid = false;
                    }
                }

            }
            else
                isValid = false;

            return isValid;
        }

        protected override double MathFunctionArea()
        {
            return Math.Pow(_sides[0], 2);
        }

        protected override double MathFunctionPerimeter()
        {
            return 4 * _sides[0];
        }
    }
}
