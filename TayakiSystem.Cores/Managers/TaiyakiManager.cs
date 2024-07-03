using System.Collections.Generic;
using System.Linq;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Managers
{
    public class TaiyakiManager
    {
        private List<BaseTaiyaki> _taiyakiOrderList = new List<BaseTaiyaki>();
        public IReadOnlyCollection<BaseTaiyaki> TaiyakiOrderList { get { return _taiyakiOrderList; } }

        public void Add(BaseTaiyaki taiyaki) => _taiyakiOrderList.Add(taiyaki);

        public BaseTaiyaki GetTaiyakiOrder(int index) => _taiyakiOrderList[index];

        public int GetTotalPrice() => _taiyakiOrderList.Sum(x => x.GetSubTotal());

        public void ChangeOrder(int index, TaiyakiSizeType size)
        {
            _taiyakiOrderList[index].Size = size;
        }
        public void Remove(int index) => _taiyakiOrderList.RemoveAt(index);

        public BaseTaiyaki GetTaiyaki(TaiyakiType taiyaki, TaiyakiSizeType size)
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
    }
}