using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Arc065ATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Arc065A.Resolve("erasedream");
            Assert.AreEqual("YES", actual);
            actual = Arc065A.Resolve("dreameraser");
            Assert.AreEqual("YES", actual);
            actual = Arc065A.Resolve("dreamerer");
            Assert.AreEqual("NO", actual);
        }
    }
}
