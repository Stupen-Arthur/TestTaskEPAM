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
            Console.WriteLine("2 - Calculate the average perimeter and area of all figures.");
            Console.WriteLine("3 - Find the figure with the largest area.");
            Console.WriteLine("4 - Find the figure type with the largest average perimeter of all other figure types.");
            Console.WriteLine("5 - Show a table with figures.");
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
                    Console.Clear();
                    ShowAddFigureMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Average perimeter of all figures: " + AveragePerimeter());
                    Console.WriteLine("Average area of all figures: " + AverageArea());
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Largest area: " + FindLargestArea().Area);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Figure type with the largest average: " + LargestAveragePerimeterAllType());
                    break;
                case 5:
                    Console.Clear();
                    foreach (var figure in Figures)
                    {
                        Console.WriteLine(figure);
                    }

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
            Console.WriteLine("2 - Triangle");
            Console.WriteLine("3 - Square.");
            Console.WriteLine("4 - Rhombus.");
            Console.WriteLine("5 - Trapezoid");
            Console.WriteLine("6 - Parallelogram");
            Console.WriteLine("7 - Rectangle");

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
                string pointsX = Console.ReadLine();
                if (!String.IsNullOrEmpty(pointsX))
                    points[index].X = Convert.ToDouble(pointsX);
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid data entered. Input again.");
                    index--;
                    continue;
                }

                Console.Write("Y" + (index + 1) + ":");
                string pointsY = Console.ReadLine();
                if (!String.IsNullOrEmpty(pointsY))
                    points[index].Y = Convert.ToDouble(pointsY);
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid data entered. Input again.");
                    index--;
                    continue;
                }

                Console.WriteLine();
            }

            Console.Clear();

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
                    Console.Clear();
                    break;
                case 1:
                    Console.Clear();
                    if (!CreateCircle(InputPoints(2)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
                case 2:
                    Console.Clear();
                    if (!CreateTriangle(InputPoints(3)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
                case 3:
                    Console.Clear();
                    if (!CreateSquare(InputPoints(4)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
                case 4:
                    Console.Clear();
                    if (!CreateRhombus(InputPoints(4)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
                case 5:
                    Console.Clear();
                    if (!CreateTrapezoid(InputPoints(4)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
                case 6:
                    Console.Clear();
                    if (!CreateParallelogram(InputPoints(4)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
                case 7:
                    Console.Clear();
                    if (!CreateRectangle(InputPoints(4)))
                    {
                        Console.WriteLine("The points does not meet the creation criteria.");
                        Console.WriteLine("The figure was not created.");
                    }

                    break;
            }
        }
    }
}
