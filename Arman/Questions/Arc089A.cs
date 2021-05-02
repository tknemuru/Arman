using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc086/tasks/arc089_a
    /// </summary>
    public class Arc089A
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
            var nums = new string[N];
            for (var i = 0; i < N; i++)
            {
                nums[i] = Console.ReadLine();
            }
            var result = Resolve(N, nums);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static string Resolve(long N, string[] numsStr)
        {
            var numsArray = numsStr.Select(s => s.Split(' ').Select(i => long.Parse(i)).ToArray());
            var start = new long[]{ 0L, 0L };
            var distance = 0L;
            var time = 0L;
            var lastTime = 0L;
            var can = false;
            var allCan = true;
            foreach (var nums in numsArray)
            {
                time = nums[0] - lastTime;
                // 最短距離をもとめる
                distance = Math.Abs(nums[1] - start[0]) + Math.Abs(nums[2] - start[1]);
                // 最短距離で間に合う、かつ、残時間が偶数なら到達できる
                can = distance <= time && (((time - distance) % 2L) == 0L);
                if (!can)
                {
                    allCan = false;
                    break;
                }
                // 次の準備
                lastTime = nums[0];
                start[0] = nums[1];
                start[1] = nums[2];
            }
            return allCan ? "Yes" : "No";
        }
    }
}
