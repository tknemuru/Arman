using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/tdpc/tasks/tdpc_contest
    /// </summary>
    public class TdpcCONTEST
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
            var N = int.Parse(inputs[0]);
            var nums = inputs[1].Split(' ').Select(i => int.Parse(i)).ToArray();
            var answers = new HashSet<int>();
            var answer = 0;
            for (var bit = 0; bit <= ((1 << N) - 1); bit++)
            {
                answer = 0;
                for (var i = 0; i < N; i++)
                {
                    if ((bit & (1 << i)) > 0)
                    {
                        answer += nums[i];
                    }
                }
                answers.Add(answer);
            }
            return answers.Count();
        }
    }
}
