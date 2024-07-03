using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class CustardTaiyakiTest
    {
        private CustardTaiyaki miniTaiyaki = new CustardTaiyaki(new SmallSize());
        private CustardTaiyaki middleTaiyaki = new CustardTaiyaki(new MiddleSize());
        private CustardTaiyaki bigTaiyaki = new CustardTaiyaki(new BigSize());

        /// <summary>
        /// サイズのテスト
        /// </summary>
        [TestMethod]
        public void SizeTest()
        {
            Assert.AreEqual(TaiyakiSizeType.小, miniTaiyaki.Size.Type);
            Assert.AreEqual(TaiyakiSizeType.中, middleTaiyaki.Size.Type);
            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size.Type);
        }

        /// <summary>
        /// 名前のテスト
        /// </summary>
        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, bigTaiyaki.Name);
        }

        /// <summary>
        /// 中身のテスト
        /// </summary>
        [TestMethod]
        public void ContentTest()
        {
            Assert.AreEqual("カスタード", miniTaiyaki.Content);
            Assert.AreEqual("カスタード", middleTaiyaki.Content);
            Assert.AreEqual("カスタード", bigTaiyaki.Content);
        }

        /// <summary>
        /// 値段のテスト
        /// </summary>
        [TestMethod]
        public void PriceTest()
        {
            Assert.AreEqual(150, miniTaiyaki.GetPrice());
            Assert.AreEqual(200, middleTaiyaki.GetPrice());
            Assert.AreEqual(250, bigTaiyaki.GetPrice());
        }
    }
}