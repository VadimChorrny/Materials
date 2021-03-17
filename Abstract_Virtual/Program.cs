using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car(brand : "Ferrari",engine : 7.0);
            Console.WriteLine(car);
            car.Repair(); // transport repair
            Car car1 = car as Car;
            if(car1 != null)
            {
                car1.Engine++;
                Console.WriteLine(car1);
                car1.Repair();
            }
            List<Transport> transports = new List<Transport>()
            { 
                car,
                new Lorry()
            };
            Console.WriteLine("------TRANSPORT------");
            foreach (var item in transports)
            {
                Console.WriteLine(item);
            }
        }
    }
}
