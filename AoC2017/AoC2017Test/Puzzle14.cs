using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle14
    {
        [TestMethod]
        public void P14Part1Test0()
        {
            byte input = 0;
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P14Part1Test1()
        {
            byte input = 1;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P14Part1Test2()
        {
            byte input = 2;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P14Part1Test3()
        {
            byte input = 3;
            int expected = 2;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P14Part1Test4()
        {
            byte input = 4;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P14Part1Test167()
        {
            byte input = 167;
            int expected = 5;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P14Part1TestBigArray()
        {
            byte[] input = new byte[] {162, 88, 42, 58, 14, 102, 230, 232, 110, 56, 18, 220, 182, 114, 162, 114};
            int expected = 60;
            int actual = AoC2017.Puzzles.Puzzle14.GetBitCount(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
