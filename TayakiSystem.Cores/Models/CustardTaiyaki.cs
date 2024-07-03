using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public class CustardTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.カスタードたい焼き;
        private const int PRICE = 150;
        private const string CONTENT = "カスタード";

        public CustardTaiyaki(Size size)
        {
            Name = NAME;
            TaiyakiPrice = PRICE;
            Content = CONTENT;
            Size = size;
        }

        public override int GetSubTotal() => TaiyakiPrice + Size.Price;
    }
}