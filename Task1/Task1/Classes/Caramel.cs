using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Caramel : ISweet
    {
        private const double CARAMEL_PRICE = 4.20;
        public string Name => throw new NotImplementedException();

        public int Weight => throw new NotImplementedException();

        public int Sugar => throw new NotImplementedException();

        public double Calories => throw new NotImplementedException();

        public Caramel(string name , int weight , int sugar, double calories)
        {
            name = Name;
            weight = Weight;
            sugar = Sugar;
            calories = Calories;
        }

        public virtual double GetSweetPrice()
        {
            return CARAMEL_PRICE / 1000 * Weight;
        }
    }
}
