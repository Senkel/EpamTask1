using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    class CaramelWithFilling : Caramel
    {

        private const double CARAMELWITHFILLING_PRICE = 0.0045;

        TypeCaramelFilling Type;

        public override double GetSweetPrice()
        {
            return CARAMELWITHFILLING_PRICE * Weight;

        }
        public CaramelWithFilling(string name, double weight, double sugar, double calories, TypeCaramelFilling type) : base(name, weight, sugar, calories)
        {
            Type = type;
        }
    }
}
