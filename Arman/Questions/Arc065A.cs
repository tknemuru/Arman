using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc049/tasks/arc065_a
    /// </summary>
    public class Arc065A
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string S = Console.ReadLine();

            //// 整数の入力
            //long n = long.Parse(Console.ReadLine());

            //// 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            //// 整数配列の入力
            //var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var result = Resolve(S);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static string Resolve(string S)
        {
            var s = S
                .Replace("eraser", "")
                .Replace("erase", "")
                .Replace("dreamer", "")
                .Replace("dream", "");
            return s == string.Empty ? "YES" : "NO";
        }
    }
}
