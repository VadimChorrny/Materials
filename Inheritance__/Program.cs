using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__
{
    class Program
    {
        class Car : Wehicle
        {
            public void Print()
            {
                Console.WriteLine($"Car with speed {Speed} {Upgrade}");

            }
        }
        static void Main(string[] args)
        {
            Wehicle wehicle = new Wehicle() { Year = 2001,Speed = 214 };

        }
    }
}
