using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    /// <summary>
    /// https://atcoder.jp/contests/abc141/tasks/abc141_a
    /// </summary>
    [TestClass]
    public class AbcTemplateTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = AbcTemplate.Resolve(3);
            Assert.AreEqual(9, actual);
        }
    }
}
