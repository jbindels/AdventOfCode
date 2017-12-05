using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2017.Puzzles
{
    public class Puzzle5
    {
        public static int SolvePart1(int[] ints)
        {
            int step = 0;
            int pos = 0;
            int nextPos = 0;
            while (nextPos >= 0 && nextPos < ints.Length)
            {
                pos = ints[nextPos];
                ints[nextPos]++;
                nextPos = nextPos + pos;
                step++;
            }
            return step;
        }

        public static int SolvePart2(int[] ints)
        {
            int step = 0;
            int pos = 0;
            int nextPos = 0;
            while (nextPos >= 0 && nextPos < ints.Length)
            {
                pos = ints[nextPos];
                if (pos >= 3)
                    ints[nextPos]--;
                else
                    ints[nextPos]++;
                nextPos = nextPos + pos;
                step++;
            }
            return step;
        }
    }
}
