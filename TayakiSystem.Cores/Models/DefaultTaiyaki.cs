using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public class DefaultTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.通常たい焼き;
        private const int PRICE = 100;
        private const string CONTENT = "あんこ";

        public DefaultTaiyaki(Size size) : base(size)
        {
            InitialSetting(NAME, PRICE, CONTENT);
        }

        public override void SetSize(Size size) => Size = size;

        public override int GetPrice() => TaiyakiPrice + Size.Price;
    }
}