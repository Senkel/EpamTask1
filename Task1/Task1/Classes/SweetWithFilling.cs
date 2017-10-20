using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    class SweetWithFilling : Sweet
    {
        private const double SWEETWITHFILLING_PRICE = 0.0055;

        TypeSweetFilling Type;

        public override double GetSweetPrice()
        {
            return SWEETWITHFILLING_PRICE * Weight;
        }
        public SweetWithFilling(string name, double weight, double sugar, double calories,TypeSweetFilling type) : base(name, weight, sugar, calories)
        {
            Type = type;
        }
    }
}
