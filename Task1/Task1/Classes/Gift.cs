using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Gift : IGift
    {
        public ICollection<ISweet> Items => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public ICollection<ISweet> FindSweetBySugar(int min, int max)
        {
            throw new NotImplementedException();
        }

        public double GetGiftPrice()
        {
            throw new NotImplementedException();
        }

        public double GetWeight()
        {
            throw new NotImplementedException();
        }

        public void SortByWeight()
        {
            throw new NotImplementedException();
        }
    }
}
