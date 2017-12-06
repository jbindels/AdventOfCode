using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle6
    {
        [TestMethod]
        public void P6Part1Test1()
        {
            int[] input = new int[] {0, 2, 7, 0};
            int expected = 5;
            int actual = AoC2017.Puzzles.Puzzle6.SolveParts(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P6Part2Test1()
        {
            int[] input = new int[] { 0, 2, 7, 0 };
            int expected = 4;
            int actual = AoC2017.Puzzles.Puzzle6.SolveParts(input, true);
            Assert.AreEqual(expected, actual);
        }
    }
}
