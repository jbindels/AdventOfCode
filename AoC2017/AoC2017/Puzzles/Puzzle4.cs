using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2017.Puzzles
{
    public class Puzzle4
    {
        public static int SolvePart1()
        {
            int count = 0;
            StreamReader sr = new StreamReader("Puzzle4.txt");
            string line = sr.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (IsLineCorrect1(line.Split(' ').ToList()))
                {
                    count++;
                }
                line = sr.ReadLine();
            }
            return count;
        }

        public static bool IsLineCorrect1(List<string> words)
        {
            while (words.Count > 1)
            {
                string word = words[0];
                words.RemoveAt(0);
                if (words.Contains(word))
                {
                    return false;
                }
            }
            return true;
        }

        public static int SolvePart2()
        {
            int count = 0;
            StreamReader sr = new StreamReader("Puzzle4.txt");
            string line = sr.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (IsLineCorrect2(line.Split(' ').ToList()))
                {
                    count++;
                }
                line = sr.ReadLine();
            }
            return count;
        }

        public static bool IsLineCorrect2(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                for (int j = i + 1; j < words.Count; j++)
                {
                    string checkWord = words[j];
                    if (checkWord.Length == word.Length)
                    {
                        foreach (char c in word)
                        {
                            if (checkWord.Contains(c))
                            {
                                checkWord = checkWord.Remove(checkWord.IndexOf(c), 1);
                            }
                        }
                        if (checkWord.Length == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
