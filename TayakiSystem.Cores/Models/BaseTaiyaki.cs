using TaiyakiSystem.Cores.Enums;
namespace TaiyakiSystem.Cores.Models
{
    public abstract class BaseTaiyaki
    {
        public TaiyakiEnum Name { get; set; }
        public TaiyakiSizeEnum Size { get; set; }
        public TaiyakiContentEnum Content { get; set; }

        public BaseTaiyaki(TaiyakiSizeEnum size)
        {
            Size = size;
        }

        public virtual int GetSubTotal()
        {
            return (int)Name + (int)Size;
        }
    }
}