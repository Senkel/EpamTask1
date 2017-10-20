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

        public ICollection<ISweet> FindSweetBySugar(int min, int max)
        {
            if (Items != null)
            {
                return Items.Where(x => (x.Sugar >= min) && (x.Sugar <= max)).ToList();

            }
            else
            {
                throw new InvalidOperationException("Something went wrong");
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
        public Gift()
        {
            Items = new List<ISweet>();
        }
        public double GetGiftPrice()
        {
            if (Items != null)
            {
                return Items.Sum(x => x.GetSweetPrice());
            }else
            {
                throw new InvalidOperationException("Something went wrong");
            }
        }

        public double GetWeight()
        {
            if (Items != null)
            {
                return Items.Sum(x => x.Weight);
            }else
            {
                throw new InvalidOperationException("Something went wrong");
            }
        }

        public void SortByWeight()
        {
            var temp = Items.OrderBy(x => x.Weight).ToList();
            Items.Clear();
            foreach (var item in temp)
            {
                Items.Add(item);
            }
        }
    }
}
