using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Classes
{
    class Gift : IGift
    {
        public Gift()
        {
            Items = new List<ISweet>();
        }

        public ICollection<ISweet> Items
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public void FindSweetBySugar(int min, int max)
        {
            var search = from item in Items
                         orderby item.Sugar
                         where item.Sugar >= min
                         where item.Sugar <= max
                         select item;
            foreach (var i in search)
            {
                Console.WriteLine((i.Name + "\t" + i.Sugar).ToString());
            }
            
        }

        public void Add(ISweet s)
        {
            Items.Add(s);
        }

        public void Remove(ISweet s)
        {
            Items.Remove(s);
        }
        
        public double GetGiftPrice()
        {
            double TotalPrice = 0;
            var search = from item in Items
                         select item;
            foreach (var i in search)
            {
                TotalPrice += i.GetSweetPrice();
            }
            Console.WriteLine(TotalPrice);
            return TotalPrice;
        }

        public double GetWeight()
        {
            double TotalWeight = 0;
            var search = from item in Items
                         select item;
            foreach (var i in search)
            {
                TotalWeight += i.Weight;
            }
            Console.WriteLine(TotalWeight);
            return TotalWeight;
        }
    

        public void SortByWeight()
        {
            var search = from item in Items
                         orderby item.Weight
                         select item;
            foreach (var i in search)
            {
                Console.WriteLine((i.Name + "\t" + i.Weight).ToString());
            }
           
        }
    }
}//final commit
