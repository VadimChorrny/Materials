using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void MDelegate(string message);
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void Bye(string name)
        {
            Console.WriteLine($"Bye {name}");
        }
        static void Main(string[] args)
        {
            MDelegate md = new MDelegate(Hello);
            md.Invoke("Vlad");
            md.Invoke("Vadim");

            md = null;
            md?.Invoke("T");

            md = Hello;
            md += Bye;
            md("Victor");

            md -= Bye;
            md("Andrey");
        }
    }
}
