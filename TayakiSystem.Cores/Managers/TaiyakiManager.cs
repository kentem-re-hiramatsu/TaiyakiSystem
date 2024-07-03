using System.Collections.Generic;
using System.Linq;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Managers
{
    public class TaiyakiManager
    {
        private List<BaseTaiyaki> _taiyakiOrderList = new List<BaseTaiyaki>();
        public IReadOnlyCollection<BaseTaiyaki> TaiyakiOrderList { get { return _taiyakiOrderList; } }

        public void Add(BaseTaiyaki taiyaki) => _taiyakiOrderList.Add(taiyaki);

        public BaseTaiyaki GetTaiyakiOrder(int index) => _taiyakiOrderList[index];

        /// <summary>
        /// 注文合計金額の返す
        /// </summary>
        public int GetTotalPrice() => _taiyakiOrderList.Sum(x => x.GetPrice());

        /// <summary>
        ///注文されたたい焼きのサイズを変更
        /// </summary>
        public void ChangeOrder(int index, Size size)
        {
            _taiyakiOrderList[index].SetSize(size);
        }
        public void Remove(int index) => _taiyakiOrderList.RemoveAt(index);

        /// <summary>
        /// たい焼きのインスタンスを返す
        /// </summary>
        public BaseTaiyaki GetTaiyaki(TaiyakiType taiyaki, Size size)
        {
            switch (taiyaki)
            {
                case TaiyakiType.通常たい焼き:
                    return new DefaultTaiyaki(size);
                case TaiyakiType.カスタードたい焼き:
                    return new CustardTaiyaki(size);
                case TaiyakiType.デラックスたい焼き:
                    return new DeluxeTaiyaki(size);
            }
            return null;
        }

        /// <summary>
        /// サイズのインスタンスを返す
        /// </summary>
        public Size GetSize(TaiyakiSizeType size)
        {
            switch (size)
            {
                case TaiyakiSizeType.大:
                    return new BigSize();
                case TaiyakiSizeType.中:
                    return new MiddleSize();
                case TaiyakiSizeType.小:
                    return new SmallSize();
            }
            return null;
        }
    }
}