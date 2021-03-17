using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Duck : IFly,ISwim // множинне
    {
        const ushort MaxHeight = 200;
        ushort height;
        public ushort Height
        {
            get => height;
            set => height = value > MaxHeight ? MaxHeight : value;
        }
        public void Fly()
        {
            Console.WriteLine($"Duck is flying {Height}");
        }
        // dont can public
        public void Move() 
        {
            Console.WriteLine("Duck is moving...");

        }
        void ISwim.Move()
        {
            Console.WriteLine("Duck is swimming!");
        }
    }
}
