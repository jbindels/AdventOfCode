using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle1
    {
        //1122 produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit.
        //1111 produces 4 because each digit(all 1) matches the next.
        //1234 produces 0 because no digit matches the next.
        //91212129 produces 9 because the only digit that matches the next one is the last digit, 9.

        [TestMethod]
        public void Test1()
        {
            int expected = 3;
            int actual = AoC2017.Puzzles.Puzzle1.Solve("1122");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()
        {
            int expected = 4;
            int actual = AoC2017.Puzzles.Puzzle1.Solve("1111");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle1.Solve("1234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            int expected = 9;
            int actual = AoC2017.Puzzles.Puzzle1.Solve("91212129");
            Assert.AreEqual(expected, actual);
        }
    }
}
