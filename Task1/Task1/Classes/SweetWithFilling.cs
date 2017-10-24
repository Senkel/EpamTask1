using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class SweetWithFilling : Sweet,ISweetFilling
    {
        private const double SWEETWITHFILLING_PRICE = 0.0055;
        
        public string Filling { get; protected set; }

        public double FillingPrice { get; protected set; }

        public override double GetSweetPrice()
        {
            return (SWEETWITHFILLING_PRICE * Weight)+FillingPrice;
        }
        public SweetWithFilling(string name, double weight, double sugar, double calories, string filling,double fillingPrice) : base(name, weight, sugar, calories)
        {
            Filling = filling;
            FillingPrice = fillingPrice;
        }
    }
}
