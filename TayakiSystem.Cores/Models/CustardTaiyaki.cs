using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class CustardTaiyaki : BaseTaiyaki
    {
        private const string NAME = "カスタードたい焼き";
        private const int PRICE = 150;
        private const string CONTENT = "カスタード";

        public CustardTaiyaki(TaiyakiSizeType size) : base(size)
        {
            InitialSetting(NAME, PRICE, CONTENT);
        }

        public override int GetPrice() => TaiyakiPrice + (int)Size;
    }
}