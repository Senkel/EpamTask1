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
        public Gift(string name, ICollection<ISweet> items)
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

        public IEnumerable<ISweet> FindSweetBySugar(int min, int max)
        {
            return Items.Where(x => x.Sugar >= min && x.Sugar <= max).OrderBy(x => x.Sugar);


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
            return Items.Sum(x => x.GetSweetPrice());
        }

        public double GetWeight()
        {
            return Items.Sum(x => x.Weight);
        }
        
        public IEnumerable<ISweet> SortByWeight()
        {
            return Items.OrderBy(x => x.Weight);

        }


    }
}
