using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DefaultTaiyaki : BaseTaiyaki
    {
        public DefaultTaiyaki(TaiyakiSizeEnum size) : base(size)
        {
            Name = TaiyakiEnum.通常たい焼き;
            Content = TaiyakiContentEnum.あんこ;
            Size = size;
        }
    }
}