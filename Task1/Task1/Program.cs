using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet sweet = new Sweet("Alenka", 100, 51, 520);//100 g
            SweetWithFilling sweetwf = new SweetWithFilling("", 100, 56, 540, TypeSweetFilling.Nut);
        }
    }
}
