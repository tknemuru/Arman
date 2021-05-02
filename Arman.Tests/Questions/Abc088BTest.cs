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
            var actual = Abc088B.Resolve(new long[] { 3, 3 });
            Assert.AreEqual(9, actual);
        }
    }
}
