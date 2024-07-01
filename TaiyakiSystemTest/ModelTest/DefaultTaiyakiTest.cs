using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class DefaultTaiyakiTest
    {
        [TestMethod]
        public void DefaultTaiyakiConstructorTest()
        {
            var miniTaiyaki = new DefaultTaiyaki(TaiyakiSizeEnum.小);
            var middleTaiyaki = new DefaultTaiyaki(TaiyakiSizeEnum.中);
            var bigTaiyaki = new DefaultTaiyaki(TaiyakiSizeEnum.大);

            Assert.AreEqual(TaiyakiSizeEnum.小, miniTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeEnum.中, middleTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeEnum.大, bigTaiyaki.Size);

            Assert.AreEqual(TaiyakiEnum.通常たい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiEnum.通常たい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiEnum.通常たい焼き, bigTaiyaki.Name);

            Assert.AreEqual(TaiyakiContentEnum.あんこ, miniTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.あんこ, middleTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.あんこ, bigTaiyaki.Content);

            Assert.AreEqual(100, miniTaiyaki.GetSubTotal());
            Assert.AreEqual(150, middleTaiyaki.GetSubTotal());
            Assert.AreEqual(200, bigTaiyaki.GetSubTotal());
        }


        [TestMethod]
        public void GetCloneTaiyakiTest()
        {
            var taiyakiClone = new DefaultTaiyaki().GetCloneTaiyaki(TaiyakiSizeEnum.大);

            Assert.AreEqual(TaiyakiEnum.通常たい焼き, taiyakiClone.Name);
            Assert.AreEqual(TaiyakiSizeEnum.大, taiyakiClone.Size);
        }
    }
}