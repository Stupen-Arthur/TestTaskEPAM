using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary;
using FigureLibrary.Figures;
using ConsoleApplicationFigures;

namespace TestFigureLibrary
{
    [TestClass]
    public class TestClassFigureInterface
    {
        /// <summary>
        /// Class: FigureInterface
        /// Method check: AddFigureAndCreateFigure
        /// Value: The coordinates of the rectangle and square. Class point.
        /// Result: Area and perimeter not equal to zero.
        /// </summary>
        [TestMethod]
        public void FigureInterface_AddFigureAndCreateFigure_CoordinatesRectangleAndSquare_true()
        {
            //Arrange
            Point[] pointsOne = new Point[4];

            pointsOne[0] = new Point(0, 0);
            pointsOne[1] = new Point(0, 5);
            pointsOne[2] = new Point(10, 5);
            pointsOne[3] = new Point(10, 0);

            Point[] pointsTwo = new Point[4];

            pointsTwo[0] = new Point(0, 0);
            pointsTwo[1] = new Point(0, 5);
            pointsTwo[2] = new Point(5, 5);
            pointsTwo[3] = new Point(5, 0);


            //Act
            FigureInterface figureInterface = new FigureInterface();

            //Assert
            Assert.IsTrue(figureInterface.CreateRectangle(pointsOne));
            Assert.IsTrue(figureInterface.CreateSquare(pointsTwo));
        }

        /// <summary>
        /// Class: FigureInterface
        /// Method check: AverageArea
        /// Value: The coordinates of the rectangle and square. Class point.
        /// Result: 37.5 .
        /// </summary>
        [TestMethod]
        public void FigureInterface_AverageArea_CoordinatesRectangleAndSquare_37dot5()
        {
            //Arrange
            Point[] pointsOne = new Point[4];

            pointsOne[0] = new Point(0, 0);
            pointsOne[1] = new Point(0, 5);
            pointsOne[2] = new Point(10, 5);
            pointsOne[3] = new Point(10, 0);

            Point[] pointsTwo = new Point[4];

            pointsTwo[0] = new Point(0, 0);
            pointsTwo[1] = new Point(0, 5);
            pointsTwo[2] = new Point(5, 5);
            pointsTwo[3] = new Point(5, 0);


            //Act
            FigureInterface figureInterface = new FigureInterface();

            figureInterface.CreateRectangle(pointsOne);
            figureInterface.CreateSquare(pointsTwo);
            //Assert
            Assert.AreEqual(37.5,figureInterface.AverageArea());
        }

        /// <summary>
        /// Class: FigureInterface
        /// Method check: AveragePerimeter
        /// Value: The coordinates of the rectangle and square. Class point.
        /// Result: 25 .
        /// </summary>
        [TestMethod]
        public void FigureInterface_AveragePerimeter_CoordinatesRectangleAndSquare_25()
        {
            //Arrange
            Point[] pointsOne = new Point[4];

            pointsOne[0] = new Point(0, 0);
            pointsOne[1] = new Point(0, 5);
            pointsOne[2] = new Point(10, 5);
            pointsOne[3] = new Point(10, 0);

            Point[] pointsTwo = new Point[4];

            pointsTwo[0] = new Point(0, 0);
            pointsTwo[1] = new Point(0, 5);
            pointsTwo[2] = new Point(5, 5);
            pointsTwo[3] = new Point(5, 0);


            //Act
            FigureInterface figureInterface = new FigureInterface();

            figureInterface.CreateRectangle(pointsOne);
            figureInterface.CreateSquare(pointsTwo);
            //Assert
            Assert.AreEqual(25, figureInterface.AveragePerimeter());
        }

        /// <summary>
        /// Class: FigureInterface
        /// Method check: FindLargestArea
        /// Value: The coordinates of the rectangle and square. Class point.
        /// Result: 50 .
        /// </summary>
        [TestMethod]
        public void FigureInterface_FindLargestArea_CoordinatesRectangleAndSquare_50()
        {
            //Arrange
            Point[] pointsOne = new Point[4];

            pointsOne[0] = new Point(0, 0);
            pointsOne[1] = new Point(0, 5);
            pointsOne[2] = new Point(10, 5);
            pointsOne[3] = new Point(10, 0);

            Point[] pointsTwo = new Point[4];

            pointsTwo[0] = new Point(0, 0);
            pointsTwo[1] = new Point(0, 5);
            pointsTwo[2] = new Point(5, 5);
            pointsTwo[3] = new Point(5, 0);


            //Act
            FigureInterface figureInterface = new FigureInterface();

            figureInterface.CreateRectangle(pointsOne);
            figureInterface.CreateSquare(pointsTwo);

            //Assert
            Assert.AreEqual(50, figureInterface.FindLargestArea().Area);
        }

        /// <summary>
        /// Class: FigureInterface
        /// Method check: LargestAveragePerimeterAllType
        /// Value: The coordinates of the rectangle and square. Class point.
        /// Result: 50 .
        /// </summary>
        [TestMethod]
        public void FigureInterface_LargestAveragePerimeterAllType_CoordinatesRectangleAndSquare_50()
        {
            //Arrange
            Point[] pointsOne = new Point[4];

            pointsOne[0] = new Point(0, 0);
            pointsOne[1] = new Point(0, 5);
            pointsOne[2] = new Point(10, 5);
            pointsOne[3] = new Point(10, 0);

            Point[] pointsTwo = new Point[4];

            pointsTwo[0] = new Point(0, 0);
            pointsTwo[1] = new Point(0, 5);
            pointsTwo[2] = new Point(5, 5);
            pointsTwo[3] = new Point(5, 0);


            //Act
            FigureInterface figureInterface = new FigureInterface();

            figureInterface.CreateRectangle(pointsOne);
            figureInterface.CreateSquare(pointsTwo);

            //Assert
            Assert.AreEqual("Rectangle", figureInterface.LargestAveragePerimeterAllType());
        }
    }
}
