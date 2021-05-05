using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/indeednow-finala-open/tasks/indeednow_2015_finala_c
    /// </summary>
    public class IndeednowfinalaopenIndeednow2015
    {
        /// <summary>
        /// 求人数
        /// </summary>
        private static int JobsLength;

        /// <summary>
        /// 求人リスト
        /// </summary>
        private static long[][] Jobs;

        /// <summary>
        /// 応募者リスト
        /// </summary>
        private static long[][] Mens;

        /// <summary>
        /// 求人値別要素数インデックス
        /// </summary>
        private static Dictionary<long, int>[] JobsCountIdx = new Dictionary<long, int>[3]
        {
            new Dictionary<long, int>(),
            new Dictionary<long, int>(),
            new Dictionary<long, int>(),
        };

        /// <summary>
        /// 求人値別インデックス
        /// </summary>
        private static Dictionary<long, List<int>>[] JobsValIdx = new Dictionary<long, List<int>>[3]
        {
            new Dictionary<long, List<int>>(),
            new Dictionary<long, List<int>>(),
            new Dictionary<long, List<int>>(),
        };

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

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            Console.Out.Flush();
        }

        public static long[] Resolve(string[] inputs)
        {
            var nums = inputs[0].Split(' ').Select(i => int.Parse(i)).ToArray();
            JobsLength = nums[0];
            var mensLength = nums[1];
            // 年収の降順でソートしておく
            var rand = new Random();
            Jobs = inputs.Skip(1).Take(JobsLength).Select(iStr => iStr.Split(' ').Select(i => long.Parse(i)).ToArray())
                .OrderBy(j => rand.Next())
                .OrderByDescending(j => j[3])
                .ToArray();
            Mens = inputs.Skip(1 + JobsLength).Select(iStr => iStr.Split(' ').Select(i => long.Parse(i)).ToArray())
                .ToArray();
            // 最高年収を特定
            var fees = Mens
                .Select(m =>
                {
                    var fee = 0L;
                    // インデックス作成
                    for (var i = 0; i < 3; i++)
                    {
                        BuildIndex(i, m[i]);
                    }
                    // 最も絞り込める項目を特定
                    var minIdx = 0;
                    var minCount = long.MaxValue;
                    for (var i = 0; i < 3; i++)
                    {
                        if (JobsCountIdx[i][m[i]] < minCount)
                        {
                            minCount = JobsCountIdx[i][m[i]];
                            minIdx = i;
                        }
                    }
                    // 走査
                    var targetIdxs = JobsValIdx[minIdx][m[minIdx]];
                    foreach (var i in targetIdxs)
                    {
                        var j = Jobs[i];
                        if (j[0] <= m[0] && j[1] <= m[1] && j[2] <= m[2])
                        {
                            fee = j[3];
                            break;
                        }
                    }
                    return fee;
                }).ToArray();
            return fees;
        }

        /// <summary>
        /// 走査用インデックスを組み立てます。
        /// </summary>
        /// <param name="idx">対象項目のインデックス</param>
        /// <param name="val">値</param>
        private static void BuildIndex(int idx, long val)
        {
            if (JobsCountIdx[idx].ContainsKey(val))
            {
                return;
            }
            JobsCountIdx[idx][val] = 0;
            JobsValIdx[idx][val] = new List<int>();

            for (var i = 0; i < JobsLength; i++)
            {
                if (Jobs[i][idx] <= val)
                {
                    JobsCountIdx[idx][val]++;
                    JobsValIdx[idx][val].Add(i);
                }
            }
        }
    }
}
