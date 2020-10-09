using System;
using NUnit.Framework;
using Sai_Assignment1;
using static Sai_Assignment1.Program;
using static Sai_Assignment1.TriangleSolver;
namespace TestTriangle
{
    public class Tests
    {
       
        [Test]
        public void Input60_60_60_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 60; sides.b = 60; sides.c = 60;

            String expected_result = "Sides form a Triangle\nTriangle is Equilateral\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Input15_15_15_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 15; sides.b = 15; sides.c = 15;

            String expected_result = "Sides form a Triangle\nTriangle is Equilateral\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }
        [Test]
        public void Input60_60_70_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 60; sides.b = 60; sides.c = 70;

            String expected_result = "Sides form a Triangle\nTriangle is Isosceles\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Input3_3_4_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 3; sides.b = 3; sides.c = 4;

            String expected_result = "Sides form a Triangle\nTriangle is Isosceles\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Input60_50_70_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 60; sides.b = 50; sides.c = 70;

            String expected_result = "Sides form a Triangle\nTriangle is Scalene\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Input3_4_5_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 3; sides.b = 4; sides.c = 5;

            String expected_result = "Sides form a Triangle\nTriangle is Scalene\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }


        [Test]
        public void Input100_1_102_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 100; sides.b = 1; sides.c = 102;

            String expected_result = "Sides doesn't form a Triangle\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Input1_1_10_OutputValid()
        {
            Sides sides = new Sides();
            sides.a = 1; sides.b = 1; sides.c = 10;

            String expected_result = "Sides doesn't form a Triangle\n";

            String actual_result = TriangleSolver.Analyze(sides);

            Assert.AreEqual(expected_result, actual_result);

        }
    }
}
