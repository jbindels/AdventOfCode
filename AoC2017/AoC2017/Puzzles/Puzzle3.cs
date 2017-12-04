using System;

namespace AoC2017.Puzzles
{
    public class Puzzle3
    {
        public static int SolvePart1(int input)
        {
            int radius = 0;
            bool found = false;
            while (!found)
            {
                if (input - (radius * 2 + 1) * (radius * 2 + 1) < 0)
                {
                    found = true;
                }
                else
                {
                    radius++;
                }
            }
            int pos = input - ((radius - 1) * 2 + 1) * ((radius - 1) * 2 + 1);
            int steps = pos == 0 ? (radius - 1) * 2 : radius * 2;
            int delta = -1;
            int count = 0;
            int sides = (int) Math.Floor((double) pos / (radius * 2));
            pos = pos - sides * radius * 2;
            while (pos != 0)
            {
                steps += delta;
                pos--;
                count++;
                if (count == radius)
                {
                    delta = -delta;
                    count = 0;
                }
            }
            return steps;
        }

        public static int SolvePart2(int input)
        {
            int position = 0;

            return position;
        }
    }
}
