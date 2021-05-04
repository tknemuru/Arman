using Arman.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Keyence2020BTest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            //Test();
            TestFromFile();
        }

        /// <summary>
        /// 直接パラメータを指定してテストを実行します。
        /// </summary>
        private void Test()
        {
            var actual = Keyence2020B.Resolve(new string[]
            {
                "bX",
                "bX",
                "bX",
            });
            Assert.AreEqual(9, actual);

            actual = Keyence2020B.Resolve(new string[]
            {
                "bX",
                "bX",
                "bX",
            });
            Assert.AreEqual(9, actual);
        }

        /// <summary>
        /// ファイルからパラメータを読み込んでテストを実行します。
        /// </summary>
        private void TestFromFile()
        {
            var input = this.ReadResource(1, 1, ResourceType.In).ToArray();
            var actual = Keyence2020B.Resolve(input);
            Assert.AreEqual(3, actual);

            input = this.ReadResource(1, 2, ResourceType.In).ToArray();
            actual = Keyence2020B.Resolve(input);
            Assert.AreEqual(1, actual);

            input = this.ReadResource(1, 3, ResourceType.In).ToArray();
            actual = Keyence2020B.Resolve(input);
            Assert.AreEqual(5, actual);
        }
    }
}
