using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc083/tasks/arc088_a
    /// </summary>
    public class Abc083Arc088A
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
            var nums = inputs[0].Split(' ').Select(i => long.Parse(i)).ToArray();
            var curr = nums[0];
            var max = nums[1];
            var count = 0L;
            while (curr <= max)
            {
                count++;
                curr *= 2;
            }
            return count;
        }
    }
}
