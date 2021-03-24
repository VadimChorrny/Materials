using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooler cooler = new Cooler();
            Heather heather = new Heather();
            HotHouse hotHouse = new HotHouse
            { CurrentTemperature = 15};
            hotHouse.TooHot += heather.Warm;
            hotHouse.TooCold += cooler.Cold;
            //Console.WriteLine(hotHouse);
            for (int i = 0; i < 5; i++)
            {
                int tmp = new Random().Next(-2,2);
                hotHouse.CurrentTemperature += tmp;
            }



        }
    }
}
