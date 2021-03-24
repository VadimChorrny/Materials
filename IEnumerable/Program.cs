using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello Vlados!";
            foreach (char item in str) // item = str.GetEnumerator
            {
                Console.Write(item + " "); // en.Current
            }
            // низькорiвневий foreach
            CharEnumerator en = str.GetEnumerator(); // попросили повернути перелiчувач для рядка
            while(en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
            en.Reset();
            Console.WriteLine("----");
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
        }
    }
}
