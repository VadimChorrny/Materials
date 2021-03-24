using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonachi fibonachi = new Fibonachi();
            fibonachi.First = 2;
            fibonachi.Second = 3;
            foreach (var item in fibonachi)
            {
                Console.WriteLine(item);
            }

        }
    }
}
