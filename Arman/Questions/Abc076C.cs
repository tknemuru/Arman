using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc076/tasks/abc076_c
    /// </summary>
    public class Abc076C
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

            var line = string.Empty;
            var inputs = new List<string>();
            while (true)
            {
                line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                inputs.Add(line);
            }
            var result = Resolve(inputs.ToArray());

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static string Resolve(string[] inputs)
        {
            var crypto = inputs[0];
            var hint = inputs[1];
            var range = hint.Length;
            var allLength = crypto.Length;
            var lastIndex = -1;
            for (var idx = 0; idx + range <= allLength; idx++)
            {
                var fragment = crypto.Substring(idx, range);
                var can = true;
                for (var i = 0; i < range; i++)
                {
                    if (fragment[i] != hint[i] && fragment[i] != '?')
                    {
                        can = false;
                        break;
                    }
                }
                if (can)
                {
                    lastIndex = idx;
                }
            }
            if (lastIndex < 0)
            {
                return "UNRESTORABLE";
            }
            var pre = lastIndex == 0 ? string.Empty : crypto.Substring(0, lastIndex);
            var suf = lastIndex + range == allLength ? string.Empty : crypto.Substring(lastIndex + range);
            var answer = $"{pre}{hint}{suf}".Replace('?', 'a');
            return answer;
        }
    }
}
