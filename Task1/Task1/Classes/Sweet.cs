using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Sweet: ISweet
    {
        private const double SWEET_PRICE = 0.005;

        public string Name
        {
            get;
            protected set;
        }

        public double Weight
        {
            get;
            protected set;
        }


        public double Sugar
        {
            get;
            protected set;
        }


        public double Calories
        {
            get;
            protected set;
        }




        public Sweet(string name, double weight, double sugar,double calories)
        {
            name = Name;
            weight = Weight;
            sugar = Sugar;
            calories = Calories;
        }

        public virtual double  GetSweetPrice()
        {
            return SWEET_PRICE * Weight;
        }
    }
}
