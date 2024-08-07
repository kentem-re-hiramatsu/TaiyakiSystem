﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ManagerTest
{
    [TestClass]
    public class TaiyakiManagerTest
    {
        private TaiyakiSizeType smallSize = TaiyakiSizeType.小;
        private TaiyakiSizeType middleSize = TaiyakiSizeType.中;
        private TaiyakiSizeType bigSize = TaiyakiSizeType.大;

        /// <summary>
        /// 追加と合計金額のテスト
        /// </summary>
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

            Assert.AreEqual(middleSize, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(smallSize, taiyakiMana.GetTaiyakiOrder(1).Size);
            Assert.AreEqual(bigSize, taiyakiMana.GetTaiyakiOrder(2).Size);

            var custardTaiyakiPrice = new CustardTaiyaki(middleSize).TaiyakiPrice + (int)middleSize;
            var defaultTaiyakiPrice = new DefaultTaiyaki(smallSize).TaiyakiPrice + (int)smallSize;
            var deluxeTaiyakiPrice = new DeluxeTaiyaki(bigSize).TaiyakiPrice;

            var totalPrice = custardTaiyakiPrice + defaultTaiyakiPrice + deluxeTaiyakiPrice;

            Assert.AreEqual(totalPrice, taiyakiMana.GetTotalPrice());
        }

        /// <summary>
        /// 削除のテスト
        /// </summary>
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

            Assert.AreEqual(middleSize, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(bigSize, taiyakiMana.GetTaiyakiOrder(1).Size);
        }

        /// <summary>
        /// 変更のテスト
        /// </summary>
        [TestMethod]
        public void ChangeOrderTest()
        {
            var taiyakiMana = new TaiyakiManager();
            var custardTaiyaki = new CustardTaiyaki(middleSize);
            var deluxeTaiyaki = new DeluxeTaiyaki(bigSize);

            taiyakiMana.Add(custardTaiyaki);
            taiyakiMana.Add(deluxeTaiyaki);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeType.中, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(1).Size);

            taiyakiMana.ChangeOrder(0, bigSize);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, taiyakiMana.GetTaiyakiOrder(0).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(0).Size);
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, taiyakiMana.GetTaiyakiOrder(1).Name);
            Assert.AreEqual(TaiyakiSizeType.大, taiyakiMana.GetTaiyakiOrder(1).Size);

            //デラックスたい焼きのサイズは大のみのため小と中サイズはエラー
            Assert.ThrowsException<Exception>(() => taiyakiMana.ChangeOrder(1, smallSize));
            Assert.ThrowsException<Exception>(() => taiyakiMana.ChangeOrder(1, middleSize));
        }

        /// <summary>
        /// GetTaiyakiメソッドのテスト
        /// </summary>
        [TestMethod]
        public void GetTaiyakiTest()
        {
            var taiyakiMana = new TaiyakiManager();

            var smallSizeDefaultTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.通常たい焼き, smallSize);
            var middleSizeDefaultTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.通常たい焼き, middleSize);
            var bigSizeDefaultTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.通常たい焼き, bigSize);

            var smallSizeCustardTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.カスタードたい焼き, smallSize);
            var middleSizeCustardTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.カスタードたい焼き, middleSize);
            var bigSizeCustardTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.カスタードたい焼き, bigSize);

            var bigSizeDeluxeTaiyaki = taiyakiMana.GetTaiyaki(TaiyakiType.デラックスたい焼き, bigSize);

            Assert.AreEqual(TaiyakiType.通常たい焼き, smallSizeDefaultTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, middleSizeDefaultTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, bigSizeDefaultTaiyaki.Name);

            Assert.AreEqual(TaiyakiType.カスタードたい焼き, smallSizeCustardTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, middleSizeCustardTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.カスタードたい焼き, bigSizeCustardTaiyaki.Name);

            Assert.AreEqual(TaiyakiType.デラックスたい焼き, bigSizeDeluxeTaiyaki.Name);

            Assert.AreEqual(smallSize, smallSizeDefaultTaiyaki.Size);
            Assert.AreEqual(middleSize, middleSizeDefaultTaiyaki.Size);
            Assert.AreEqual(bigSize, bigSizeDefaultTaiyaki.Size);

            Assert.AreEqual(smallSize, smallSizeCustardTaiyaki.Size);
            Assert.AreEqual(middleSize, middleSizeCustardTaiyaki.Size);
            Assert.AreEqual(bigSize, bigSizeCustardTaiyaki.Size);

            Assert.AreEqual(bigSize, bigSizeDeluxeTaiyaki.Size);
        }
    }
}