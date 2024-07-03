using System;
using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DeluxeTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.デラックスたい焼き;
        private const int PRICE = 300;
        private const string CONTENT = "生クリームとカスタード";

        public DeluxeTaiyaki(TaiyakiSizeType size)
        {
            if (TaiyakiSizeType.大 == size)
            {
                Name = NAME;
                TaiyakiPrice = PRICE;
                Content = CONTENT;
                Size = size;
                SizePrice = GetSizePrice(size);
            }
            else
            {
                throw new Exception(Consts.BIG_SIZE_ONLY_ERROR_MESSAGE);
            }
        }

        public DeluxeTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeType size) => new DeluxeTaiyaki(size);

        public override int GetSubTotal() => TaiyakiPrice;
    }
}