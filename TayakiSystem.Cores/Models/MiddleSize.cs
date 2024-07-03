using TaiyakiSystem.Cores.Enums;

namespace TayakiSystem.Cores.Models
{
    public class MiddleSize : Size
    {
        private const TaiyakiSizeType TYPE = TaiyakiSizeType.中;
        private const int PRICE = 50;

        public MiddleSize()
        {
            InitialSetting(TYPE, PRICE);
        }
    }
}