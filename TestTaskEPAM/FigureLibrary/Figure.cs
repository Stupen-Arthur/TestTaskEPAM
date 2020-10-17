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
        /// Figure points.
        /// </summary>
        public Point[] Points { get; set; }

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
        /// A method for checking points for equality.
        /// </summary>
        /// <param name="points">An array of points to check.</param>
        /// <returns>If there are no identical points - true. If there are identical points - false.</returns>
        public static bool IsValidPoints(Point[] points)
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
        /// The method checks the conditions for the existence of the figure.
        /// </summary>
        /// <param name="points">Figure points.</param>
        /// <returns>If the figure exists - true. If the figure does not exist - false.</returns>
        protected abstract bool IsValidFigure(Point[] points);

        protected double[] CountSide(Point[] points)
        {
            double[] side = new double[points.Length];

            for (int index = 0; index < points.Length; index++)
            {
                if (index != points.Length - 1)
                    side[index] = LengthSide(points[index], points[index + 1]);
                else
                    side[index] = LengthSide(points[index], points[0]);
            }

            return side;
        }

        /// <summary>
        /// Method for calculating the side length of a figure.
        /// </summary>
        /// <param name="pointOne">Point - 1</param>
        /// <param name="pointTwo">Point - 2</param>
        /// <returns>Side length.</returns>
        public static double LengthSide(Point pointOne, Point pointTwo)
        {
            double x = Math.Pow((pointTwo.X - pointOne.X), 2);
            double y = Math.Pow((pointTwo.Y - pointOne.Y), 2);

            return Math.Sqrt(x + y);
        }

        /// <summary>
        /// Checks a vector for parallelism.
        /// </summary>
        /// <param name="firstPointVectorOne">The starting point of the vector - One.</param>
        /// <param name="secondPointVectorOne">The end point of the vector - One.</param>
        /// <param name="firstPointVectorTwo">The starting point of the vector - Two.</param>
        /// <param name="secondPointVectorTwo">The end point of the vector - Two.</param>
        /// <returns>If the vectors are parallel - True. Otherwise - false.</returns>
        public static bool IsParallel(Point firstPointVectorOne, Point secondPointVectorOne, Point firstPointVectorTwo,
            Point secondPointVectorTwo)
        {
            bool isParallel = false;

            double xVectorOne = secondPointVectorOne.X - firstPointVectorOne.X;
            double yVectorOne = secondPointVectorOne.Y - firstPointVectorOne.Y;

            double xVectorTwo = secondPointVectorTwo.X - firstPointVectorTwo.X;
            double yVectorTwo = secondPointVectorTwo.Y - firstPointVectorTwo.Y;

            double ratioX;
            double ratioY;

            if ((xVectorOne == 0 && xVectorTwo == 0) || (yVectorOne == 0 && yVectorTwo == 0))
            {
                ratioY = 1;
                ratioX = 1;
            }
            else
            {
                if (xVectorTwo != 0 && yVectorTwo != 0)
                {
                    ratioX = xVectorOne / xVectorTwo;
                    ratioY = yVectorOne / yVectorTwo;
                }
                else
                {
                    if (xVectorTwo == 0 && yVectorTwo != 0)
                    {
                        ratioX = 1;
                        ratioY = yVectorOne / yVectorTwo;

                    }
                    else
                    {
                        if (xVectorTwo != 0 && yVectorTwo == 0)
                        {
                            ratioX = xVectorOne / xVectorTwo;
                            ratioY = 1;
                        }
                        else
                        {
                            ratioX = 1;
                            ratioY = 1;
                        }
                    }
                }
            }

            if (ratioX == ratioY)
            {
                isParallel = true;
            }

            return isParallel;
        }

        /// <summary>
        /// Mathematical function of area.
        /// </summary>
        protected abstract double MathFunctionArea();

        /// <summary>
        /// Mathematical function of perimeter.
        /// </summary>
        protected abstract double MathFunctionPerimeter();

        public override string ToString()
        {
            string returnString = "";

            returnString += "Name figure: " + GetType().Name + Environment.NewLine;
            returnString += "The perimeter of the figure: " + Perimeter + Environment.NewLine;
            returnString += "The area of the figure: " + Area + Environment.NewLine;

            return returnString;
        }
    }
}
