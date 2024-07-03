using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class CustardTaiyaki : BaseTaiyaki
    {
        private const string NAME = "カスタードたい焼き";
        private const int PRICE = 150;
        private const string CONTENT = "カスタード";

        public CustardTaiyaki(TaiyakiSizeEnum size)
        {
            Name = NAME;
            TaiyakiPrice = PRICE;
            Content = CONTENT;
            Size = size;
            SizePrice = GetSizePrice(size);
        }

        public CustardTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size) => new CustardTaiyaki(size);

        public override int GetSubTotal() => TaiyakiPrice + SizePrice;
    }
}