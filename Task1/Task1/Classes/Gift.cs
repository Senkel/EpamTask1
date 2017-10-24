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
        public Gift(string name,ICollection<ISweet> items)
        {
            Name = name;
            Items = items;
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

        public void AddSweet(ISweet s)
        {
            Items.Add(s);
        }

        public void RemoveSweet(ISweet s)
        {
            Items.Remove(s);
        }
        
        public double GetGiftPrice()
        {
            return Items.Sum(x=>x.GetSweetPrice());
        }

        public double GetWeight()
        {
            return Items.Sum(x => x.Weight);
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
}
