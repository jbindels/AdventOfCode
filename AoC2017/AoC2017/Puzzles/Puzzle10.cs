namespace AoC2017.Puzzles
{
    public class Puzzle10
    {
        public static int Solve(int[] inputs, int sizeOfList, bool isPuzzle2)
        {
            int[] list = new int[sizeOfList];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;
            }
            int current = 0;
            int skip = 0;

            foreach (int input in inputs)
            {
                int start = current;
                int[] reverse = new int[input];
                for (int i = 0; i < input; i++)
                {
                    if (start + i >= sizeOfList)
                    {
                        start = 0 - i;
                    }
                    reverse[input - i - 1] = list[start + i];
                }
                start = current;
                for (int i = 0; i < input; i++)
                {
                    if (start + i >= sizeOfList)
                    {
                        start = 0 - i;
                    }
                    list[start + i] = reverse[i];
                }
                current = current + input + skip;
                if (current >= sizeOfList)
                {
                    current -= sizeOfList;
                }
                skip++;
            }

            return list[0] * list[1];
        }
    }
}
