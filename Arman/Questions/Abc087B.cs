using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc087/tasks/abc087_b
    /// </summary>
    public class Abc087B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            var strs = new string[3];
            strs[0] = Console.ReadLine();
            strs[1] = Console.ReadLine();
            strs[2] = Console.ReadLine();
            var sum = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long result = Resolve(strs, sum);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(string[] strs, string sumStr)
        {
            var count = 0L;
            var nums = strs.Select(s => long.Parse(s)).ToArray();
            var sum = long.Parse(sumStr);
            var maxFiveH = Math.Min(sum / 500L, nums[0]);
            var maxOneH = Math.Min(sum / 100L, nums[1]);
            var maxFive = Math.Min(sum / 50L, nums[2]);
            for (var fh = 0L; fh <= maxFiveH; fh++)
            {
                for (var oh = 0L; oh <= maxOneH; oh++)
                {
                    for (var f = 0L; f <= maxFive; f++)
                    {
                        var sumCalc = fh * 500L + oh * 100L + f * 50L;
                        if (sum == sumCalc)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}