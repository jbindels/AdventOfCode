using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle13
    {
        [TestMethod]
        public void P13Part1Test1()
        {
            int[] input = new int[7];
            input[0] = 3;
            input[1] = 2;
            input[4] = 4;
            input[6] = 4;
            int expected = 24;
            int actual = AoC2017.Puzzles.Puzzle13.Solve1(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Test1()
        {
            int[] input = new int[7];
            input[0] = 3;
            input[1] = 2;
            input[4] = 4;
            input[6] = 4;
            int expected = 10;
            int actual = AoC2017.Puzzles.Puzzle13.Solve2(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start0()
        {
            int range = 3;
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start1()
        {
            int range = 3;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start2()
        {
            int range = 3;
            int expected = 2;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start3()
        {
            int range = 3;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start4()
        {
            int range = 3;
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start5()
        {
            int range = 3;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start6()
        {
            int range = 3;
            int expected = 2;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P13Part2Start7()
        {
            int range = 3;
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle13.DetermineScannerPosition(range, 7);
            Assert.AreEqual(expected, actual);
        }
    }
}
