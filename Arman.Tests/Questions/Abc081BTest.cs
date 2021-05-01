using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Abc081BTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Abc081B.Resolve("3", new string[] { "8", "12", "40" });
            Assert.AreEqual(2, actual);
            actual = Abc081B.Resolve("4", new string[] { "5", "6", "8", "10" });
            Assert.AreEqual(0, actual);
            actual = Abc081B.Resolve("6", new string[] { "382253568", "723152896", "37802240", "379425024", "404894720", "471526144" });
            Assert.AreEqual(8, actual);
        }
    }
}
