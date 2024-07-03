using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DefaultTaiyaki : BaseTaiyaki
    {
        private const TaiyakiEnum NAME = TaiyakiEnum.通常たい焼き;
        private const int PRICE = 100;
        private const string CONTENT = "あんこ";

        public DefaultTaiyaki(TaiyakiSizeEnum size)
        {
            Name = NAME;
            TaiyakiPrice = PRICE;
            Content = CONTENT;
            Size = size;
            SizePrice = GetSizePrice(size);
        }

        public DefaultTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size) => new DefaultTaiyaki(size);

        public override int GetSubTotal() => TaiyakiPrice + SizePrice;
    }
}