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
        IEnumerable<ISweet> FindSweetBySugar(int min, int max);
        string Name { get; }
        double GetWeight();
        IEnumerable<ISweet> SortByWeight();
        double GetGiftPrice();
    }
}
