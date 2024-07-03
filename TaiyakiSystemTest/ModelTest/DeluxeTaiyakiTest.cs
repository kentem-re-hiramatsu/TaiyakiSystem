using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class DeluxeTaiyakiTest
    {
        private DeluxeTaiyaki bigTaiyaki = new DeluxeTaiyaki(TaiyakiSizeType.大);

        /// <summary>
        /// サイズのテスト
        /// </summary>
        [TestMethod]
        public void SizeTest()
        {
            //大以外を選択した場合エラーを返す
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(TaiyakiSizeType.小));
            Assert.ThrowsException<Exception>(() => new DeluxeTaiyaki(TaiyakiSizeType.中));

            Assert.AreEqual(TaiyakiSizeType.大, bigTaiyaki.Size);
        }

        /// <summary>
        /// 名前のテスト
        /// </summary>
        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(TaiyakiType.デラックスたい焼き, bigTaiyaki.Name);
        }

        /// <summary>
        /// 中身のテスト
        /// </summary>
        [TestMethod]
        public void ContentTest()
        {
            Assert.AreEqual("生クリームとカスタード", bigTaiyaki.Content);
        }

        /// <summary>
        /// 値段のテスト
        /// </summary>
        [TestMethod]
        public void PriceTest()
        {
            Assert.AreEqual(300, bigTaiyaki.GetPrice());
        }
    }
}