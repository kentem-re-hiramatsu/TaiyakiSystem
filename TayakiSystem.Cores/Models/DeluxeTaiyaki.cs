using System;
using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class DeluxeTaiyaki : BaseTaiyaki
    {
        private const string NAME = "デラックスたい焼き";
        private const int PRICE = 300;
        private const string CONTENT = "生クリームとカスタード";

        public DeluxeTaiyaki(TaiyakiSizeType size) : base(size)
        {
            //サイズが大以外はエラーを返す
            if (size == TaiyakiSizeType.大)
            {
                InitialSetting(NAME, PRICE, CONTENT);
            }
            else
            {
                throw new Exception(Consts.BIG_SIZE_ONLY_ERROR_MESSAGE);
            }
        }

        public override int GetPrice() => TaiyakiPrice;
    }
}