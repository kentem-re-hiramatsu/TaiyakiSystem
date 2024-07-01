using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class CustardTaiyaki : BaseTaiyaki
    {
        public CustardTaiyaki(TaiyakiSizeEnum size)
        {
            Name = TaiyakiEnum.カスタードたい焼き;
            Content = TaiyakiContentEnum.カスタード;
            Size = size;
        }

        public CustardTaiyaki() { }

        public override BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size)
        {
            return new CustardTaiyaki(size);
        }

        public override int GetSubTotal()
        {
            return (int)Name + (int)Size;
        }
    }
}