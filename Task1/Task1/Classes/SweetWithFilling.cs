using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    class SweetWithFilling : Sweet
    {
        TypeSweetFilling Type;
        public SweetWithFilling(string name, int weight, int sugar, double calories,TypeSweetFilling type) : base(name, weight, sugar, calories)
        {
            Type = type;
        }
    }
}
