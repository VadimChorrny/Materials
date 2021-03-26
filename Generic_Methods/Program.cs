using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods
{
    class Persone
    {
        public string Name { get; set; }
        public Persone(string name)
        {
            Name = name;
        }

        public Persone()
        {
        }

        public override string ToString()
        {
            return $"Name { Name }";
        }
        public virtual void Busy()
        {
            Console.WriteLine($"{Name} is busy!");
        }
    }
    class Worker : Persone
    {
        public string Position { get; set; }
        public Worker(string name, string pos)
            : base(name)
        {
            Position = pos;
        }
        public override void Busy()
        {
            Console.WriteLine($"Worker {Name} is working in position {Position}");
        }
        public override string ToString()
        {
            return $"Worker {Name},\n Position {Position}";
        }
    }
    class People<T> where T : Persone
    {
        public List<T> people = new List<T>(); 
        public void BusyAll()
        {
            foreach (var item in people)
            {
                item.Busy();
            }
        }
    }
    class Program
    {
        static T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        static bool IsExistInEnum<T>(T value) where T : Enum // check home
        {
            return Enum.IsDefined(typeof(T), value);
        }
        static void Main(string[] args)
        {
            int value = 10;
            Console.WriteLine($"Is exists {value} : {IsExistInEnum<ConsoleColor>((ConsoleColor)value)}");
            //int one = 10, two = 20;
            //Console.WriteLine($"Max : {Max(one, two)}");
            var p = new Persone("Katya");
            Worker w = new Worker("Katya", "Freelance at house!");
            Console.WriteLine(w);
            Console.WriteLine(p);
            People<Persone> peoples = new People<Persone>();
            peoples.people.Add(p);
            peoples.people.Add(w);

        }

    }
}
