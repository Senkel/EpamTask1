using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class CaramelWithFilling : Caramel,ISweetFilling
    {

        private const double CARAMELWITHFILLING_PRICE = 0.045;

        public string Filling { get; protected set; }

        public double FillingPrice { get; protected set; }

        public override double GetSweetPrice()
        {
            return (CARAMELWITHFILLING_PRICE * Weight)+FillingPrice;

        }
        public CaramelWithFilling(string name, double weight, double sugar, double calories, string filling,double fillingPrice ) : base(name, weight, sugar, calories)
        {
            Filling = filling;
            FillingPrice = fillingPrice;
        }
    }
}