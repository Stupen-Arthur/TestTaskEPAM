using System;

namespace FigureLibrary.Figures
{
    public class Rectangle : Figure
    {
        /// <summary>
        /// The sides of the Rectangle.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Constructor for the figure - Rectangle.
        /// </summary>
        /// <param name="points">The corners of a rectangle, its points.</param>
        public Rectangle(Point[] points)
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

                if (_sides[0] == _sides[2] && _sides[1] == _sides[3] && _sides[0] == _sides[1])
                {
                    isValid = false;
                }

            }
            else
                isValid = false;

            return isValid;
        }

        protected override double MathFunctionArea()
        {
            return _sides[0] * _sides[1];
        }

        protected override double MathFunctionPerimeter()
        {
            return 2 * _sides[0] + 2 * _sides[1];
        }
    }
}
