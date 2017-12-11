using System;
using System.Collections.Generic;
using System.IO;

namespace AoC2017.Puzzles
{
    public class Puzzle7
    {
        private static readonly List<string> programs = new List<string>();
        private static readonly List<string[]> programList = new List<string[]>();

        private static readonly Dictionary<string, MyProgramDisk> _myPrograms = new Dictionary<string, MyProgramDisk>();

        public static void PreProcess(bool isPuzzle2)
        {
            StreamReader sr = new StreamReader(File.OpenRead("Puzzle7.txt"));
            string line = sr.ReadLine();
            string maxDisk = "";
            while (line != null)
            {
                string[] splits = line.Split(new []{" -> "}, StringSplitOptions.None);
                if (splits.Length == 2)
                {
                    programList.Add(splits);
                }
                if (isPuzzle2)
                {
                    programs.Add(splits[0]);
                }
                else
                {
                    programs.Add(RemoveWeight(splits[0]));
                }
                line = sr.ReadLine();
            }
        }

        private static string RemoveWeight(string programWithWeight)
        {
            return programWithWeight.Substring(0, programWithWeight.IndexOf('(') - 1);
        }

        public static string Solve1()
        {
            PreProcess(false);
            for (int i = 0; i < programList.Count; i++)
            {
                string[] toRemove = programList[i][1].Split(new[] { ", " }, StringSplitOptions.None);
                foreach (string s in toRemove)
                {
                    programs.Remove(s);
                }
            }
            return programs[0];
        }

        public static int Solve2()
        {
            PreProcess(true);

            return 0;
        }

        public static ProgramDisk StringToProgram(string programString)
        {
            int weight = Convert.ToInt32(programString.Split(new []{" ("}, StringSplitOptions.None)[1].Substring(0, programString.Split(new[] { " (" }, StringSplitOptions.None)[1].Length-2));
            string name = programString.Split(new[] { " (" }, StringSplitOptions.None)[0];
            return new ProgramDisk(weight, name);
        }

        public class ProgramDisk
        {
            private List<ProgramDisk> _disks = new List<ProgramDisk>();
            private readonly int _weight;
            private readonly string _name;

            public ProgramDisk(int weight, string name)
            {
                _weight = weight;
                _name = name;
            }

            public int GetWeight()
            {
                int totalWeight = _weight;
                for (int i = 0; i < _disks.Count; i++)
                {
                    totalWeight += _disks[i].GetWeight();
                }
                return totalWeight;
            }

            public bool HasPrograms()
            {
                return _disks.Count != 0;
            }

            public bool IsBalanced()
            {
                if (_disks.Count > 0)
                {
                    int toMatch = _disks[0].GetWeight();
                    for (int i = 0; i < _disks.Count; i++)
                    {
                        if (toMatch != _disks[i].GetWeight())
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            public int NewWeight(int deltaWeight)
            {
                return _weight + deltaWeight;
            }
        }

        public class MyProgramDisk
        {
            public int weight;
            public string name;
            public List<MyProgramDisk> disks;

            public MyProgramDisk(int weight)
            {
                
            }

            public void AddMyProgram(MyProgramDisk program)
            {
                disks.Add(program);
            }

            public int GetTotalWeight()
            {
                int totalWeight = weight;
                for (int i = 0; i < disks.Count; i++)
                {
                    totalWeight += disks[i].GetTotalWeight();
                }
                return totalWeight;
            }
        }
    }
}
