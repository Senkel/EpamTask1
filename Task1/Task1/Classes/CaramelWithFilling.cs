using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    class CaramelWithFilling : Caramel
    {

        private const double CARAMELWITHFILLING_PRICE = 4.50;

        TypeCaramelFilling Type;

        public override double GetSweetPrice()
        {
            return CARAMELWITHFILLING_PRICE / 1000 * Weight;

        }
        public CaramelWithFilling(string name, double weight, double sugar, double calories, TypeCaramelFilling type) : base(name, weight, sugar, calories)
        {
            type = Type;
        }
    }
}
