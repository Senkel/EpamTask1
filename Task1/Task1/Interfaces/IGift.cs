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
        void FindSweetBySugar(int min, int max);
        string Name { get; }
        double GetWeight();
        void SortByWeight();
        double GetGiftPrice();
    }
}//final commit
