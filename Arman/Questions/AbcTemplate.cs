using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc141/tasks/abc141_a
    /// </summary>
    public class AbcTemplate
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            string result = Resolve(inputLongArray);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static String Resolve(long[] nums)
        {
            return (nums[0] * nums[1]).ToString();
        }
    }
}