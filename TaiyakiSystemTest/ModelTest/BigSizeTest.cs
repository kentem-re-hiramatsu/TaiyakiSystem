using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class BigSizeTest
    {
        [TestMethod]
        public void GetTypeAndPrice()
        {
            var size = new BigSize();

            Assert.AreEqual(TaiyakiSizeType.大, size.Type);
            Assert.AreEqual(100, size.Price);
        }
    }
}