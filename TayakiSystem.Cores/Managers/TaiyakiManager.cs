using System;
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

        public void Add(BaseTaiyaki taiyaki)
        {
            _taiyakiOrderList.Add(taiyaki);
        }

        public BaseTaiyaki GetTaiyakiOrder(int index)
        {
            return _taiyakiOrderList[index];
        }

        public int GetTotalPrice()
        {
            return _taiyakiOrderList.Sum(x => x.GetSubTotal());
        }

        public void ChangeOrder(int index, TaiyakiSizeEnum size)
        {
            if (_taiyakiOrderList[index].Name != TaiyakiEnum.デラックスたい焼き || (_taiyakiOrderList[index].Name == TaiyakiEnum.デラックスたい焼き && size == TaiyakiSizeEnum.大))
                _taiyakiOrderList[index].Size = size;
            else
                throw new Exception(Consts.BIG_SIZE_ONLY_ERROR_MESSAGE);
        }
        public void Remove(int index)
        {
            _taiyakiOrderList.RemoveAt(index);
        }
    }
}