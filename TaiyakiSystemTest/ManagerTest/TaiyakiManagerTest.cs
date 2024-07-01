using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ManagerTest
{
    [TestClass]
    public class TaiyakiManagerTest
    {
        [TestMethod]
        public void ManagerTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(TaiyakiSizeEnum.中);
            var defaultTaiyaki = new DefaultTaiyaki(TaiyakiSizeEnum.小);
            var deluxeTaiyaki = new DeluxeTaiyaki(TaiyakiSizeEnum.大);

            Assert.AreEqual(0, taiyakiMana.TaiyakiOrderList.Count);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(defaultTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(3, taiyakiMana.TaiyakiOrderList.Count);

            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiEnum.通常たい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiEnum.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(2).Name);

            var custardTaiyakiPrice = ((int)TaiyakiEnum.カスタードたい焼き) + ((int)TaiyakiSizeEnum.中);
            var defaultTaiyakiPrice = ((int)TaiyakiEnum.通常たい焼き) + ((int)TaiyakiSizeEnum.小);
            var deluxeTaiyakiPrice = ((int)TaiyakiEnum.デラックスたい焼き);

            var totalPrice = custardTaiyakiPrice + defaultTaiyakiPrice + deluxeTaiyakiPrice;

            Assert.AreEqual(totalPrice, taiyakiMana.GetTotalPrice());

            taiyakiMana.Remove(1);

            Assert.AreEqual(2, taiyakiMana.TaiyakiOrderList.Count);

            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiEnum.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
        }

        [TestMethod]
        public void ChangeOrderTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(TaiyakiSizeEnum.中);
            var defaultTaiyaki = new DefaultTaiyaki(TaiyakiSizeEnum.小);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(defaultTaiyaki);

            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeEnum.中, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(TaiyakiEnum.通常たい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeEnum.小, taiyakiMana.GetTaiyakiOrder(1).Size);

            taiyakiMana.ChangeOrder(0, TaiyakiSizeEnum.大);

            Assert.AreEqual(TaiyakiEnum.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeEnum.大, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(TaiyakiEnum.通常たい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeEnum.小, taiyakiMana.GetTaiyakiOrder(1).Size);
        }
    }
}