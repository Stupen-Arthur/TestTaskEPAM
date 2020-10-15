using System;
using FigureLibrary;

namespace ConsoleApplicationFigures
{
    /// <summary>
    /// A class that contains methods for working with menus in the console.
    /// </summary>
    class ConsoleMenu : FigureInterface
    {
        /// <summary>
        /// A variable to store the user's choice.
        /// </summary>
        public int Choice { get; set; }

        /// <summary>
        /// Displays the global menu.
        /// </summary>
        public void ShowGlobalMenu()
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Add figure.");
            Console.WriteLine("2 - Read a file with figures.");
            Console.WriteLine("3 - Calculate the average perimeter and area of all figures.");
            Console.WriteLine("4 - Find the figure with the largest area.");
            Console.WriteLine("5 - Find the figure type with the largest average perimeter of all other figure types.");
        }

        /// <summary>
        /// Handles the user's selection in the global menu.
        /// </summary>
        public void UpdateGlobalMenu()
        {
            switch (Choice)
            {
                case 0:
                    break;
                case 1:
                    ShowAddFigureMenu();
                    break;
                case 3:
                    Console.WriteLine("Average perimeter of all figures: " + AveragePerimeter());
                    Console.WriteLine("Average area of all figures: " + AverageArea());
                    break;
            }
        }

        /// <summary>
        /// Figures creation selection menu.
        /// </summary>
        private void ShowAddFigureMenu()
        {
            Console.WriteLine("Select a figure");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Circle.");
            Console.WriteLine("2 - Square.");

            Choice = Convert.ToInt32(Console.ReadLine());

            UpdateAddFigureMenu();
        }

        /// <summary>
        /// Handling user input points.
        /// </summary>
        /// <param name="count">Number of points to input.</param>
        /// <returns>Array of point.</returns>
        private Point[] InputPoints(int count)
        {
            Point[] points = new Point[count];

            for (int index = 0; index < count; index++)
            {
                points[index] = new Point();

                Console.Write("X" + (index + 1) + ":");
                points[index].X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y" + (index + 1) + ":");
                points[index].Y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
            }

            return points;
        }

        /// <summary>
        /// Handles the user's selection in the AddFigure menu.
        /// </summary>
        private void UpdateAddFigureMenu()
        {
            switch (Choice)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    if (!CreateSquare(InputPoints(4)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }
                    break;

            }
        }
    }
}
