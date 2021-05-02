using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Abc088BTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc088B.Resolve("2", "3 1");
            Assert.AreEqual(2, actual);
            actual = Abc088B.Resolve("3", "2 7 4");
            Assert.AreEqual(5, actual);
            actual = Abc088B.Resolve("4", "20 18 2 18");
            Assert.AreEqual(18, actual);
        }
    }
}
