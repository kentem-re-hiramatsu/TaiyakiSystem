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
            var bigTaiyaki = new DeluxeTaiyaki(TaiyakiSizeType.大);

            //大以外を選択した場合エラーを返す
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(TaiyakiSizeType.小));
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(TaiyakiSizeType.中));

            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, bigTaiyaki.Name);
            Assert.AreEqual(TaiyakiContentEnum.カスタード, bigTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.生クリーム, bigTaiyaki.DeluxeTaiyakiContent);
            Assert.AreEqual(300, bigTaiyaki.GetSubTotal());
        }

        [TestMethod]
        public void GetCloneTaiyakiTest()
        {
            var taiyakiClone = new DeluxeTaiyaki().GetCloneTaiyaki(TaiyakiSizeType.大);

            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiClone.Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiClone.Size);
        }
    }
}