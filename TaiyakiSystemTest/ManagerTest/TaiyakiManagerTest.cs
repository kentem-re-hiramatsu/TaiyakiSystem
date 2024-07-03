using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;
using TaiyakiSystem.Cores.Models;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ManagerTest
{
    [TestClass]
    public class TaiyakiManagerTest
    {
        private SmallSize smallSize = new SmallSize();
        private MiddleSize middleSize = new MiddleSize();
        private BigSize bigSize = new BigSize();

        [TestMethod]
        public void AddAndTotalPriceTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(middleSize);
            var defaultTaiyaki = new DefaultTaiyaki(smallSize);
            var deluxeTaiyaki = new DeluxeTaiyaki(bigSize);

            Assert.AreEqual(0, taiyakiMana.TaiyakiOrderList.Count);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(defaultTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(3, taiyakiMana.TaiyakiOrderList.Count);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(2).Name);

            Assert.AreEqual(middleSize.Type, taiyakiMana.GetTaiyakiOrder(0).Size.Type);
            Assert.AreEqual(smallSize.Type, taiyakiMana.GetTaiyakiOrder(1).Size.Type);
            Assert.AreEqual(bigSize.Type, taiyakiMana.GetTaiyakiOrder(2).Size.Type);

            var custardTaiyakiPrice = new CustardTaiyaki(middleSize).TaiyakiPrice + middleSize.Price;
            var defaultTaiyakiPrice = new DefaultTaiyaki(smallSize).TaiyakiPrice + smallSize.Price;
            var deluxeTaiyakiPrice = new DeluxeTaiyaki(bigSize).TaiyakiPrice;

            var totalPrice = custardTaiyakiPrice + defaultTaiyakiPrice + deluxeTaiyakiPrice;

            Assert.AreEqual(totalPrice, taiyakiMana.GetTotalPrice());
        }

        [TestMethod]
        public void RemoveTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(middleSize);
            var defaultTaiyaki = new DefaultTaiyaki(smallSize);
            var deluxeTaiyaki = new DeluxeTaiyaki(bigSize);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(defaultTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(3, taiyakiMana.TaiyakiOrderList.Count);

            taiyakiMana.Remove(1);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);

            Assert.AreEqual(middleSize.Type, taiyakiMana.GetTaiyakiOrder(0).Size.Type);
            Assert.AreEqual(bigSize.Type, taiyakiMana.GetTaiyakiOrder(1).Size.Type);
        }

        [TestMethod]
        public void ChangeOrderTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(middleSize);
            var deluxeTaiyaki = new DeluxeTaiyaki(bigSize);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeType.中, taiyakiMana.GetTaiyakiOrder(0).Size.Type);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(1).Size.Type);

            taiyakiMana.ChangeOrder(0, bigSize);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(0).Size.Type);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(1).Size.Type);

            Assert.ThrowsException<Exception>(() => taiyakiMana.ChangeOrder(1, smallSize));
            Assert.ThrowsException<Exception>(() => taiyakiMana.ChangeOrder(1, middleSize));
        }
    }
}