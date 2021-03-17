using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance__;

namespace Use_Vehicle
{
    class Car : Wehicle
    {
        public void Print()
        {
            Console.WriteLine($"Car with speed {Speed}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wehicle wehicle = new Wehicle {Brand = "ADIDAS" };

        }
    }
}
