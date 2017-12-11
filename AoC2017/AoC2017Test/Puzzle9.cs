using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle9
    {
        // {}, score of 1.
        // {{{}}}, score of 1 + 2 + 3 = 6.
        // {{},{}}, score of 1 + 2 + 2 = 5.
        // {{{},{},{{}}}}, score of 1 + 2 + 3 + 3 + 3 + 4 = 16.
        // {<a>,<a>,<a>,<a>}, score of 1.
        // {{<ab>},{<ab>},{<ab>},{<ab>}}, score of 1 + 2 + 2 + 2 + 2 = 9.
        // {{<!!>},{<!!>},{<!!>},{<!!>}}, score of 1 + 2 + 2 + 2 + 2 = 9.
        // {{<a!>},{<a!>},{<a!>},{<ab>}}, score of 1 + 2 = 3.

        [TestMethod]
        public void P9Part1Test1()
        {
            string input = "{}";
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test2()
        {
            string input = "{{{}}}";
            int expected = 6;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test3()
        {
            string input = "{{},{}}";
            int expected = 5;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test4()
        {
            string input = "{{{},{},{{}}}}";
            int expected = 16;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test5()
        {
            string input = "{<a>,<a>,<a>,<a>}";
            int expected = 1;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test6()
        {
            string input = "{{<ab>},{<ab>},{<ab>},{<ab>}}";
            int expected = 9;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test7()
        {
            string input = "{{<!!>},{<!!>},{<!!>},{<!!>}}";
            int expected = 9;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void P9Part1Test8()
        {
            string input = "{{<a!>},{<a!>},{<a!>},{<ab>}}";
            int expected = 3;
            int actual = AoC2017.Puzzles.Puzzle9.Solve(input, false);
            Assert.AreEqual(expected, actual);
        }
    }
}
