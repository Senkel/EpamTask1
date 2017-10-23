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
        private const double TRUFFLE_PRICE = 0.0075;

        public string Name => throw new NotImplementedException();

        public double Weight => throw new NotImplementedException();

        public double Sugar => throw new NotImplementedException();

        public double Calories => throw new NotImplementedException();

        public double GetSweetPrice()
        {
            return TRUFFLE_PRICE  * Weight;
        }
    }
}//final commit
