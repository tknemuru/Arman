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
    public class Abc153ETest : BaseUnitTest
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
            var actual = Abc153E.Resolve(new string[]
            {
                "eX",
                "eX",
                "eX",
            });
            Assert.AreEqual(9, actual);

            actual = Abc153E.Resolve(new string[]
            {
                "eX",
                "eX",
                "eX",
            });
            Assert.AreEqual(9, actual);
        }

        /// <summary>
        /// ファイルからパラメータを読み込んでテストを実行します。
        /// </summary>
        private void TestFromFile()
        {
            var input = this.ReadResource(1, 1, ResourceType.In).ToArray();
            var actual = Abc153E.Resolve(input);
            Assert.AreEqual(4, actual);

            input = this.ReadResource(1, 2, ResourceType.In).ToArray();
            actual = Abc153E.Resolve(input);
            Assert.AreEqual(100, actual);

            input = this.ReadResource(1, 3, ResourceType.In).ToArray();
            actual = Abc153E.Resolve(input);
            Assert.AreEqual(139815, actual);
        }
    }
}
