using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiType Name { get; protected set; }
        public int TaiyakiPrice { get; protected set; }
        public Size Size { get; set; }
        public string Content { get; protected set; }

        public BaseTaiyaki(Size size)
        {
            Size = size;
        }

        protected void InitialSetting(TaiyakiType name, int price, string content)
        {
            Name = name;
            TaiyakiPrice = price;
            Content = content;
        }

        public abstract int GetPrice();
    }
}