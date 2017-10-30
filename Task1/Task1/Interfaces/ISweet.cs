using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1.Interfaces
{
    interface ISweet
    {
        
        string Name { get; }
        double Weight { get; }
        double Sugar { get; }
        double Calories { get; }
        double GetSweetPrice();
        double SweetPrice { get; }
    }
}
