using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc007/tasks/abc007_3
    /// </summary>
    public class Abc0073
    {
        /// <summary>
        /// 方向
        /// </summary>
        private static readonly int[][] Directions = new int[][]
        {
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { -1, 0 },
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

            var arg = string.Empty;
            var strArgs = new List<string>();
            while (true)
            {
                arg = Console.ReadLine();
                if (string.IsNullOrEmpty(arg))
                {
                    break;
                }
                strArgs.Add(arg);
            }
            var result = Resolve(strArgs.ToArray());

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(string[] args)
        {
            var nums = args[0].Split(' ').Select(i => int.Parse(i)).ToArray();
            var H = nums[0];
            var W = nums[1];
            var s = args[1].Split(' ').Select(i => int.Parse(i) - 1).ToArray();
            var g = args[2].Split(' ').Select(i => int.Parse(i) - 1).ToArray();
            var map = new int[H][];
            for (var h = 0; h < H; h++)
            {
                var rowStr = args[h + 3];
                var row = new int[W];
                var length = row.Length;
                for (var w = 0; w < length; w++)
                {
                    row[w] = rowStr[w] == '#' ? 0 : -1;
                }
                map[h] = row;
            }
            // スタートは0
            map[s[0]][s[1]] = 0;

            var queue = new Queue<int[]>();
            queue.Enqueue(s);
            int[] curr;
            while (queue.Count() > 0)
            {
                curr = queue.Dequeue();
                if (curr[0] == g[0] && curr[1] == g[1])
                {
                    break;
                }
                Directions
                    .Select(d => new int[] { curr[0] + d[0], curr[1] + d[1] })
                    .Where(n => n[0] > -1 && n[1] > -1 && map[n[0]][n[1]] == -1)
                    .Select(n =>
                    {
                        map[n[0]][n[1]] = map[curr[0]][curr[1]] + 1;
                        queue.Enqueue(n);
                        return n;
                    })
                    .ToList();
            }
            return map[g[0]][g[1]];
        }
    }
}
