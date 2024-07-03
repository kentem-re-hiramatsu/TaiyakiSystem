using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiEnum Name { get; protected set; }
        public int TaiyakiPrice { get; protected set; }
        public TaiyakiSizeEnum Size { get; set; }
        public int SizePrice { get; protected set; }
        public string Content { get; protected set; }

        public abstract BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeEnum size);
        public abstract int GetSubTotal();
        public int GetSizePrice(TaiyakiSizeEnum size)
        {
            switch (size)
            {
                case TaiyakiSizeEnum.小:
                    return (int)TaiyakiSizeEnum.小;
                case TaiyakiSizeEnum.中:
                    return (int)TaiyakiSizeEnum.中;
                case TaiyakiSizeEnum.大:
                    return (int)TaiyakiSizeEnum.大;
            }
            return -1;
        }
    }
}