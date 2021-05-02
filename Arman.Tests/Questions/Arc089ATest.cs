using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Arc089ATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Arc089A.Resolve(
                2,
                new string[] {
                    "3 1 2",
                    "6 1 1"
                }
            );
            Assert.AreEqual("Yes", actual);
            actual = Arc089A.Resolve(
                1,
                new string[] {
                    "2 100 100"
                }
            );
            Assert.AreEqual("No", actual);
            actual = Arc089A.Resolve(
                2,
                new string[] {
                    "5 1 1",
                    "100 1 1"
                }
            );
            Assert.AreEqual("No", actual);
        }
    }
}
