using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle3
    {
        //Data from square 1 is carried 0 steps, since it's at the access port.
        //Data from square 12 is carried 3 steps, such as: down, left, left.
        //Data from square 23 is carried only 2 steps: up twice.
        //Data from square 1024 must be carried 31 steps.

        [TestMethod]
        public void P3Part1Test1()
        {
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle3.SolvePart1(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P3Part1Test2()
        {
            int expected = 3;
            int actual = AoC2017.Puzzles.Puzzle3.SolvePart1(12);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P3Part1Test3()
        {
            int expected = 2;
            int actual = AoC2017.Puzzles.Puzzle3.SolvePart1(23);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P3Part1Test4()
        {
            int expected = 31;
            int actual = AoC2017.Puzzles.Puzzle3.SolvePart1(1024);
            Assert.AreEqual(expected, actual);
        }
    }
}
