using System.Collections.Generic;

namespace TaiyakiSystem.Cores.Models
{
    public class TaiyakiMenu
    {
        private List<BaseTaiyaki> _taiyakiMenuList = new List<BaseTaiyaki>();

        public IReadOnlyCollection<BaseTaiyaki> TaiyakiMenuList { get { return _taiyakiMenuList; } }

        public BaseTaiyaki GetTaiyaki(int index)
        {
            return _taiyakiMenuList[index];
        }
    }
}
