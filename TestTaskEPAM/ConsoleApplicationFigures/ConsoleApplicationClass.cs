using System;
using FigureLibrary;

namespace ConsoleApplicationFigures
{
    class ConsoleApplicationClass
    {
        private static void Main()
        {
            Point[] points = new Point[4];

            for (int index = 0; index < points.Length; index++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                points[index] = new Point(x,y);
            }

            Square square = new Square(points);

            Console.WriteLine();

            Console.WriteLine(square.Area);
            Console.WriteLine(square.Perimeter);

            Console.ReadKey();
;        }
    }
}
