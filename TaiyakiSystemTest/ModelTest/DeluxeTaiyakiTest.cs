using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class DeluxeTaiyakiTest
    {
        private DeluxeTaiyaki miniTaiyaki = new DeluxeTaiyaki(new SmallSize());
        private DeluxeTaiyaki middleTaiyaki = new DeluxeTaiyaki(new MiddleSize());
        private DeluxeTaiyaki bigTaiyaki = new DeluxeTaiyaki(new BigSize());

        [TestMethod]
        public void SizeTest()
        {
            //大以外を選択した場合エラーを返す
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(new SmallSize()));
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(new MiddleSize()));

            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size.Type);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(TaiyakiType.通常たい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, bigTaiyaki.Name);
        }

        [TestMethod]
        public void ContentTest()
        {
            Assert.AreEqual("あんこ", miniTaiyaki.Content);
            Assert.AreEqual("あんこ", middleTaiyaki.Content);
            Assert.AreEqual("あんこ", bigTaiyaki.Content);
        }

        [TestMethod]
        public void PriceTest()
        {
            Assert.AreEqual(100, miniTaiyaki.GetPrice());
            Assert.AreEqual(150, middleTaiyaki.GetPrice());
            Assert.AreEqual(200, bigTaiyaki.GetPrice());
        }
    }
}