using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Truffle : ISweet, ISweetFilling
    {
        private const double TRUFFLE_PRICE = 0.0075;

        public Truffle(string name, double weight, double sugar, double calories, string filling, double fillingPrice)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Calories = calories;
            Filling = filling;
            FillingPrice = fillingPrice;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public double Sugar { get; protected set; }

        public double Calories { get; protected set; }

        public string Filling  {get;protected set;}

        public double FillingPrice { get; protected set; }

        public double GetSweetPrice()
        {
            return (TRUFFLE_PRICE  * Weight)+FillingPrice;
        }
    }
}
