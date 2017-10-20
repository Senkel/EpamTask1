using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1
{
     static class Calculate
    {
        public static void ShowPrice(this IGift gift)
        {
            double sum = gift.Items.Sum(x => x.GetSweetPrice());
            double y = sum;
            int z = (int)y;
            decimal b = Math.Round((((decimal)y - z) * 100000), 1);
           // Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Price of a gift is:");
            Console.WriteLine("{0} dollar(s)  {1} cent(s)", z, b);
        }
    }
}
