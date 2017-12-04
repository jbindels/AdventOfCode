using System;
using System.Xml.Schema;

namespace AoC2017.Puzzles
{
    public class Puzzle2
    {
        public static int SolvePart1(int[][] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int min = input[i][0];
                int max = input[i][0];
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] < min)
                    {
                        min = input[i][j];
                    }
                    if (input[i][j] > max)
                    {
                        max = input[i][j];
                    }
                }
                sum += max - min;
            }
            return sum;
        }

        public static int SolvePart2(int[][] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool found = false;
                int index = 0;
                while (!found && index < input[i].Length)
                {
                    for (int j = index + 1; j < input[i].Length; j++)
                    {
                        int min = input[i][index];
                        int max = input[i][j];
                        if (min > max)
                        {
                            int t = min;
                            min = max;
                            max = t;
                        }
                        if (max % min == 0)
                        {
                            sum += max / min;
                            found = true;
                        }
                    }
                    index++;
                }
            }
            return sum;
        }
    }
}
