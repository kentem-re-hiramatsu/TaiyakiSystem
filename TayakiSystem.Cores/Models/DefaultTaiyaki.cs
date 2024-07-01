﻿using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DefaultTaiyaki : BaseTaiyaki
    {
        public DefaultTaiyaki(TaiyakiSizeEnum size)
        {
            Name = TaiyakiEnum.通常たい焼き;
            Content = TaiyakiContentEnum.あんこ;
            Size = size;
        }

        public DefaultTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size) => new DefaultTaiyaki(size);

        public override int GetSubTotal() => (int)Name + (int)Size;
    }
}