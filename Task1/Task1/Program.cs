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
            Sweet sweet = new Sweet("Alenka", 450, 51, 520);
            SweetWithFilling sweetwf = new SweetWithFilling("Grilling", 500, 56, 540,"Nut",0.01);
            Caramel caramel = new Caramel("Chupa-Chups",440,55,440);
            CaramelWithFilling caramelwf = new CaramelWithFilling("Korovka",510,59,490,"Milk",0.05);
            ChocolateBar chocolateBar = new ChocolateBar("Spartak",550,66,550);
            Truffle truffle = new Truffle("Golden night",350,54,500,"Nut",0.01);


            Gift gift = new Gift("Christmas Gift",new List<ISweet>());

            gift.AddSweet(sweet);
            gift.AddSweet(sweetwf);
            gift.AddSweet(caramel);
            gift.AddSweet(truffle);
            gift.AddSweet(chocolateBar);
            gift.AddSweet(caramelwf);
            gift.RemoveSweet(sweet);
            gift.AddSweet(sweet);

            
            Console.WriteLine("Gift price is (rubles): {0,13}",gift.GetGiftPrice());
            Console.WriteLine("______________________________________");
            
            Console.WriteLine("Total weight of gift is (gramm): {0} ",gift.GetWeight()); 
            Console.WriteLine("______________________________________");

            Console.WriteLine("Sort by weight:");
            foreach (var i in gift.SortByWeight())
            {
                Console.WriteLine("{0,20} \t {1,10}", i.Name,i.Weight);
            }
            Console.WriteLine("______________________________________");
            Console.WriteLine("Find sweet by sugar: ");
            
            foreach (var i in gift.FindSweetBySugar(52, 57))
            {
                Console.WriteLine("{0,25} \t {1,2}",i.Name ,i.Sugar);
            }

            gift.SortByWeight().Add(new Sweet("", 1, 1, 1));

            Console.ReadLine();
        }
    }
}
