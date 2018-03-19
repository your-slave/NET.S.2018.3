using NET.S._2018.Karakouski._3;
using NUnit.Framework;
using System;

namespace NET.S._2018.Karakouski.NUnit.Tests
{
    [TestFixture]
    public class LogicTests
    {
        [TestCase(1, 5, 0.0001, 1, .005)]
        [TestCase(1, 5, 0.0001, 1, .005)]
        [TestCase(8, 3, 0.0001, 2, .005)]
        [TestCase(0.001, 3, 0.0001, 0.1, .005)]
        [TestCase(0.04100625, 4, 0.0001, 0.45, .005)]
        [TestCase(8, 3, 0.0001, 2, .005)]
        [TestCase(0.0279936, 7, 0.0001, 0.6, .005)]
        [TestCase(0.0081, 4, 0.1, 0.3, .005)]
        [TestCase(-0.008, 3, 0.1, 0.2, .005)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545, .005)]
        public double FindNthRoot_TestCalulations(double number, int root, double tolerance) => Logic.FindNthRoot(number, root, tolerance);

        [TestCase]
        public void InsertNumber_IncorrectTollerance_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Logic.FindNthRoot(8, 15, -7));
        }

        [TestCase]
        public void InsertNumber_IncorrectRooot_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Logic.FindNthRoot(8, 15, -7));
        }

    }

}

