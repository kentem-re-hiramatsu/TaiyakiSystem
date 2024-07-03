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
            var miniTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.小);
            var middleTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.中);
            var bigTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.大);

            Assert.AreEqual(TaiyakiSizeType.小, miniTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeType.中, middleTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size);

            Assert.AreEqual(TaiyakiType.通常たい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, bigTaiyaki.Name);

            Assert.AreEqual(TaiyakiContentEnum.あんこ, miniTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.あんこ, middleTaiyaki.Content);
            Assert.AreEqual(TaiyakiContentEnum.あんこ, bigTaiyaki.Content);

            Assert.AreEqual(100, miniTaiyaki.GetPrice());
            Assert.AreEqual(150, middleTaiyaki.GetPrice());
            Assert.AreEqual(200, bigTaiyaki.GetPrice());
        }


        [TestMethod]
        public void GetCloneTaiyakiTest()
        {
            var taiyakiClone = new DefaultTaiyaki().GetCloneTaiyaki(TaiyakiSizeType.大);

            Assert.AreEqual(TaiyakiType.通常たい焼き, taiyakiClone.Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiClone.Size);
        }
    }
}