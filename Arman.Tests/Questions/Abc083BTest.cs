using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Abc083BTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc083B.Resolve(new long[] { 20, 2, 5 });
            Assert.AreEqual(84, actual);
            actual = Abc083B.Resolve(new long[] { 10, 1, 2 });
            Assert.AreEqual(13, actual);
            actual = Abc083B.Resolve(new long[] { 100, 4, 16 });
            Assert.AreEqual(4554, actual);
        }
    }
}
