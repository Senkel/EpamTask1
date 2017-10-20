using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class ChocolateBar : ISweet
    {
        private const double CHOCOLATEBAR_PRICE = 5.50;

        public string Name => throw new NotImplementedException();

        public double Weight => throw new NotImplementedException();

        public double Sugar => throw new NotImplementedException();

        public double Calories => throw new NotImplementedException();

        public double GetSweetPrice()
        {
            return CHOCOLATEBAR_PRICE / 1000 * Weight;
        }
    }
}
