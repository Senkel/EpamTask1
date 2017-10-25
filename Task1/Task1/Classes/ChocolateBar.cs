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
        private const double CHOCOLATEBAR_PRICE = 0.055;

        public ChocolateBar(string name,double weight,double sugar,double calories)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Calories = calories;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public double Sugar { get; protected set; }

        public double Calories { get; protected set; }

        public double GetSweetPrice()
        {
            return CHOCOLATEBAR_PRICE  * Weight;
        }
    }
}
