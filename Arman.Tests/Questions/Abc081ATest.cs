using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    /// <summary>
    /// https://atcoder.jp/contests/abc141/tasks/abc141_a
    /// </summary>
    [TestClass]
    public class Abc081ATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc081A.Resolve("000");
            Assert.AreEqual(0, actual);
            actual = Abc081A.Resolve("010");
            Assert.AreEqual(1, actual);
            actual = Abc081A.Resolve("110");
            Assert.AreEqual(2, actual);
            actual = Abc081A.Resolve("111");
            Assert.AreEqual(3, actual);
        }
    }
}
