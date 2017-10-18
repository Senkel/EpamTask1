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
        int Weight { get; }
        int Sugar { get; }
        double Calories { get; }
    }
}
