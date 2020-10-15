using System;
using System.Collections.Generic;
using FigureLibrary;

namespace ConsoleApplicationFigures
{
    public class FigureInterface
    {
        /// <summary>
        /// An array of user-created figures.
        /// </summary>
        private readonly List<Figure> _figures;

        /// <summary>
        /// Constructor of the FigureInterface class.
        /// </summary>
        public FigureInterface()
        {
            _figures = new List<Figure>();
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
                _figures.Add(square);
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

            foreach (Figure figure in _figures)
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

            foreach (Figure figure in _figures)
            {
                count++;
                sumArea += figure.Area;
            }

            return sumArea / count;
        }
    }
}
