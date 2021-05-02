using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc085/tasks/abc085_c
    /// </summary>
    public class Abc085C
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

        public static string Resolve(string inputStr)
        {
            var input = inputStr.Split(' ').Select(i => long.Parse(i)).ToArray();
            var N = input[0];
            var Y = input[1];
            var maxTen = Math.Min(Y / 10000L, N);
            var maxFive = Math.Min(Y / 5000L, N);
            var maxOne = Math.Min(Y / 1000L, N);
            var answer = "-1 -1 -1";
            for (var t = maxTen; 0L <= t; t--)
            {
                var remF = N - t;
                var maxF = Math.Min(remF, maxFive);
                for (var f = maxF; 0L <= f; f--)
                {
                    var o = remF - f;
                    var sumNum = t + f + o;
                    var sumMoney = t * 10000L + f * 5000L + o * 1000L;
                    if (sumNum == N && sumMoney == Y)
                    {
                        answer = $"{t} {f} {o}";
                        return answer;
                    }
                }
            }
            return answer;
        }
    }
}
