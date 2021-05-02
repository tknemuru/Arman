using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Arc061ATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Arc061A.Resolve("125");
            Assert.AreEqual(176, actual);
            actual = Arc061A.Resolve("9999999999");
            Assert.AreEqual(12656242944, actual);
        }
    }
}
