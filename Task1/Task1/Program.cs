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
            Sweet sweet = new Sweet("Alenka", 110, 51, 520);//100 g
            SweetWithFilling sweetwf = new SweetWithFilling("Grilling", 98, 56, 540, TypeSweetFilling.Nut);
            Caramel caramel = new Caramel("Chupa-Chups",120,55,440);
            CaramelWithFilling caramelwf = new CaramelWithFilling("Korovka",140,59,490,TypeCaramelFilling.Strawberry);

            Gift gift = new Gift();

            gift.Add(sweet);
            gift.Add(sweetwf);
            gift.Add(caramel);
            gift.Add(caramelwf);
            gift.Remove(sweet);
            gift.Add(sweet);

            Console.Write("Gift price is (rubles) :");
            gift.GetGiftPrice();
            Console.WriteLine("______________________________________");
            Console.Write("Total weight of gift is (gramm) : ");
            gift.GetWeight(); 
            Console.WriteLine("______________________________________");
            Console.WriteLine("Sort by weight: ");
            gift.SortByWeight();
            Console.WriteLine("______________________________________");
            Console.WriteLine("Find sweet by sugar: ");
            gift.FindSweetBySugar(52, 57);
            
            
            
            Console.ReadLine();
        }
    }
}//final commit
