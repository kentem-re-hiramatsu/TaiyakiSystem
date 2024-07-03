using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class CustardTaiyakiTest
    {
        [TestMethod]
        public void CustardTaiyakiConstructorTest()
        {
            var miniTaiyaki = new CustardTaiyaki(TaiyakiSizeType.小);
            var middleTaiyaki = new CustardTaiyaki(TaiyakiSizeType.中);
            var bigTaiyaki = new CustardTaiyaki(TaiyakiSizeType.大);

            Assert.AreEqual(TaiyakiSizeType.小, miniTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeType.中, middleTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, bigTaiyaki.Name);

            Assert.AreEqual(TaiyakiContentEnum.カスタード, miniTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.カスタード, middleTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.カスタード, bigTaiyaki.Content);

            Assert.AreEqual(150, miniTaiyaki.GetPrice());
            Assert.AreEqual(200, middleTaiyaki.GetPrice());
            Assert.AreEqual(250, bigTaiyaki.GetPrice());
        }

        [TestMethod]
        public void GetCloneTaiyakiTest()
        {
            var taiyakiClone = new CustardTaiyaki().GetCloneTaiyaki(TaiyakiSizeType.中);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiClone.Name);
            Assert.AreEqual(TaiyakiSizeType.中, taiyakiClone.Size);
        }
    }
}