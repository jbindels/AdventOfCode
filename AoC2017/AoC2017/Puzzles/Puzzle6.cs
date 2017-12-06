using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2017.Puzzles
{
    public class Puzzle6
    {
        public static int SolveParts(int[] ints, bool isPuzzle2)
        {
            List<int[]> foundInts = new List<int[]>();
            bool found = false;
            while (!found)
            {
                int[] intsToAdd = new int[ints.Length];
                for (int i = 0; i < ints.Length; i++)
                {
                    intsToAdd[i] = ints[i];
                }
                foundInts.Add(intsToAdd);
                int maxPos = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] > ints[maxPos])
                    {
                        maxPos = i;
                    }
                }
                int toShare = ints[maxPos];
                ints[maxPos] = 0;
                int currectIndex = maxPos + 1;
                while (toShare > 0)
                {
                    if (currectIndex >= ints.Length)
                    {
                        currectIndex = 0;
                    }
                    ints[currectIndex]++;
                    currectIndex++;
                    toShare--;
                }
                for (int i = 0; i < foundInts.Count; i++)
                {
                    int[] check = foundInts[i];
                    found = true;
                    for (int j = 0; j < check.Length; j++)
                    {
                        if (check[j] != ints[j])
                        {
                            found = false;
                        }
                    }
                    if (found)
                    {
                        if (isPuzzle2)
                        {
                            return foundInts.Count - i;
                        }
                        break;
                    }
                }
            }
            return foundInts.Count;
        }
    }
}
