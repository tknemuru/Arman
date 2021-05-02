using Arman.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arman.Tests
{
    [TestClass]
    public class Atc001DfsATest : BaseUnitTest
    {
        [TestMethod]
        public void 基本ケース()
        {
            var actual = Atc001DfsA.Resolve(
                4, 5,
                new string[]
                {
                    "s####",
                    "....#",
                    "#####",
                    "#...g"
                }
            );
            Assert.AreEqual("No", actual);
            actual = Atc001DfsA.Resolve(
                4, 4,
                new string[]
                {
                    "...s",
                    "....",
                    "....",
                    ".g.."
                }
            );
            Assert.AreEqual("Yes", actual);
            actual = Atc001DfsA.Resolve(
                10, 10,
                new string[]
                {
                    "s........",
                    "#########.",
                    "#.......#.",
                    "#..####.#.",
                    "##....#.#.",
                    "#####.#.#.",
                    "g.#.#.#.#.",
                    "#.#.#.#.#.",
                    "###.#.#.#.",
                    "#.....#..."
                }
            );
            Assert.AreEqual("No", actual);
            actual = Atc001DfsA.Resolve(
                10, 10,
                new string[]
                {
                    "s.........",
                    "#########.",
                    "#.......#.",
                    "#..####.#.",
                    "##....#.#.",
                    "#####.#.#.",
                    "g.#.#.#.#.",
                    "#.#.#.#.#.",
                    "#.#.#.#.#.",
                    "#.....#..."
                }
            );
            Assert.AreEqual("Yes", actual);
        }
    }
}
