using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Atc001DfsATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Atc001DfsA.Resolve(new long[] { 3, 3 });
            Assert.AreEqual(9, actual);
        }
    }
}
