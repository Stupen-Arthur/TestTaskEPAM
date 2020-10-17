using System;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// The sides of the Circle.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Constructor for the figure - Circle.
        /// </summary>
        /// <param name="points">The corners of a circle, its points.</param>
        public Circle(Point[] points)
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

            if (points.Length == 2)
            {
                if (IsValidPoints(points))
                {
                    _sides = CountSide(points);
                }
            }
            else
                isValid = false;

            return isValid;
        }

        protected override double MathFunctionArea()
        {
            return Math.PI * Math.Pow(_sides[0], 2);
        }

        protected override double MathFunctionPerimeter()
        {
            return 2 * Math.PI * _sides[0];
        }
    }
}
