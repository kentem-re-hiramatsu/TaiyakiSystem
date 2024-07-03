using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiType Name { get; protected set; }
        public int TaiyakiPrice { get; protected set; }
        public Size Size { get; protected set; }
        /// <summary>
        /// たい焼きの中身
        /// </summary>
        public string Content { get; protected set; }

        public BaseTaiyaki(Size size)
        {
            Size = size;
        }

        /// <summary>
        /// 初期設定
        /// </summary>
        protected void InitialSetting(TaiyakiType name, int price, string content)
        {
            Name = name;
            TaiyakiPrice = price;
            Content = content;
        }

        public abstract void SetSize(Size size);

        public abstract int GetPrice();
    }
}