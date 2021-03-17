using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__
{
    public class Wehicle
    {
        public string Brand { get; set; }
        internal uint Year { get; set; } // only one project
        protected internal uint Speed { get; set; } // protected for other
        // internal для своих
        // protected для своего класса
        private protected string Upgrade { get; set; }


    }
    class Motcycle : Wehicle
    {
        public void Print()
        {
            Console.WriteLine($"{Upgrade}");
        }
    }
}
