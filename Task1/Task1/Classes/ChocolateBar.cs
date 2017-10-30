using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class ChocolateBar : Sweet,ISweet
    {
        public ChocolateBar(string name, double weight, double sugar, double calories, double sweetprice) : base(name, weight, sugar, calories, sweetprice)
        {
        }


        
    }
}
