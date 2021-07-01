using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG2070_Assignment_2;

namespace RectangleTest
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void GetLength_Input3_Returns3()
        {
            //Arrange
            int length = 3;

            int expected = 3;
            Rectangle rect = new Rectangle(length, 3);

            //Act
            int actual = rect.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetLength_Input5_Returns5()
        {
            //Arrange
            int length = 5;

            int expected = 5;
            Rectangle rect = new Rectangle(length, 3);

            //Act
            int actual = rect.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetLength_Input0_Returns0()
        {
            //Arrange
            int length = 0;

            int expected = 0;
            Rectangle rect = new Rectangle(length, 3);

            //Act
            int actual = rect.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetLength_Input3_Returns3()
        {
            //Arrange
            int length = 3;

            int expected = 3;
            Rectangle rect = new Rectangle();

            //Act
            int actual = rect.SetLength(length);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetLength_Input5_Returns5()
        {
            //Arrange
            int length = 5;

            int expected = 5;
            Rectangle rect = new Rectangle();

            //Act
            int actual = rect.SetLength(length);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetLength_Input0_Returns0()
        {
            //Arrange
            int length = 0;

            int expected = 0;
            Rectangle rect = new Rectangle();

            //Act
            int actual = rect.SetLength(length);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWidth_Input3_Returns3()
        {
            //Arrange
            int Width = 3;

            int expected = 3;
            Rectangle rect = new Rectangle(3, Width);

            //Act
            int actual = rect.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWidth_Input5_Returns5()
        {
            //Arrange
            int Width = 5;

            int expected = 5;
            Rectangle rect = new Rectangle(3, Width);

            //Act
            int actual = rect.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWidth_Input0_Returns0()
        {
            //Arrange
            int Width = 0;

            int expected = 0;
            Rectangle rect = new Rectangle(3, Width);

            //Act
            int actual = rect.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetWidth_Input3_Returns3()
        {
            //Arrange
            int Width = 3;

            int expected = 3;
            Rectangle rect = new Rectangle();

            //Act
            int actual = rect.SetLength(Width);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetWidth_Input5_Returns5()
        {
            //Arrange
            int Width = 5;

            int expected = 5;
            Rectangle rect = new Rectangle();

            //Act
            int actual = rect.SetLength(Width);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetWidth_Input0_Returns0()
        {
            //Arrange
            int Width = 0;

            int expected = 0;
            Rectangle rect = new Rectangle();

            //Act
            int actual = rect.SetLength(Width);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPerimeter_Input10and10_Returns40()
        {
            //Arrange
            Rectangle rect = new Rectangle(10, 10);
            int expected = 40;

            //Act
            int actual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_Input0and10_Returns20()
        {
            //Arrange
            Rectangle rect = new Rectangle(0, 10);
            int expected = 20;

            //Act
            int actual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_Input5and3_Returns16()
        {
            //Arrange
            Rectangle rect = new Rectangle(5, 3);
            int expected = 16;

            //Act
            int actual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_Input10and10_Returns100()
        {
            //Arrange
            Rectangle rect = new Rectangle(10, 10);
            int expected = 100;

            //Act
            int actual = rect.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void GetArea_Input0and10_Returns0()
        {
            //Arrange
            Rectangle rect = new Rectangle(0, 10);
            int expected = 0;

            //Act
            int actual = rect.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void GetArea_Input5and3_Returns15()
        {
            //Arrange
            Rectangle rect = new Rectangle(5, 3);
            int expected = 15;

            //Act
            int actual = rect.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
