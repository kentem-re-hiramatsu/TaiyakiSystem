﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class DefaultTaiyakiTest
    {
        private DefaultTaiyaki miniTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.小);
        private DefaultTaiyaki middleTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.中);
        private DefaultTaiyaki bigTaiyaki = new DefaultTaiyaki(TaiyakiSizeType.大);

        /// <summary>
        /// サイズのテスト
        /// </summary>
        [TestMethod]
        public void SizeTest()
        {
            Assert.AreEqual(TaiyakiSizeType.小, miniTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeType.中, middleTaiyaki.Size);
            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size);
        }

        /// <summary>
        /// 名前のテスト
        /// </summary>
        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(TaiyakiType.通常たい焼き, miniTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, middleTaiyaki.Name);
            Assert.AreEqual(TaiyakiType.通常たい焼き, bigTaiyaki.Name);
        }

        /// <summary>
        /// 中身のテスト
        /// </summary>
        [TestMethod]
        public void ContentTest()
        {
            Assert.AreEqual("あんこ", miniTaiyaki.Content);
            Assert.AreEqual("あんこ", middleTaiyaki.Content);
            Assert.AreEqual("あんこ", bigTaiyaki.Content);
        }

        /// <summary>
        /// 値段のテスト
        /// </summary>
        [TestMethod]
        public void PriceTest()
        {
            Assert.AreEqual(100, miniTaiyaki.GetPrice());
            Assert.AreEqual(150, middleTaiyaki.GetPrice());
            Assert.AreEqual(200, bigTaiyaki.GetPrice());
        }
    }
}