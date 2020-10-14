using System;

namespace FigureLibrary
{
    public class Square : Figure
    {
        /// <summary>
        /// The sides of the square.
        /// </summary>
        private double[] _side = new double[4];

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
                this._isValidFigure = false;
            }
        }

        // TODO: Подумать на сокращением кода.
        // Код, в которм идёт проверка точек и валидность фигуры.
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
