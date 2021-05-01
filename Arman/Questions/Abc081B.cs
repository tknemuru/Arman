using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc081/tasks/abc081_a
    /// </summary>
    public class Abc081B
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s1 = Console.ReadLine();
            var s2 = Console.ReadLine().Split(' ');

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

        public static long Resolve(string N, string[] strs)
        {
            var count = 0L;
            var nums = strs.Select(s => long.Parse(s));
            while (true)
            {
                var has = nums.All(n => n % 2 == 0);
                if (!has)
                {
                    break;
                }
                count++;
                nums = nums.Select(n => n / 2);
            }
            return count;
        }
    }
}