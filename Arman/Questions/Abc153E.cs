using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc153/tasks/abc153_e
    /// </summary>
    public class Abc153E
    {
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

            var line = string.Empty;
            var inputs = new List<string>();
            while (true)
            {
                line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                inputs.Add(line);
            }
            var result = Resolve(inputs.ToArray());

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(string[] inputs)
        {
            var nums = inputs[0].Split(' ').Select(i => int.Parse(i)).ToArray();
            var H = nums[0];
            var N = nums[1];
            var magicks = inputs.Skip(1).Select(i => i.Split(' ').Select(i => int.Parse(i)).ToArray())
                .ToArray();
            var dp = new int[H + 1];
            for (var h = 0; h <= H; h++)
            {
                dp[h] = int.MaxValue;
            }
            dp[0] = 0;
            for (var h = 0; h <= H; h++)
            {
                if (dp[h] == int.MaxValue)
                {
                    continue;
                }
                for (var i = 0; i < N; i++)
                {
                    var hit = Math.Min(h + magicks[i][0], H);
                    dp[hit] = Math.Min(dp[h] + magicks[i][1], dp[hit]);
                }
            }

            return dp[H];
        }
    }
}
