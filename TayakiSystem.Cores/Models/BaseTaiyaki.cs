using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiEnum Name { get; protected set; }
        public TaiyakiSizeEnum Size { get; set; }
        public TaiyakiContentEnum Content { get; protected set; }

        public abstract BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size);

        public abstract int GetSubTotal();
    }
}