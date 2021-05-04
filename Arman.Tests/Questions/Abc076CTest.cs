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
    public class Abc076CTest : BaseUnitTest
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
            var actual = Abc076C.Resolve(new string[]
            {
                "cX",
                "cX",
                "cX",
            });
            Assert.AreEqual(9, actual);

            actual = Abc076C.Resolve(new string[]
            {
                "cX",
                "cX",
                "cX",
            });
            Assert.AreEqual(9, actual);
        }

        /// <summary>
        /// ファイルからパラメータを読み込んでテストを実行します。
        /// </summary>
        private void TestFromFile()
        {
            var input = this.ReadResource(1, 1, ResourceType.In).ToArray();
            var actual = Abc076C.Resolve(input);
            Assert.AreEqual("atcoder", actual);

            input = this.ReadResource(1, 2, ResourceType.In).ToArray();
            actual = Abc076C.Resolve(input);
            Assert.AreEqual("UNRESTORABLE", actual);
        }
    }
}
