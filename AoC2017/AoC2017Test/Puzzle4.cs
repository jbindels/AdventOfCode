using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2017Test
{
    [TestClass]
    public class Puzzle4
    {
        //aa bb cc dd ee is valid.
        //aa bb cc dd aa is not valid - the word aa appears more than once.
        //aa bb cc dd aaa is valid - aa and aaa count as different words.
        
        [TestMethod]
        public void P4Part1Test1()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect1(new List<string>() {"aa", "bb", "cc", "dd", "ee"});
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void P4Part1Test2()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect1(new List<string>() { "aa", "bb", "cc", "dd", "aa" });
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void P4Part1Test3()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect1(new List<string>() { "aa", "bb", "cc", "dd", "aaa" });
            Assert.AreEqual(true, actual);
        }

        //abcde fghij is a valid passphrase.
        //abcde xyz ecdab is not valid - the letters from the third word can be rearranged to form the first word.
        //a ab abc abd abf abj is a valid passphrase, because all letters need to be used when forming another word.
        //iiii oiii ooii oooi oooo is valid.
        //oiii ioii iioi iiio is not valid - any of these words can be rearranged to form any other word.
        [TestMethod]
        public void P4Part2Test1()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect2(new List<string>() { "abcde", "fghij"});
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void P4Part2Test2()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect2(new List<string>() { "abcde", "xyz", "ecdab" });
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void P4Part2Test3()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect2(new List<string>() {"a", "ab", "abc", "abd", "abf", "abj"});
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void P4Part2Test4()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect2(new List<string>() { "iiii", "oiii", "ooii", "oooi", "oooo" });
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void P4Part2Test5()
        {
            bool actual = AoC2017.Puzzles.Puzzle4.IsLineCorrect2(new List<string>() { "oiii", "ioii", "iioi", "iiio" });
            Assert.AreEqual(false, actual);
        }
    }
}
