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
    public class Abc081A
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

        public static int Resolve(string s)
        {
            var num = Convert.ToInt64(s, 2);
            var a = ((num & 0b001) > 0) ? 1 : 0;
            var b = ((num & 0b010) > 0) ? 1 : 0;
            var c = ((num & 0b100) > 0) ? 1 : 0;
            return a + b + c;
        }
    }
}