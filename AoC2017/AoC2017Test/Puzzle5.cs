using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle5
    {
        //start at pos 0, this number is the offset to the next number
        //increase the current number with 1
        
        [TestMethod]
        public void P5Part1Test1()
        {
            int expected = 5;
            int actual = AoC2017.Puzzles.Puzzle5.SolvePart1(new int[] {0, 3, 0, 1, -3});
            Assert.AreEqual(expected, actual);
        }

        //start at pos 0, this number is the offset to the next number
        //is this offset higher than 3, decrease the current number by 1, otherwise increase the current number with 1
        [TestMethod]
        public void P5Part2Test1()
        {
            int expected = 10;
            int actual = AoC2017.Puzzles.Puzzle5.SolvePart2(new int[] {0, 3, 0, 1, -3});
            Assert.AreEqual(expected, actual);
        }
    }
}
