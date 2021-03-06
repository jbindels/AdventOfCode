﻿using System;
using System.Collections.Generic;

namespace AoC2017.Puzzles
{
    public class Puzzle1
    {
        public static int SolvePart1(string input)
        {
            input += input[0];
            int length = input.Length;
            int current = input[0] - 48;
            int sum = 0;
            for (int i = 1; i < length; i++)
            {
                int next = input[i] - 48;
                if (current == next)
                {
                    sum += next;
                }
                else
                {
                    current = next;
                }
            }
            return sum;
        }

        public static int SolvePart2(string input)
        {
            int halfway = input.Length / 2;
            int sum = 0;
            for (int i = 0; i < halfway; i++)
            {
                if (input[i] == input[i + halfway])
                {
                    sum += (input[i] - 48) * 2;
                }
            }
            return sum;
        }
    }
}
