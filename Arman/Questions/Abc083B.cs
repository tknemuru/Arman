using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc083/tasks/abc083_b
    /// </summary>
    public class Abc083B
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

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var result = Resolve(inputLongArray);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(long[] nums)
        {
            var sum = 0L;
            var target = nums[0];
            var min = nums[1];
            var max = nums[2];
            for (var i = 1L; i <= target; i++)
            {
                var padNumStr = i.ToString().PadLeft(6, '0');
                var padSum = padNumStr.Sum(c => Convert.ToInt64(c.ToString()));
                if (min <= padSum && padSum <= max)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}