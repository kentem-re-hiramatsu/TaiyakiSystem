using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class SmallSizeTest
    {
        [TestMethod]
        public void GetTypeAndPrice()
        {
            var size = new SmallSize();

            Assert.AreEqual(TaiyakiSizeType.小, size.Type);
            Assert.AreEqual(0, size.Price);
        }
    }
}