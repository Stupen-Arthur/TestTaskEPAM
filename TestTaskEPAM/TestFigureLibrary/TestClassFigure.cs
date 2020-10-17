using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary;
using FigureLibrary.Figures;

namespace TestFigureLibrary
{
    [TestClass]
    public class TestClassFigure
    {
        /// <summary>
        /// Class: Square
        /// Method check: Construction
        /// Value: The coordinates of the square. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Square_Construction_CoordinatesSquare_true()
        {
            //Arrange
            Point[] points = new Point[4];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, 5);
            points[2] = new Point(5, 5);
            points[3] = new Point(5, 0);

            //Act
            Square square = new Square(points);

            //Assert
            if (square.Area != 0 && square.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        /// <summary>
        /// Class: Circle
        /// Method check: Construction
        /// Value: The coordinates of the circle. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Circle_Construction_CoordinatesCircle_true()
        {
            //Arrange
            Point[] points = new Point[2];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, 5);

            //Act
            Circle circle = new Circle(points);

            //Assert
            if (circle.Area != 0 && circle.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        /// <summary>
        /// Class: Triangle
        /// Method check: Construction
        /// Value: The coordinates of the triangle. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Triangle_Construction_CoordinatesTriangle_true()
        {
            //Arrange
            Point[] points = new Point[3];

            points[0] = new Point(0, 0);
            points[1] = new Point(5, 5);
            points[2] = new Point(5, 0);

            //Act
            Triangle triangle = new Triangle(points);

            //Assert
            if (triangle.Area != 0 && triangle.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        /// <summary>
        /// Class: Trapezoid
        /// Method check: Construction
        /// Value: The coordinates of the trapezoid. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Trapezoid_Construction_CoordinatesTrapezoid_true()
        {
            //Arrange
            Point[] points = new Point[4];

            points[0] = new Point(0, 0);
            points[1] = new Point(5, 5);
            points[2] = new Point(10, 5);
            points[3] = new Point(15, 0);

            //Act
            Trapezoid trapezoid = new Trapezoid(points);

            //Assert
            if (trapezoid.Area != 0 && trapezoid.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        /// <summary>
        /// Class: Rhombus
        /// Method check: Construction
        /// Value: The coordinates of the rhombus. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Rhombus_Construction_CoordinatesRhombus_true()
        {
            //Arrange
            Point[] points = new Point[4];

            points[0] = new Point(1, 0);
            points[1] = new Point(0, 2);
            points[2] = new Point(1, 4);
            points[3] = new Point(2, 2);

            //Act
            Rhombus rhombus = new Rhombus(points);

            //Assert
            if (rhombus.Area != 0 && rhombus.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        /// <summary>
        /// Class: Parallelogram
        /// Method check: Construction
        /// Value: The coordinates of the parallelogram. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Parallelogram_Construction_CoordinatesParallelogram_true()
        {
            //Arrange
            Point[] points = new Point[4];

            points[0] = new Point(0, 0);
            points[1] = new Point(1, 2);
            points[2] = new Point(2, 2);
            points[3] = new Point(1, 0);

            //Act
            Parallelogram parallelogram = new Parallelogram(points);

            //Assert
            if (parallelogram.Area != 0 && parallelogram.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }

        /// <summary>
        /// Class: Rectangle
        /// Method check: Construction
        /// Value: The coordinates of the rectangle. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void Rectangle_Construction_CoordinatesRectangle_true()
        {
            //Arrange
            Point[] points = new Point[4];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, 5);
            points[2] = new Point(10, 5);
            points[3] = new Point(10, 0);

            //Act
            Rectangle rectangle = new Rectangle(points);

            //Assert
            if (rectangle.Area != 0 && rectangle.Perimeter != 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }
    }
}
