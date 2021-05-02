using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/atc001/tasks/dfs_a
    /// </summary>
    public class Atc001DfsA
    {
        private enum Direction
        {
            None,
            Up,
            Down,
            Right,
            Left
        }
        private static readonly Dictionary<Direction, int[]> DirectionMoves = new Dictionary<Direction, int[]>()
        {
            { Direction.Up, new int[] { 0, -1 } },
            { Direction.Down, new int[] { 0, 1 } },
            { Direction.Right, new int[] { 1, 0 } },
            { Direction.Left, new int[] { -1, 0 } }
        };
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            //// 文字列の入力
            //string s = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var length = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            var H = length[0];
            var W = length[1];
            var rows = new string[H];
            for (var i = 0; i < H; i++)
            {
                rows[i] = Console.ReadLine();
            }
            var result = Resolve(H, W, rows);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static string Resolve(int H, int W, string[] rows)
        {
            var wall = Enumerable.Range(0, W + 2).Aggregate(string.Empty, (p, c) => $"{p}#");
            var map = new List<string>();
            var s = new int[2];
            var g = new int[2];
            map.Add(wall);
            for (var i = 0; i < H; i++)
            {
                var sX = rows[i].IndexOf('s');
                if (sX > -1)
                {
                    s[0] = sX + 1;
                    s[1] = i + 1;
                }
                var gX = rows[i].IndexOf('g');
                if (gX > -1)
                {
                    g[0] = gX + 1;
                    g[1] = i + 1;
                }
                map.Add($"#{rows[i]}#");
            }
            map.Add(wall);
            var mapArray = map.ToArray();
            var can = CanGoal(s, g, mapArray);
            return can ? "Yes" : "No";
        }

        private static bool CanGoal(int[] current, int[] g, string[] map)
        {
            if (g[0] == current[0] && g[1] == current[1])
            {
                return true;
            }
            if (map[current[1]][current[0]] == '#')
            {
                return false;
            }
            // 現在値を壁で塗りつぶす
            var orgRow = map[current[1]];
            var index = current[0];
            map[current[1]] = $"{orgRow.Substring(0, index)}{"#"}{orgRow.Substring(index + 1)}";
            var result = false;
            foreach (var dir in DirectionMoves)
            {
                var next = AddDirection(current, dir.Key);
                result = CanGoal(next, g, map);
                if (result)
                {
                    break;
                }
            }
            return result;
        }

        private static int[] AddDirection(int[] curr, Direction dir)
        {
            var move = DirectionMoves[dir];
            return new int[] { curr[0] + move[0], curr[1] + move[1] };
        }
    }
}
