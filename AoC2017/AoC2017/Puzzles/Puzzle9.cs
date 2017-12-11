namespace AoC2017.Puzzles
{
    public class Puzzle9
    {
        public static int Solve(string input, bool isPuzzle2)
        {
            int sumGroupCount = 0;
            int countGarbage = 0;
            int currentGroup = 0;
            bool garbage = false;
            bool escape = false;
            foreach (char c in input)
            {
                if (!escape)
                {
                    if (garbage)
                    {
                        if (c == '!')
                        {
                            escape = true;
                        }
                        else if (c == '>')
                        {
                            garbage = false;
                        }
                        else
                        {
                            countGarbage++;
                        }
                    }
                    else
                    {
                        if (c == '!')
                        {
                            escape = true;
                        }
                        else if (c == '<')
                        {
                            garbage = true;
                        }
                        else if (c == '{')
                        {
                            currentGroup++;
                            sumGroupCount += currentGroup;
                        }
                        else if (c == '}')
                        {
                            currentGroup--;
                        }
                    }
                }
                else
                {
                    escape = false;
                }
            }
            if (isPuzzle2)
            {
                return countGarbage;
            }
            return sumGroupCount;
        }
    }
}
