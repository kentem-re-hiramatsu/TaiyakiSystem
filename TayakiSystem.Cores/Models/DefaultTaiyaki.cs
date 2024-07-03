using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DefaultTaiyaki : BaseTaiyaki
    {
        private const string NAME = "通常たい焼き";
        private const int PRICE = 100;
        private const string CONTENT = "あんこ";

        public DefaultTaiyaki(TaiyakiSizeType size) : base(size)
        {
            InitialSetting(NAME, PRICE, CONTENT);
        }

        public override int GetPrice() => TaiyakiPrice + (int)Size;
    }
}