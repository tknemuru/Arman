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
    public class Joi2008yoATest : BaseUnitTest
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
            var actual = Joi2008yoA.Resolve(new string[]
            {
                "aX",
                "aX",
                "aX",
            });
            Assert.AreEqual(9, actual);

            actual = Joi2008yoA.Resolve(new string[]
            {
                "aX",
                "aX",
                "aX",
            });
            Assert.AreEqual(9, actual);
        }

        /// <summary>
        /// ファイルからパラメータを読み込んでテストを実行します。
        /// </summary>
        private void TestFromFile()
        {
            var input = this.ReadResource(1, 1, ResourceType.In).ToArray();
            var actual = Joi2008yoA.Resolve(input);
            Assert.AreEqual(4, actual);

            input = this.ReadResource(1, 2, ResourceType.In).ToArray();
            actual = Joi2008yoA.Resolve(input);
            Assert.AreEqual(15, actual);
        }
    }
}
