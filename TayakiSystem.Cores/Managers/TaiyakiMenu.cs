using System.Collections.Generic;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Managers
{
    public class TaiyakiMenu
    {
        private List<BaseTaiyaki> _taiyakiMenuList = new List<BaseTaiyaki>
        {
            new DefaultTaiyaki(),
            new CustardTaiyaki(),
            new DeluxeTaiyaki()
        };

        public BaseTaiyaki GetTaiyaki(int index, TaiyakiSizeEnum size) => _taiyakiMenuList[index].GetCloneTaiyaki(size);
    }
}