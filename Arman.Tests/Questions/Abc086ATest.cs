using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    /// <summary>
    /// https://atcoder.jp/contests/abc141/tasks/abc141_a
    /// </summary>
    [TestClass]
    public class Abc086ATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            // 奇数
            var actual = Abc086A.Resolve(new long[]{ 3, 5 });
            Assert.AreEqual("Odd", actual);

            // 偶数
            actual = Abc086A.Resolve(new long[] { 3, 4 });
            Assert.AreEqual("Even", actual);
        }
    }
}
