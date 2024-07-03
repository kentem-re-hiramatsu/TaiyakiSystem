using System;
using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public class DeluxeTaiyaki : BaseTaiyaki
    {
        private const TaiyakiType NAME = TaiyakiType.デラックスたい焼き;
        private const int PRICE = 300;
        private const string CONTENT = "生クリームとカスタード";

        public DeluxeTaiyaki(Size size) : base(size)
        {
            SizeCheck(size);
        }

        public override void SetSize(Size size)
        {
            SizeCheck(size);
        }

        /// <summary>
        /// サイズのチェック
        /// </summary>
        private void SizeCheck(Size size)
        {
            //サイズが大以外はエラーを返す
            if (size.Type == TaiyakiSizeType.大)
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