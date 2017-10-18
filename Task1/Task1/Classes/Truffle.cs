using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Truffle : ISweet
    {
        private const double TRUFFLE_PRICE = 7.50;

        public string Name => throw new NotImplementedException();

        public int Weight => throw new NotImplementedException();

        public int Sugar => throw new NotImplementedException();

        public double Calories => throw new NotImplementedException();

        public double GetSweetPrice()
        {
            return TRUFFLE_PRICE / 1000 * Weight;
        }
    }
}
