using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class CaramelWithFilling : Caramel, ISweetFilling
    {

        public string Filling { get; protected set; }

        public double FillingPrice { get; protected set; }

        public override double GetSweetPrice()
        {
            return (SweetPrice * Weight) + FillingPrice;

        }
        public CaramelWithFilling(string name, double weight, double sugar, double calories, string filling, double fillingPrice,double sweetprice) : base(name, weight, sugar, calories,sweetprice)
        {
           
            Filling = filling;
            FillingPrice = fillingPrice;
        }
    }
}