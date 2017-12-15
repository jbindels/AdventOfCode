using System;
using System.Collections.Generic;
using System.IO;

namespace AoC2017.Puzzles
{
    public class Puzzle13
    {
        public static int Solve1(int[] input, int depth = 0)
        {
            int severity = 0;
            int layers = input.Length;
            int[] currentScannerPos = DetermineStartPositions(ref input, depth);
            int[] deltas = new int[layers];
            bool isProblem2 = depth < 0;
            for (int i = 0; i < input.Length; i++)
            {
                deltas[i] = 1;
            }
            while (depth < layers)
            {
                if (input[depth] != 0 && currentScannerPos[depth] == 0)
                {
                    if (isProblem2)
                    {
                        break;
                    }
                    severity += depth * input[depth];
                }
                //next positions
                for (int i = 0; i < layers; i++)
                {
                    if (input[i] != 0)
                    {
                        if (currentScannerPos[i] == 0 && deltas[i] == -1)
                        {
                            deltas[i] = -deltas[i];
                        }
                        else if (currentScannerPos[i] == input[i] - 1 && deltas[i] == 1)
                        {
                            deltas[i] = -deltas[i];
                        }
                        currentScannerPos[i] += deltas[i];
                    }
                }
                depth++;
            }
            return severity;
        }

        public static int DetermineScannerPosition(int range, int step)
        {
            if (step == 0)
                return 0;
            int move = (int)Math.Floor((double)step / (range - 1))%2;
            int pos = step % (range - 1);
            return 0;
        }

        public static int[] DetermineStartPositions(ref int[] input, int steps)
        {
            int[] startPositions = new int[input.Length];
            if (steps != 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != 0)
                    {
                        int move = (int) Math.Floor((double) steps / (input[i] - 1));
                        bool back = move % 2 == 0;
                        if (back)
                        {
                            startPositions[i] = input[i] - steps % (input[i] - 1) - 1;
                        }
                        else
                        {
                            startPositions[i] = steps % input[i];
                        }
                    }
                }
            }
            return startPositions;
        }

        public static int Solve2(int[] input)
        {
            int currentDelay = 0;
            while (true)
            {
                if (Solve1(input, -currentDelay) == 0)
                {
                    return currentDelay;
                }
                currentDelay++;
            }
        }
    }
}
