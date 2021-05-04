using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/keyence2020/tasks/keyence2020_b
    /// </summary>
    public class Keyence2020B
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
            var rand = new Random();
            var N = long.Parse(inputs[0]);
            var robos = inputs.Skip(1).Select(inp =>
            {
                var nums = inp.Split(' ').Select(i => long.Parse(i)).ToArray();
                var position = nums[0];
                var start = position - nums[1];
                var end = position + nums[1];
                return new long[] { position, start, end };
            })
                .OrderBy(r => rand.Next())
                .OrderBy(r => r[2]);
            var exceptedCount = 0L;
            var lastRobo = robos.First();
            foreach (var robo in robos.Skip(1))
            {
                // 前回と重複があったら除外
                if (robo[1] < lastRobo[2])
                {
                    exceptedCount++;
                    continue;
                }
                lastRobo = robo;
            }
            return N - exceptedCount;
        }
    }
}
