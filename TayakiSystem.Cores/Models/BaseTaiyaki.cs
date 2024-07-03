using TaiyakiSystem.Cores.Enums;
using TayakiSystem.Cores.Models;

namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiType Name { get; protected set; }
        public int TaiyakiPrice { get; protected set; }
        public Size Size { get; set; }
        public string Content { get; protected set; }

        public abstract int GetSubTotal();
    }
}