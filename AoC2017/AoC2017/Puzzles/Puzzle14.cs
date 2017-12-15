using System;
using System.Collections.Generic;
using System.IO;

namespace AoC2017.Puzzles
{
    public class Puzzle14
    {
        public static int Solve1(string input)
        {

            return 0;
        }

        public static int GetBitCount(byte[] bytes)
        {
            int count = 0;
            foreach (byte b in bytes)
            {
                count += GetBitCount(b);
            }
            return count;
        }

        public static int GetBitCount(byte n)
        {
            int count = 0;
            int i = 0;
            while (i < 8)
            {
                if ((n & (1 << i)) != 0)
                {
                    count++;
                }
                i++;
            }
            return count;
        }
    }
}
