using System;

namespace FigureLibrary.Figures
{
    public class Trapezoid : Figure
    {
        /// <summary>
        /// The sides of the Trapezoid.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Keeps in itself which pair of sides is parallel.
        /// </summary>
        private int _pairSides;

        /// <summary>
        /// Constructor for the figure - Trapezoid.
        /// </summary>
        /// <param name="points">The corners of a trapezoid, its points.</param>
        public Trapezoid(Point[] points)
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
            bool isValid;

            if (points.Length == 4)
            {
                if (IsValidPoints(points))
                {
                    _sides = CountSide(points);
                }

                if (IsParallel(points[1], points[2], points[0], points[3]) &&
                    IsParallel(points[0], points[1], points[3], points[2]))
                    isValid = false;
                else if (IsParallel(points[1], points[2], points[0], points[3]) &&
                         !IsParallel(points[0], points[1], points[3], points[2]))
                {
                    isValid = true;
                    _pairSides = 1;
                }
                else if (!IsParallel(points[1], points[2], points[0], points[3]) &&
                         IsParallel(points[0], points[1], points[3], points[2]))
                {
                    isValid = true;
                    _pairSides = 2;
                }
                else
                    isValid = false;

            }
            else
                isValid = false;

            return isValid;
        }

        protected override double MathFunctionArea()
        {
            double averageLine = 0;
            double area = 0;

            if (_pairSides == 1)
                averageLine = (_sides[3] + _sides[1]) / 2;
            else if (_pairSides == 2)
                averageLine = (_sides[2] + _sides[0]) / 2;

            if (_pairSides == 1)
            {
                double groundA = Math.Pow(_sides[3] - _sides[1], 2) + Math.Pow(_sides[0], 2) - Math.Pow(_sides[2], 2);
                double groundB = 2 * (_sides[3] - _sides[1]);

                area = averageLine * Math.Sqrt(Math.Pow(_sides[0], 2) - Math.Pow(groundA / groundB, 2));
            }
            else if (_pairSides == 2)
            {
                double groundA = Math.Pow(_sides[2] - _sides[0], 2) + Math.Pow(_sides[1], 2) - Math.Pow(_sides[3], 2);
                double groundB = 2 * (_sides[2] - _sides[0]);

                area = averageLine * Math.Sqrt(Math.Pow(_sides[3], 2) - Math.Pow(groundA / groundB, 2));
            }

            return area;
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
