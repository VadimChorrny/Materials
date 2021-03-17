using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Virtual
{
    abstract class Transport
    {
        public string Brand { get; set; }
        public abstract void Move();
        public abstract byte Places { get; }
        public Transport(string brand = "Null")
        {
            Brand = brand;
        }
        public void Repair() // dont virtual
        {
            Console.WriteLine($"Repair {Brand}...");
        }
        public override string ToString()
        {
            return $"Brand {Brand}\n" +
                $"Places {Places}\n";
        }
    }
    /*sealed*/ class Car : Transport
    {
        public double Engine { get; set; }
        public Car(string brand ="null", double engine = 0.0)
            :base(brand)
        {
            Engine = engine;
        }

        public override void Move()
        {
            Console.WriteLine($"Car {Brand} is moving by road");
        }
        public override byte Places => 2; // simplify
        public override string ToString()
        {
            return base.ToString() + $"Power {Engine}";
        }
        public new void Repair() // if method dont virtual
        {
            base.Repair();
        }



    }
    class Lorry : Car
    {
        public override byte Places => 2;

    }
}

// seald - не можна успадковуватися!