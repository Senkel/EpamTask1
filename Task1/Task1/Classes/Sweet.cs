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
        public string Name => throw new NotImplementedException();

        public int Weight => throw new NotImplementedException();

        public int Sugar => throw new NotImplementedException();

        public double Calories => throw new NotImplementedException();

       

        public Sweet(string name, int weight,int sugar,double calories)
        {
            name = Name;
            weight = Weight;
            sugar = Sugar;
            calories = Calories;
        }
    }
}
