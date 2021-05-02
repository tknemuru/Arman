using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Abc085BTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc085B.Resolve(4, new long[] { 10, 8, 8, 6 });
            Assert.AreEqual(3, actual);
            actual = Abc085B.Resolve(3, new long[] { 15, 15, 15 });
            Assert.AreEqual(1, actual);
            actual = Abc085B.Resolve(7, new long[] { 50, 30, 50, 100, 50, 80, 30 });
            Assert.AreEqual(4, actual);
        }
    }
}
