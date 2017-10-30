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

        public double SweetPrice { get; protected set; }

        public Caramel(string name, double weight, double sugar, double calories,double sweetprice)
        {
            SweetPrice = sweetprice;
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Calories = calories;
        }

        public virtual double GetSweetPrice()
        {
            return SweetPrice * Weight;
        }
    }
}
