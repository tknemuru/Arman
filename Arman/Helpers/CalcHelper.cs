using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arman.Helpers
{
    public static class CalcHelper
    {
        /// <summary>
        /// long型のRangeを生成します。
        /// </summary>
        /// <param name="start">開始数</param>
        /// <param name="count">要素数</param>
        /// <returns>long型のRange</returns>
        private static IEnumerable<long> RangeLong(long start, long count)
        {
            var max = start + count;
            for (var i = start; i < max; i++)
            {
                yield return i;
            }
        }
    }
}
