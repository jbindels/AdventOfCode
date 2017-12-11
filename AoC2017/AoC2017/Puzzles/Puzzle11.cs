using System.Collections.Generic;
using System.Linq;

namespace AoC2017.Puzzles
{
    public class Puzzle11
    {
        public static int Solve(string input, bool isPuzzle2)
        {
            int[] distance = new int[] {0, 0, 0};
            int max = 0;
            Dictionary<string, int[]> deltas = new Dictionary<string, int[]>();
            deltas.Add("n", new int[] {0, 1, -1});
            deltas.Add("s", new int[] {0, -1, 1});
            deltas.Add("ne", new int[] {1, 0, -1});
            deltas.Add("sw", new int[] {-1, 0, 1});
            deltas.Add("nw", new int[] {-1, 1, 0});
            deltas.Add("se", new int[] {1, -1, 0});
            string[] routes = input.Split(',');
            foreach (string route in routes)
            {
                distance = distance.Zip(deltas[route], (x, y) => x + y).ToArray();
                max = distance.Sum(d => d < 0 ? 0 : d) > max ? distance.Sum(d => d < 0 ? 0 : d) : max;
            }
            return isPuzzle2 ? max : distance.Sum(d => d < 0 ? 0 : d);
        }
    }
}
