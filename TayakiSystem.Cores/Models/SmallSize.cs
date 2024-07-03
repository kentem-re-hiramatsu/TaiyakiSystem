using TaiyakiSystem.Cores.Enums;

namespace TayakiSystem.Cores.Models
{
    public class SmallSize : Size
    {
        private const TaiyakiSizeType TYPE = TaiyakiSizeType.小;
        private const int PRICE = 0;

        public SmallSize()
        {
            Type = TYPE;
            Price = PRICE;
        }
    }
}