using TaiyakiSystem.Cores.Enums;

namespace TayakiSystem.Cores.Models
{
    public abstract class Size
    {
        public TaiyakiSizeType Type { get; set; }
        public int Price { get; protected set; }

        protected void InitialSetting(TaiyakiSizeType type, int price)
        {
            Type = type;
            Price = price;
        }
    }
}
