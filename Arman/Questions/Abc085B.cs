using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc085/tasks/abc085_b
    /// </summary>
    public class Abc085B
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

            long N = long.Parse(Console.ReadLine());
            var nums = new long[N];
            for (var i = 0; i < N; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }
            var result = Resolve(N, nums);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(long N, long[] nums)
        {
            return nums.Distinct().Count();
        }
    }
}
