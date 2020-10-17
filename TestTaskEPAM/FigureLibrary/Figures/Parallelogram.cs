using System;

namespace FigureLibrary.Figures
{
    public class Parallelogram : Figure
    {
        /// <summary>
        /// The sides of the Parallelogram.
        /// </summary>
        private double[] _sides;

        /// <summary>
        /// Constructor for the figure - Parallelogram.
        /// </summary>
        /// <param name="points">The corners of a parallelogram, its points.</param>
        public Parallelogram(Point[] points)
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

                if (!IsParallel(points[1], points[2], points[0], points[3]) &&
                    !IsParallel(points[0], points[1], points[3], points[2]))
                    isValid = false;

            }
            else
                isValid = false;

            return isValid;
        }

        protected override double MathFunctionArea()
        {
            double xVectorOne = Points[1].X - Points[0].X;
            double yVectorOne = Points[1].Y - Points[0].Y;

            double xVectorTwo = Points[3].X - Points[0].X;
            double yVectorTwo = Points[3].Y - Points[0].Y;

            double angleSin =
                Math.Sqrt(1 - Math.Pow(
                    (xVectorOne * xVectorTwo + yVectorOne * yVectorTwo) / _sides[0] * _sides[3], 2));

            double returnArea = _sides[0] * _sides[3] * angleSin;

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
