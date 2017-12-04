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
                    return;
                }
                if (puzzle != 0 && puzzle <= 7)
                {
                    correctInput = true;
                }
            }
            StartPuzzle(puzzle);
            Console.ReadKey();
        }

        private static int Menu()
        {
            Console.WriteLine("Advent of Code   MAIN MENU");
            Console.WriteLine("Type in the puzzle number to solve");
            if (int.TryParse(Console.ReadLine(), out int puzzle))
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
                    Console.WriteLine("Part 1 sum is: " + Puzzle1.SolvePart1(PuzzleResources.GetPuzzle1));
                    Console.WriteLine("Part 2 sum is: " + Puzzle1.SolvePart2(PuzzleResources.GetPuzzle1));
                    break;
                case 2:
                    Console.WriteLine("Puzzle 2 solutions");
                    Console.WriteLine("Part 1 sum is: " + Puzzle2.SolvePart1(PuzzleResources.GetPuzzle2));
                    Console.WriteLine("Part 2 sum is: " + Puzzle2.SolvePart2(PuzzleResources.GetPuzzle2));
                    break;
                case 3:
                    Console.WriteLine("Puzzle 3 solutions");
                    Console.WriteLine("Part 1 sum is: " + Puzzle3.SolvePart1(PuzzleResources.GetPuzzle3));
                    Console.WriteLine("Part 2 sum is: " + Puzzle3.SolvePart2(PuzzleResources.GetPuzzle3));
                    break;
            }
        }
    }
}
