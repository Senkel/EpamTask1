using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;
using Task1.Interfaces;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet sweet = new Sweet("Alenka", 110, 51, 520);
            SweetWithFilling sweetwf = new SweetWithFilling("Grilling", 98, 56, 540,"Nut",0.001);
            Caramel caramel = new Caramel("Chupa-Chups",120,55,440);
            CaramelWithFilling caramelwf = new CaramelWithFilling("Korovka",140,59,490,"Milk",0.0005);
            ChocolateBar chocolateBar = new ChocolateBar("Spartak",150,66,550);
            Truffle truffle = new Truffle("Golden night",100,54,500,"Nut",0.001);


            Gift gift = new Gift("Christmas Gift",new List<ISweet>());

            gift.AddSweet(sweet);
            gift.AddSweet(sweetwf);
            gift.AddSweet(caramel);
            gift.AddSweet(truffle);
            gift.AddSweet(chocolateBar);
            gift.AddSweet(caramelwf);
            gift.RemoveSweet(sweet);
            gift.AddSweet(sweet);

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
}
