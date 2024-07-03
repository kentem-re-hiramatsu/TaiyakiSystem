using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiType Name { get; protected set; }
        public int TaiyakiPrice { get; protected set; }
        public TaiyakiSizeType Size { get; set; }
        public int SizePrice { get; protected set; }
        public string Content { get; protected set; }

        public abstract BaseTaiyaki GetCloneTaiyaki(TaiyakiSizeType size);
        public abstract int GetSubTotal();
        public int GetSizePrice(TaiyakiSizeType size)
        {
            switch (size)
            {
                case TaiyakiSizeType.小:
                    return (int)TaiyakiSizeType.小;
                case TaiyakiSizeType.中:
                    return (int)TaiyakiSizeType.中;
                case TaiyakiSizeType.大:
                    return (int)TaiyakiSizeType.大;
            }
            return -1;
        }
    }
}