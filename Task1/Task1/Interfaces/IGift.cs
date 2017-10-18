using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    interface IGift
    {
        ICollection<ISweet> Items { get; }
        ICollection<ISweet> FindSweetStuffBySugar(int min, int max);
        string Name { get; }
        double GetWeight();
        void SortByWeight();
        double GetGiftPrice();
    }
}
