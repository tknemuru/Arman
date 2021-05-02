using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc088/tasks/abc088_b
    /// </summary>
    public class Abc088B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var result = Resolve(s1, s2);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(string NStr, string numsStr)
        {
            var rand = new Random();
            var N = long.Parse(NStr);
            var nums = numsStr.Split(' ')
                .Select(i => long.Parse(i))
                .OrderBy(n => rand.Next())
                .OrderByDescending(n => n);
            var alice = nums.Where((n, i) => i % 2 == 0).Sum(n => n);
            var bob = nums.Where((n, i) => i % 2 == 1).Sum(n => n);
            return alice - bob;
        }
    }
}
