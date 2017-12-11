using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle11
    {
        // ne,ne,ne is 3 steps away.
        // ne,ne,sw,sw is 0 steps away (back where you started).
        // ne,ne,s,s is 2 steps away(se, se).
        // se,sw,se,sw,sw is 3 steps away(s, s, sw).

        [TestMethod]
        public void P11Part1Test1()
        {
            string input = "ne,ne,ne";
            int expected = 3;
            int actual = AoC2017.Puzzles.Puzzle11.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P11Part1Test2()
        {
            string input = "ne,ne,sw,sw";
            int expected = 0;
            int actual = AoC2017.Puzzles.Puzzle11.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P11Part1Test3()
        {
            string input = "ne,ne,s,s";
            int expected = 2;
            int actual = AoC2017.Puzzles.Puzzle11.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P11Part1Test4()
        {
            string input = "se,sw,se,sw,sw";
            int expected = 3;
            int actual = AoC2017.Puzzles.Puzzle11.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }
    }
}
