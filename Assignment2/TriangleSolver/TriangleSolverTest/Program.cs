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

        // 1. Test for valid equilateral triangle (1/3)
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

    }
}