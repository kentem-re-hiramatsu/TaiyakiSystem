using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class CustardTaiyaki : BaseTaiyaki
    {
        public CustardTaiyaki(TaiyakiSizeEnum size) : base(size)
        {
            Name = TaiyakiEnum.カスタードたい焼き;
            Content = TaiyakiContentEnum.カスタード;
            Size = size;
        }
    }
}