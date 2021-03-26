using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product() { Name = "Black", Price = 18, Count = 1 };
            Console.WriteLine(bread);
            Customer vasya = new Customer { Name = "Vasil" };
            bread.PriceChanged += vasya.Handler;
            bread.Price = 178;
            
        }
    }
}
