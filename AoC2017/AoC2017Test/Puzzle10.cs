using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle10
    {
        [TestMethod]
        public void P10Part1Test1()
        {
            int[] input = new int[] {3, 4, 1, 5};
            int expected = 12;
            int actual = AoC2017.Puzzles.Puzzle10.Solve(input, 5, false);
            Assert.AreEqual(expected, actual);
        }
    }
}
