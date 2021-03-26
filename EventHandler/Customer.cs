using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers_
{
    class Customer
    {
        public string Name { get; set; }
        public void Handler(object sender, ProductArgs e) // covariance of delegate
        {
            Product product = sender as Product;
            if (product != null)
            {
                Console.WriteLine($"Customer {Name} has notified about price changing of {product.Name}\nOld price {e.OldPrice}\nNew price {product.Price}");
            }
        }
    }
}
