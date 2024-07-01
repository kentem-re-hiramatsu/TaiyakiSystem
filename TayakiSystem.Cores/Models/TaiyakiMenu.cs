using System.Collections.Generic;
using TaiyakiSystem.Cores.Enums;

namespace TaiyakiSystem.Cores.Models
{
    public class TaiyakiMenu
    {
        private List<BaseTaiyaki> _taiyakiMenuList = new List<BaseTaiyaki>
        {
            new DefaultTaiyaki(),
            new CustardTaiyaki(),
            new DeluxeTaiyaki()
        };

        public BaseTaiyaki GetTaiyaki(int index, TaiyakiSizeEnum size)
        {
            return _taiyakiMenuList[index].GetCloneTaiyaki(size);
        }
    }
}
