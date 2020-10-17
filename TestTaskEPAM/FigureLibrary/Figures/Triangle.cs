using System;

namespace FigureLibrary.Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// The sides of the Triangle.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Constructor for the figure - Triangle.
        /// </summary>
        /// <param name="points">The corners of a triangle, its points.</param>
        public Triangle(Point[] points)
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

            if (points.Length == 3)
            {
                if (IsValidPoints(points))
                {
                    _sides = CountSide(points);
                }

                if (_sides[0] + _sides[1] < _sides[2] || _sides[1] + _sides[2] < _sides[2] ||
                    _sides[2] + _sides[0] < _sides[1])
                    isValid = false;

            }
            else
                isValid = false;

            return isValid;
        }

        protected override double MathFunctionArea()
        {
            double semiPerimeter = MathFunctionPerimeter() / 2;

            double returnArea = Math.Sqrt(semiPerimeter * (semiPerimeter - _sides[0]) * (semiPerimeter - _sides[1]) *
                                          (semiPerimeter - _sides[2]));

            return returnArea;
        }

        protected override double MathFunctionPerimeter()
        {
            double returnSide = 0;

            foreach (double side in _sides)
            {
                returnSide += side;
            }

            return returnSide;
        }
    }
}
