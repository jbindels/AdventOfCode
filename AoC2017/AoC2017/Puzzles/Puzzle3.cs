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

        public struct Point
        {
            public int r;
            public int c;
        }
        public static int SolvePart2(int input)
        {
            int number = 1;
            int radius = 0;
            int count = 0;
            bool moveHorizontal = true;
            int horizontalDelta = 1;
            int verticalDelta = -1;
            int[,] numbers = new int[15, 15];
            numbers[7, 7] = 1;
            Point p = new Point {r = 7, c = 7};
            while (number < input)
            {
                p.r = !moveHorizontal ? p.r + verticalDelta : p.r;
                p.c = moveHorizontal ? p.c + horizontalDelta : p.c;
                number = numbers[p.r - 1, p.c - 1];
                number += numbers[p.r - 1, p.c];
                number += numbers[p.r - 1, p.c + 1];
                number += numbers[p.r, p.c - 1];
                number += numbers[p.r, p.c + 1];
                number += numbers[p.r + 1, p.c - 1];
                number += numbers[p.r + 1, p.c];
                number += numbers[p.r + 1, p.c + 1];
                numbers[p.r, p.c] = number;
                count++;
                if (count == 1)
                {
                    moveHorizontal = false;
                    verticalDelta = -1;
                    radius++;
                }
                else if (count - 2*radius == 0)
                {
                    moveHorizontal = true;
                    horizontalDelta = -1;
                }
                else if (count - 4*radius == 0)
                {
                    moveHorizontal = false;
                    verticalDelta = 1;
                }
                else if (count - 6*radius == 0)
                {
                    moveHorizontal = true;
                    horizontalDelta = 1;
                }
                else if (count - 8*radius == 0)
                {
                    count = 0;
                }
            }
            return number;
        }
    }
}
