using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/arc061/tasks/arc061_a
    /// </summary>
    public class Arc061A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var result = Resolve(s);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static long Resolve(string S)
        {
            var sum = 0L;
            var N = S.Length;
            for (var bit = 0; bit < (1 << (N - 1)); bit++)
            {
                var temp = 0L;
                for (var i = 0; i < N; i++)
                {
                    temp = (temp * 10) + Convert.ToInt64(S[i].ToString());
                    if ((bit & (1 << i)) > 0)
                    {
                        sum += temp;
                        temp = 0L;
                    }
                }
                sum += temp;
            }
            return sum;
        }
    }
}
