using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class TaiyakiMenuTest
    {
        [TestMethod]
        public void MenuTest()
        {
            var taiyakiMenu = new TaiyakiMenu();

            var defaultTaiyaki = taiyakiMenu.GetTaiyaki(0, TaiyakiSizeEnum.中);
            Assert.AreEqual(TaiyakiEnum.通常たい焼き, defaultTaiyaki.Name);

            var custardTaiyaki = taiyakiMenu.GetTaiyaki(1, TaiyakiSizeEnum.中);
            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, custardTaiyaki.Name);

            var deluxeTaiyaki = taiyakiMenu.GetTaiyaki(2, TaiyakiSizeEnum.大);
            Assert.AreEqual(TaiyakiEnum.デラックスたい焼き, deluxeTaiyaki.Name);
        }
    }
}
