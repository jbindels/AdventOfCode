using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle2
    {
        [TestMethod]
        public void P2Part1Test1()
        {
            int[][] ints = new int[3][];
            ints[0] = new int[] {5, 1, 9, 5};
            ints[1] = new int[] {7, 5, 3};
            ints[2] = new int[] {2, 4, 6, 8};
            int expected = 18;
            int actual = AoC2017.Puzzles.Puzzle2.SolvePart1(ints);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P2Part2Test1()
        {
            int[][] ints = new int[3][];
            ints[0] = new int[] {5, 9, 2, 8};
            ints[1] = new int[] {9, 4, 7, 3};
            ints[2] = new int[] {3, 8, 6, 5};
            int expected = 9;
            int actual = AoC2017.Puzzles.Puzzle2.SolvePart2(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
