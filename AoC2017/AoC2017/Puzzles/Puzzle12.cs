using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2017.Puzzles
{
    public class Puzzle12
    {
        //0 <-> 1352, 1864
        public static int Solve(List<int> containsProgram, bool isPuzzle2)
        {
            List<List<int>> found = new List<List<int>>();
            found.Add(new List<int>(containsProgram));
            int groupCount = 0;
            List<Pipe> pipes = new List<Pipe>();
            StreamReader sr = new StreamReader("Puzzle12.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] splits = line.Split(new string[] {" <-> "}, StringSplitOptions.None);
                pipes.Add(new Pipe(splits[0], splits[1].Split(',')));
                line = sr.ReadLine();
            }
            while (pipes.Count != 0)
            {
                if (containsProgram.Count == 0)
                {
                    containsProgram.Add(pipes[0].Program);
                    found.Add(new List<int>(containsProgram));
                    groupCount++;
                }
                int containsCount = containsProgram.Count;
                for (int j = 0; j < containsCount; j++)
                {
                    for (int i = 0; i < pipes.Count; i++)
                    {
                        if (pipes[i].ContainsProgram(containsProgram[j]))
                        {
                            if (!found[groupCount].Contains(pipes[i].Program))
                            {
                                found[groupCount].Add(pipes[i].Program);
                            }
                            containsProgram.Add(pipes[i].Program);
                            pipes.RemoveAt(i);
                        }
                    }
                }
                containsProgram.RemoveRange(0, containsCount);
            }
            if (isPuzzle2)
            {
                return groupCount + 1;
            }
            return found[0].Count;
        }
    }

    public class Pipe
    {
        public readonly int Program;
        public readonly int[] Pipes;

        public Pipe(string program, string[] pipes)
        {
            Program = Convert.ToInt32(program);
            Pipes = new int[pipes.Length];
            for (int i = 0; i < pipes.Length; i++)
            {
                Pipes[i] = Convert.ToInt32(pipes[i]);
            }
        }

        public bool ContainsProgram(int program)
        {
            for (int i = 0; i < Pipes.Length; i++)
            {
                if (Pipes[i] == program)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
