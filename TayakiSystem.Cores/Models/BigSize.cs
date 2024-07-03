using TaiyakiSystem.Cores.Enums;

namespace TayakiSystem.Cores.Models
{
    public class BigSize : Size
    {
        private const TaiyakiSizeType TYPE = TaiyakiSizeType.大;
        private const int PRICE = 100;

        public BigSize()
        {
            InitialSetting(TYPE, PRICE);
        }
    }
}