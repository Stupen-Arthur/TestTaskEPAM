using System;

namespace FigureLibrary
{
    public class Square : Figure
    {
        /// <summary>
        /// The sides of the square.
        /// </summary>
        private readonly double[] _side = new double[4];

        /// <summary>
        /// Constructor for the figure - square.
        /// </summary>
        /// <param name="points">The corners of a square, its points.</param>
        public Square(Point[] points)
        {
            if(IsValidFigure(points))
            {
                this.Points = points;
            }
            else
            {
                this.IsValidFigureForCreate = false;
            }
        }

        /// <summary>
        /// The method checks the conditions for the existence of the figure.
        /// </summary>
        /// <param name="points">Figure points.</param>
        /// <returns>If the figure exists - true. If the figure does not exist - false.</returns>
        private bool IsValidFigure(Point[] points)
        {
            bool isValid = true;

            if (points.Length == 4)
            {
                if(IsValidPoints(points))
                {
                    for (int index = 0; index < points.Length; index++)
                    {
                        if (index != 3)
                            _side[index] = LengthSide(points[index], points[index + 1]);
                        else
                            _side[index] = LengthSide(points[index], points[0]);
                    }
                }

                for (int indexOne = 0; indexOne < _side.Length && isValid; indexOne++)
                {
                    for (int indexTwo = indexOne + 1; indexTwo < _side.Length && isValid; indexTwo++)
                    {
                        if (_side[indexOne] != _side[indexTwo])
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
            return Math.Pow(_side[0],2);
        }

        protected override double MathFunctionPerimeter()
        {
            return 4*_side[0];
        }
    }
}
