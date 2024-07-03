using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class CustardTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.カスタードたい焼き;
        private const int PRICE = 150;
        private const string CONTENT = "カスタード";

        public CustardTaiyaki(TaiyakiSizeType size)
        {
            Name = NAME;
            TaiyakiPrice = PRICE;
            Content = CONTENT;
            Size = size;
            SizePrice = GetSizePrice(size);
        }

        public CustardTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeType size) => new CustardTaiyaki(size);

        public override int GetSubTotal() => TaiyakiPrice + SizePrice;
    }
}