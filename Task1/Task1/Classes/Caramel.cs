using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Caramel : ISweet
    {
        private const double CARAMEL_PRICE = 0.004;

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

        public Caramel(string name , double weight , double sugar, double calories)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Calories = calories;
        }

        public virtual double GetSweetPrice()
        {
            return CARAMEL_PRICE  * Weight;
        }
    }
}//final commit
