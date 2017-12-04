using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle1
    {
        [TestMethod]
        public void Part1Test1()
        {
            int expected = 3;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart1("1122");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part1Test2()
        {
            int expected = 4;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart1("1111");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part1Test3()
        {
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart1("1234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part1Test4()
        {
            int expected = 9;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart1("91212129");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part2Test1()
        {
            int expected = 6;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart2("1212");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part2Test2()
        {
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart2("1221");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part2Test3()
        {
            int expected = 4;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart2("123425");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part2Test4()
        {
            int expected = 12;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart2("123123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part2Test5()
        {
            int expected = 4;
            int actual = AoC2017.Puzzles.Puzzle1.SolvePart2("12131415");
            Assert.AreEqual(expected, actual);
        }
    }
}
