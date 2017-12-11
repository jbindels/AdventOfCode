using System;
using AoC2017.Puzzles;

namespace AoC2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int puzzle = -1;
            bool correctInput = false;
            while (!correctInput)
            {
                puzzle = Menu();
                if (puzzle == 0)
                {
                    break;
                }
                if (puzzle > 0 && puzzle <= 25)
                {
                    correctInput = true;
                    StartPuzzle(puzzle);
                }
            }
            Console.ReadKey();
        }

        private static int Menu()
        {
            Console.WriteLine("Advent of Code   MAIN MENU");
            Console.WriteLine("Type in the puzzle number to solve");
            int puzzle;
            if (int.TryParse(Console.ReadLine(), out puzzle))
            {
                return puzzle;
            }
            return -1;
        }

        private static void StartPuzzle(int puzzle)
        {
            switch (puzzle)
            {
                case 1:
                    Console.WriteLine("Puzzle 1 solutions");
                    Console.WriteLine("Part 1 sum is: " + Puzzle1.SolvePart1(PuzzleResources.Puzzle1));
                    Console.WriteLine("Part 2 sum is: " + Puzzle1.SolvePart2(PuzzleResources.Puzzle1));
                    break;
                case 2:
                    Console.WriteLine("Puzzle 2 solutions");
                    Console.WriteLine("Part 1 sum is: " + Puzzle2.SolvePart1(PuzzleResources.Puzzle2));
                    Console.WriteLine("Part 2 sum is: " + Puzzle2.SolvePart2(PuzzleResources.Puzzle2));
                    break;
                case 3:
                    Console.WriteLine("Puzzle 3 solutions");
                    Console.WriteLine("Part 1 sum is: " + Puzzle3.SolvePart1(PuzzleResources.Puzzle3));
                    Console.WriteLine("Part 2 sum is: " + Puzzle3.SolvePart2(PuzzleResources.Puzzle3));
                    break;
                case 4:
                    Console.WriteLine("Puzzle 4 solutions");
                    Console.WriteLine("Part 1 count is: " + Puzzle4.SolvePart1());
                    Console.WriteLine("Part 2 count is: " + Puzzle4.SolvePart2());
                    break;
                case 5:
                    Console.WriteLine("Puzzle 5 solutions");
                    Console.WriteLine("Part 1 stepcount is: " + Puzzle5.SolvePart1(PuzzleResources.Puzzle5));
                    Console.WriteLine("Part 2 stepcount is: " + Puzzle5.SolvePart2(PuzzleResources.Puzzle5));
                    break;
                case 6:
                    Console.WriteLine("Puzzle 6 solutions");
                    Console.WriteLine("Part 1 stepcount is: " + Puzzle6.SolveParts(PuzzleResources.Puzzle6, false));
                    Console.WriteLine("Part 2 stepcount is: " + Puzzle6.SolveParts(PuzzleResources.Puzzle6, true));
                    break;
                case 7:
                    Console.WriteLine("Puzzle 7 solutions");
                    Console.WriteLine("Part 1 stepcount is: " + Puzzle7.Solve1());
                    Console.WriteLine("Part 2 stepcount is: " + Puzzle7.Solve2());
                    break;
                case 8:
                    Console.WriteLine("Puzzle 8 solutions");
                    Console.WriteLine("Part 1 max value is: " + Puzzle8.Solve(false));
                    Console.WriteLine("Part 2 max value is: " + Puzzle8.Solve(true));
                    break;
                case 9:
                    Console.WriteLine("Puzzle 9 solutions");
                    Console.WriteLine("Part 1 groupcount is: " + Puzzle9.Solve(PuzzleResources.Puzzle9, false));
                    Console.WriteLine("Part 2 count is: " + Puzzle9.Solve(PuzzleResources.Puzzle9, true));
                    break;
                case 10:
                    Console.WriteLine("Puzzle 10 solutions");
                    Console.WriteLine("Part 1 multiply result is: " + Puzzle10.Solve(PuzzleResources.Puzzle10, 256, false));
                    Console.WriteLine("Part 2 count is: " + Puzzle10.Solve(PuzzleResources.Puzzle10, 256, true));
                    break;
                case 11:
                    Console.WriteLine("Puzzle 11 solutions");
                    Console.WriteLine("Part 1 steps is: " + Puzzle11.Solve(PuzzleResources.Puzzle11, false));
                    Console.WriteLine("Part 2 max steps is: " + Puzzle11.Solve(PuzzleResources.Puzzle11, true));
                    break;
            }
        }
    }
}
