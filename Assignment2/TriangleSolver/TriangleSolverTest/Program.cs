using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class Program
    {
        static void Main(string[] args)
        {
        }

        // 1. Test for valid equilateral triangle (1/1)
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            //Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "Equilateral triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 2. Test for valid isosceles triangle (1/3)
        [Test]
        public void ValidTriangle_Input5and5and8_OutputIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 8;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 3. Test for valid isosceles triangle (2/3)
        [Test]
        public void ValidTriangle_Input6and9and6_OutputIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 9;
            int thirdSide = 6;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 4. Test for valid isosceles triangle (3/3)
        [Test]
        public void ValidTriangle_Input7and5and7_OutputIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 5;
            int thirdSide = 7;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 5. Test for valid scalene triangle (1/5)
        [Test]
        public void ValidTriangle_Input3and4and5_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 6. Test for valid scalene triangle (2/5)
        [Test]
        public void ValidTriangle_Input5and7and10_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 7;
            int thirdSide = 10;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 7. Test for valid scalene triangle (3/5)
        [Test]
        public void ValidTriangle_Input8and11and7_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 11;
            int thirdSide = 7;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 8. Test for valid scalene triangle (4/5)
        [Test]
        public void ValidTriangle_Input9and12and15_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 12;
            int thirdSide = 15;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 9. Test for valid scalene triangle (5/5)
        [Test]
        public void ValidTriangle_Input13and14and15_OutputScaleneTriangle()
        {
            // Arrange
            int firstSide = 13;
            int secondSide = 14;
            int thirdSide = 15;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 10. Test for zero length side (1/3)
        [Test]
        public void InvalidTriangle_Input0and5and5_OutputInvalidTriangle()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 5;
            int thirdSide = 5;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 11. Test for zero length side (2/3)
        [Test]
        public void InvalidTriangle_Input7and0and7_OutputInvalidTriangle()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 0;
            int thirdSide = 7;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 12. Test for zero length side (3/3)
        [Test]
        public void InvalidTriangle_Input3and3and0_OutputInvalidTriangle()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 3;
            int thirdSide = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 13. Test for invalid triangle (1/3)
        [Test]
        public void InvalidTriangle_Input1and2and3_OutputInvalid()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 3;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 14. Test for invalid triangle (2/3)
        [Test]
        public void InvalidTriangle_Input5and10and3_OutputInvalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 10;
            int thirdSide = 3;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // 15. Test for invalid triangle (3/3)
        [Test]
        public void InvalidTriangle_Input1and20and5_OutputInvalid()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 20;
            int thirdSide = 5;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}