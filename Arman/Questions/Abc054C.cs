using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Questions
{
    /// <summary>
    /// https://atcoder.jp/contests/abc054/tasks/abc054_c
    /// </summary>
    public class Abc054C
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

        public static long Resolve(string[] inputs)
        {
            // 前準備
            var nums = inputs[0].Split(' ').Select(i => int.Parse(i)).ToArray();
            var pointCount = nums[0];
            var lineCount = nums[1];
            var nodesOrg = inputs
                .Skip(1)
                .Select(n => n.Split(' ').Select(i => int.Parse(i)).ToArray());
            var nodes = new Dictionary<int, List<int>>();
            foreach (var org in nodesOrg)
            {
                if (!nodes.ContainsKey(org[0]))
                {
                    nodes[org[0]] = new List<int>();
                }
                if (!nodes.ContainsKey(org[1]))
                {
                    nodes[org[1]] = new List<int>();
                }
                nodes[org[0]].Add(org[1]);
                nodes[org[1]].Add(org[0]);
            }

            // 本処理
            var answer = 0;
            // 1から始める
            var queue = new Queue<Tuple<List<int>, List<int>>>();
            var before = new List<int>() { 1 };
            var after = nodes[1];
            // 過去通ったノード・次に通るノードをTupleで管理する
            var target = new Tuple<List<int>, List<int>>(before, after);
            queue.Enqueue(target);
            while (queue.Count() > 0)
            {
                target = queue.Dequeue();
                var next = target.Item2.Except(target.Item1).ToList();
                // 全てのノードを通っていたらOK
                if (target.Item1.Count() >= pointCount)
                {
                    answer++;
                }
                next.Select(n =>
                {
                    queue.Enqueue(new Tuple<List<int>, List<int>>(target.Item1.Union(new int[] { n }).ToList(), nodes[n]));
                    return n;
                }).ToList();
            }
            return answer;
        }
    }
}
