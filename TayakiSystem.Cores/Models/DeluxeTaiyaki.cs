using System;
using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public class DeluxeTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.デラックスたい焼き;
        private const int PRICE = 300;
        private const string CONTENT = "生クリームとカスタード";

        public DeluxeTaiyaki(Size size)
        {
            if (TaiyakiSizeType.大 == size.Type)
            {
                Name = NAME;
                TaiyakiPrice = PRICE;
                Content = CONTENT;
                Size = size;
            }
            else
            {
                throw new Exception(Consts.BIG_SIZE_ONLY_ERROR_MESSAGE);
            }
        }

        public override int GetSubTotal() => TaiyakiPrice;
    }
}