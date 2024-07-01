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
            var miniTaiyaki = new CustardTaiyaki(TaiyakiSizeEnum.小);
            var middleTaiyaki = new CustardTaiyaki(TaiyakiSizeEnum.中);
            var bigTaiyaki = new CustardTaiyaki(TaiyakiSizeEnum.大);

            Assert.AreEqual(TaiyakiSizeEnum.小, miniTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeEnum.中, middleTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeEnum.大, bigTaiyaki.Size);

            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, bigTaiyaki.Name);

            Assert.AreEqual(TaiyakiContentEnum.カスタード, miniTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.カスタード, middleTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.カスタード, bigTaiyaki.Content);

            Assert.AreEqual(150, miniTaiyaki.GetSubTotal());
            Assert.AreEqual(200, middleTaiyaki.GetSubTotal());
            Assert.AreEqual(250, bigTaiyaki.GetSubTotal());
        }
    }
}