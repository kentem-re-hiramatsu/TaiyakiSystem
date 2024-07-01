using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class DeluxeTaiyakiTest
    {
        [TestMethod]
        public void DeluxeTaiyakiConstructorTest()
        {
            var bigTaiyaki = new DeluxeTaiyaki(TaiyakiSizeEnum.大);

            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(TaiyakiSizeEnum.小));
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(TaiyakiSizeEnum.中));

            Assert.AreEqual(TaiyakiSizeEnum.大, bigTaiyaki.Size);
            Assert.AreEqual(TaiyakiEnum.デラックスたい焼き, bigTaiyaki.Name);
            Assert.AreEqual(TaiyakiContentEnum.カスタード, bigTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.生クリーム, bigTaiyaki.AddingContent);
            Assert.AreEqual(300, bigTaiyaki.GetSubTotal());
        }
    }
}