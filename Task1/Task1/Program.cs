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
            SweetWithFilling sweetwf = new SweetWithFilling("Grilling", 100, 56, 540, TypeSweetFilling.Nut);
            Caramel caramel = new Caramel("Chupa-Chups",100,55,440);
            CaramelWithFilling caramelwf = new CaramelWithFilling("Korovka",100,59,490,TypeCaramelFilling.Strawberry);

            Gift gift = new Gift();

            gift.Add(sweet);
            gift.Add(sweetwf);
            gift.Add(caramel);
            gift.Add(caramelwf);

            gift.ShowPrice();
            gift.FindSweetBySugar(52,57);
            gift.GetWeight();
            gift.SortByWeight();

            Console.ReadLine();
        }
    }
}
