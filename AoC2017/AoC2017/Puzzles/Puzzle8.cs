using System;
using System.Collections.Generic;
using System.IO;

namespace AoC2017.Puzzles
{
    public class Puzzle8
    {
        public static int Solve(bool isPuzzle2)
        {
            Queue<Instruction> instructions = new Queue<Instruction>();
            Dictionary<string, int> registers = new Dictionary<string, int>();
            StreamReader sr = new StreamReader(File.OpenRead("Puzzle8.txt"));
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] splits = line.Split(' ');
                string register = splits[0];
                instructions.Enqueue(new Instruction(splits));
                if (!registers.ContainsKey(register))
                {
                    registers.Add(register, 0);
                }
                line = sr.ReadLine();
            }
            int max = int.MinValue;
            while (instructions.Count > 0)
            {
                Instruction instruction = instructions.Dequeue();
                bool comparisonTrue = false;
                switch (instruction.comparison)
                {
                    case "==":
                        comparisonTrue = registers[instruction.registerToCheck] == instruction.valueToCheck;
                        break;
                    case ">":
                        comparisonTrue = registers[instruction.registerToCheck] > instruction.valueToCheck;
                        break;
                    case ">=":
                        comparisonTrue = registers[instruction.registerToCheck] >= instruction.valueToCheck;
                        break;
                    case "<":
                        comparisonTrue = registers[instruction.registerToCheck] < instruction.valueToCheck;
                        break;
                    case "<=":
                        comparisonTrue = registers[instruction.registerToCheck] <= instruction.valueToCheck;
                        break;
                    case "!=":
                        comparisonTrue = registers[instruction.registerToCheck] != instruction.valueToCheck;
                        break;
                }
                if (comparisonTrue)
                {
                    if (instruction.increase)
                    {
                        registers[instruction.register] += instruction.valueChange;
                    }
                    else
                    {
                        registers[instruction.register] -= instruction.valueChange;
                    }
                    int maxRegister = DetermineMax(ref registers).Value;
                    if (maxRegister > max)
                    {
                        max = maxRegister;
                    }
                }
            }
            if (isPuzzle2)
            {
                return max;
            }
            else
            {
                return DetermineMax(ref registers).Value;
            }
        }

        private static KeyValuePair<string, int> DetermineMax(ref Dictionary<string, int> registers)
        {
            KeyValuePair<string, int> max = new KeyValuePair<string, int>("a", int.MinValue);
            foreach (KeyValuePair<string, int> keyValuePair in registers)
            {
                if (keyValuePair.Value > max.Value)
                {
                    max = keyValuePair;
                }
            }
            return max;
        }

        public class Instruction
        {
            public readonly string register;
            public readonly bool increase;
            public readonly int valueChange;
            public readonly string registerToCheck;
            public readonly string comparison;
            public readonly int valueToCheck;

            //tzy inc 194 if ne == -3651
            public Instruction(string[] splits)
            {
                register = splits[0];
                increase = splits[1] == "inc";
                valueChange = Convert.ToInt32(splits[2]);
                registerToCheck = splits[4];
                comparison = splits[5];
                valueToCheck = Convert.ToInt32(splits[6]);
            }
        }
    }
}
