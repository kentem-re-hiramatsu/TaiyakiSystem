using TaiyakiSystem.Cores.Enums;

namespace TayakiSystem.Cores.Models
{
    public class MiddleSize : Size
    {
        private const TaiyakiSizeType TYPE = TaiyakiSizeType.中;
        private const int PRICE = 100;

        public MiddleSize()
        {
            Type = TYPE;
            Price = PRICE;
        }
    }
}