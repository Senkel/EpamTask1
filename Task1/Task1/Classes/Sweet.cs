using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Sweet: ISweet
    {
        private const double SWEET_PRICE = 5.0;

        public string Name => throw new NotImplementedException();

        public double Weight => throw new NotImplementedException();

        public double Sugar => throw new NotImplementedException();

        public double Calories => throw new NotImplementedException();

       

        public Sweet(string name, double weight, double sugar,double calories)
        {
            name = Name;
            weight = Weight;
            sugar = Sugar;
            calories = Calories;
        }

        public virtual double  GetSweetPrice()
        {
            return SWEET_PRICE / 1000 * Weight;
        }
    }
}
