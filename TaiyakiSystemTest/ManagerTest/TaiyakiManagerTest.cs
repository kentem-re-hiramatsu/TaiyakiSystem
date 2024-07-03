using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            var custardTaiyaki = new CustardTaiyaki(TaiyakiSizeType.中);
            var defaultTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.小);
            var deluxeTaiyaki = new DeluxeTaiyaki(TaiyakiSizeType.大);

            Assert.AreEqual(0, taiyakiMana.TaiyakiOrderList.Count);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(defaultTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(3, taiyakiMana.TaiyakiOrderList.Count);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(2).Name);

            var custardTaiyakiPrice = ((int)TaiyakiType.カスタードたい焼き) + ((int)TaiyakiSizeType.中);
            var defaultTaiyakiPrice = ((int)TaiyakiType.通常たい焼き) + ((int)TaiyakiSizeType.小);
            var deluxeTaiyakiPrice = ((int)TaiyakiType.デラックスたい焼き);

            var totalPrice = custardTaiyakiPrice + defaultTaiyakiPrice + deluxeTaiyakiPrice;

            Assert.AreEqual(totalPrice, taiyakiMana.GetTotalPrice());

            taiyakiMana.Remove(1);

            Assert.AreEqual(2, taiyakiMana.TaiyakiOrderList.Count);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
        }

        [TestMethod]
        public void ChangeOrderTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(TaiyakiSizeType.中);
            var deluxeTaiyaki = new DeluxeTaiyaki(TaiyakiSizeType.大);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeType.中, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(1).Size);

            taiyakiMana.ChangeOrder(0, TaiyakiSizeType.大);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(1).Size);

            Assert.ThrowsException<Exception>(() => taiyakiMana.ChangeOrder(1, TaiyakiSizeType.小));
            Assert.ThrowsException<Exception>(() => taiyakiMana.ChangeOrder(1, TaiyakiSizeType.中));
        }
    }
}