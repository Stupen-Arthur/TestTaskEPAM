using System;

namespace FigureLibrary.Figures
{
    public class Rhombus : Figure
    {
        /// <summary>
        /// The sides of the Rhombus.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Constructor for the figure - Rhombus.
        /// </summary>
        /// <param name="points">The corners of a rhombus, its points.</param>
        public Rhombus(Point[] points)
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
            return 0.5 * (LengthSide(Points[0], Points[2]) * LengthSide(Points[1], Points[3]));
        }

        protected override double MathFunctionPerimeter()
        {
            return 4 * _sides[0];
        }
    }
}
