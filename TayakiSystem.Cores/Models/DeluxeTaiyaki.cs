using System;
using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DeluxeTaiyaki : BaseTaiyaki
    {
        public TaiyakiContentEnum AddingContent { get; }

        public DeluxeTaiyaki(TaiyakiSizeEnum size)
        {
            if (TaiyakiSizeEnum.大 == size)
            {
                Name = TaiyakiEnum.デラックスたい焼き;
                Content = TaiyakiContentEnum.カスタード;
                AddingContent = TaiyakiContentEnum.生クリーム;
                Size = size;
            }
            else
            {
                throw new Exception(Consts.BIG_SIZE_ONLY_ERROR_MESSAGE);
            }
        }

        public DeluxeTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size)
        {
            return new DeluxeTaiyaki(size);
        }

        public override int GetSubTotal()
        {
            return (int)Name;
        }
    }
}