using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Abc085CTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc085C.Resolve("9 45000");
            Assert.AreEqual("4 0 5", actual);
            actual = Abc085C.Resolve("20 196000");
            Assert.AreEqual("-1 -1 -1", actual);
            actual = Abc085C.Resolve("1000 1234000");
            Assert.AreEqual("26 0 974", actual);
            actual = Abc085C.Resolve("2000 20000000");
            Assert.AreEqual("2000 0 0", actual);
        }
    }
}
