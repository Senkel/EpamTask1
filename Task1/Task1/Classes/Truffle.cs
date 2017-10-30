using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Truffle :Sweet, ISweet, ISweetFilling
    {

        public Truffle(string name, double weight, double sugar, double calories, double sweetprice,string filling, double fillingPrice) : base(name, weight, sugar, calories, sweetprice)
        {
            Filling = filling;
            FillingPrice = fillingPrice;
        }

       

        public string Filling { get; protected set; }

        public double FillingPrice { get; protected set; }
        
    }
}
