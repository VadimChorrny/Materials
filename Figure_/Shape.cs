using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_
{
    abstract class Shape
    {
        public abstract double Square { get; }
        public virtual void Print() // make - new
        {
            Console.WriteLine(Square.GetType().Name); // square ?
        }
    }

    class Circle : Shape
    {
        public double radius { get; }
        public override double Square => Math.PI * radius * radius;
        public override void Print() => base.Print();



    }
    class Rectangle : Shape
    {
        public double Height { get; }
        public double Weight { get; }
        public override double Square => Height * Weight;
        public override void Print() => base.Print();
    }
}
