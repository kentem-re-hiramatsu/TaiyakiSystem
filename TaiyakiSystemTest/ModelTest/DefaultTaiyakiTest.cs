using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class DefaultTaiyakiTest
    {
        private DefaultTaiyaki miniTaiyaki = new DefaultTaiyaki(new SmallSize());
        private DefaultTaiyaki middleTaiyaki = new DefaultTaiyaki(new MiddleSize());
        private DefaultTaiyaki bigTaiyaki = new DefaultTaiyaki(new BigSize());

        [TestMethod]
        public void SizeTest()
        {
            Assert.AreEqual(TaiyakiSizeType.小, miniTaiyaki.Size.Type);
            Assert.AreEqual(TaiyakiSizeType.中, middleTaiyaki.Size.Type);
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