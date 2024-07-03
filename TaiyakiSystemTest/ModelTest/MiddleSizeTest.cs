using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystemTest.ModelTest
{
    [TestClass]
    public class MiddleSizeTest
    {
        [TestMethod]
        public void GetTypeAndPrice()
        {
            var size = new MiddleSize();

            Assert.AreEqual(TaiyakiSizeType.中, size.Type);
            Assert.AreEqual(50, size.Price);
        }
    }
}