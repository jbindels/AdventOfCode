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
                    Console.WriteLine("Sum is: " + Puzzle1.Solve(PuzzleResources.GetPuzzle1));
                    break;
            }
        }
    }
}
