using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public class DefaultTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.通常たい焼き;
        private const int PRICE = 100;
        private const string CONTENT = "あんこ";

        public DefaultTaiyaki(Size size)
        {
            Name = NAME;
            TaiyakiPrice = PRICE;
            Content = CONTENT;
            Size = size;
        }

        public override int GetSubTotal() => TaiyakiPrice + Size.Price;
    }
}