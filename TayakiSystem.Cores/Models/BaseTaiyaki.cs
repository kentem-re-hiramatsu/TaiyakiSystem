using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public string Name { get; protected set; }
        public int TaiyakiPrice { get; protected set; }
        public TaiyakiSizeType Size { get; set; }
        /// <summary>
        /// たい焼きの中身
        /// </summary>
        public string Content { get; protected set; }

        public BaseTaiyaki(TaiyakiSizeType size)
        {
            Size = size;
        }

        /// <summary>
        /// 初期設定
        /// </summary>
        protected void InitialSetting(string name, int price, string content)
        {
            Name = name;
            TaiyakiPrice = price;
            Content = content;
        }

        public abstract int GetPrice();
    }
}