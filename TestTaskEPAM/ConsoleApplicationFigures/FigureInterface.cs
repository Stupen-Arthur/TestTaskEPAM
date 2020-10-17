using System.Collections.Generic;
using FigureLibrary;
using FigureLibrary.Figures;

namespace ConsoleApplicationFigures
{
    public class FigureInterface
    {
        /// <summary>
        /// An array of user-created figures.
        /// </summary>
        protected readonly List<Figure> Figures;

        /// <summary>
        /// Constructor of the FigureInterface class.
        /// </summary>
        public FigureInterface()
        {
            Figures = new List<Figure>();
        }

        /// <summary>
        /// Creates a new square and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateSquare(Point[] points)
        {
            bool isCreate = false;
            Square square = new Square(points);

            if (square.Perimeter != 0 && square.Area != 0)
            {
                Figures.Add(square);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Creates a new rhombus and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateRhombus(Point[] points)
        {
            bool isCreate = false;
            Rhombus rhombus = new Rhombus(points);

            if (rhombus.Perimeter != 0 && rhombus.Area != 0)
            {
                Figures.Add(rhombus);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Creates a new circle and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateCircle(Point[] points)
        {
            bool isCreate = false;
            Circle circle = new Circle(points);

            if (circle.Perimeter != 0 && circle.Area != 0)
            {
                Figures.Add(circle);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Creates a new triangle and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateTriangle(Point[] points)
        {
            bool isCreate = false;
            Triangle triangle = new Triangle(points);

            if (triangle.Perimeter != 0 && triangle.Area != 0)
            {
                Figures.Add(triangle);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Creates a new trapezoid and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateTrapezoid(Point[] points)
        {
            bool isCreate = false;
            Trapezoid trapezoid = new Trapezoid(points);

            if (trapezoid.Perimeter != 0 && trapezoid.Area != 0)
            {
                Figures.Add(trapezoid);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Creates a new parallelogram and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateParallelogram(Point[] points)
        {
            bool isCreate = false;
            Parallelogram parallelogram = new Parallelogram(points);

            if (parallelogram.Perimeter != 0 && parallelogram.Area != 0)
            {
                Figures.Add(parallelogram);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Creates a new rectangle and adds it to the figures.
        /// </summary>
        /// <param name="points">Points for create figures.</param>
        /// <returns>If the shape is created - true. Otherwise - else.</returns>
        public bool CreateRectangle(Point[] points)
        {
            bool isCreate = false;
            Rectangle rectangle = new Rectangle(points);

            if (rectangle.Perimeter != 0 && rectangle.Area != 0)
            {
                Figures.Add(rectangle);
                isCreate = true;
            }

            return isCreate;
        }

        /// <summary>
        /// Counts the average perimeter of all figures.
        /// </summary>
        /// <returns>Average perimeter</returns>
        public double AveragePerimeter()
        {
            int count = 0;
            double sumPerimeter = 0;

            foreach (Figure figure in Figures)
            {
                count++;
                sumPerimeter += figure.Perimeter;
            }

            return sumPerimeter / count;
        }

        /// <summary>
        /// Counts the average area of all figures.
        /// </summary>
        /// <returns>Average area</returns>
        public double AverageArea()
        {
            int count = 0;
            double sumArea = 0;

            foreach (Figure figure in Figures)
            {
                count++;
                sumArea += figure.Area;
            }

            return sumArea / count;
        }

        /// <summary>
        /// Finding the figure with the largest area.
        /// </summary>
        /// <returns>Figure.</returns>
        public Figure FindLargestArea()
        {
            Figure largestFigure = Figures[0];

            for (int index = 1; index < Figures.Count; index++)
            {
                if (largestFigure.Area < Figures[index].Area)
                    largestFigure = Figures[index];
            }

            return largestFigure;
        }

        /// <summary>
        /// Finds the figure type with the largest average perimeter among all other figure types.
        /// </summary>
        /// <returns>Type name.</returns>
        public string LargestAveragePerimeterAllType()
        {
            double[] sumPerimeterType = new double[7];
            int[] countElementType = new int[7];

            double[] averagePerimeterType = new double[7];

            foreach (Figure figure in Figures)
            {
                switch (figure.GetType().Name)
                {
                    case "Circle":
                        sumPerimeterType[0] += figure.Perimeter;
                        countElementType[0] += 1;
                        break;
                    case "Parallelogram":
                        sumPerimeterType[1] += figure.Perimeter;
                        countElementType[1] += 1;
                        break;
                    case "Rectangle":
                        sumPerimeterType[2] += figure.Perimeter;
                        countElementType[2] += 1;
                        break;
                    case "Rhombus":
                        sumPerimeterType[3] += figure.Perimeter;
                        countElementType[3] += 1;
                        break;
                    case "Square":
                        sumPerimeterType[4] += figure.Perimeter;
                        countElementType[4] += 1;
                        break;
                    case "Trapezoid":
                        sumPerimeterType[5] += figure.Perimeter;
                        countElementType[5] += 1;
                        break;
                    case "Triangle":
                        sumPerimeterType[6] += figure.Perimeter;
                        countElementType[6] += 1;
                        break;
                }
            }

            for (int index = 0; index < 7; index++)
            {
                if(countElementType[index] != 0) 
                    averagePerimeterType[index] = sumPerimeterType[index] / countElementType[index];
            }

            int posMaxAveragePerimeter = 0;

            for (int index = 1; index < 7; index++)
            {
                if (averagePerimeterType[posMaxAveragePerimeter] < averagePerimeterType[index])
                    posMaxAveragePerimeter = index;
            }

            string returnType = "";

            switch (posMaxAveragePerimeter)
            {
                case 0:
                    returnType = "Circle";
                    break;
                case 1:
                    returnType = "Parallelogram";
                    break;
                case 2:
                    returnType = "Rectangle";
                    break;
                case 3:
                    returnType = "Rhombus";
                    break;
                case 4:
                    returnType = "Square";
                    break;
                case 5:
                    returnType = "Trapezoid";
                    break;
                case 6:
                    returnType = "Triangle";
                    break;
            }

            return returnType;
        }
    }
}
