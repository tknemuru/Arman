using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Abc087BTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc087B.Resolve(new string[] { "2", "2", "2" }, "100");
            Assert.AreEqual(2, actual);
            actual = Abc087B.Resolve(new string[] { "5", "1", "0" }, "150");
            Assert.AreEqual(0, actual);
            actual = Abc087B.Resolve(new string[] { "30", "40", "50" }, "6000");
            Assert.AreEqual(213, actual);


        }
    }
}
