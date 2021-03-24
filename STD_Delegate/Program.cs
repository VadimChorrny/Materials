using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_Delegate
{
    delegate void MyDeleg<T>(T one, T two);
    class Persone
    {
        public string Name { get; set; } = "NoName!";
        public int Age { get; set; } = 18;
    }
    class Program
    {

        static void Add(double a, double b)
        {
            Console.WriteLine($"{ a + b}");
        }
        static void Concat(string a, string b)
        {
            Console.WriteLine($"{ a + " " + b}");
        }
        static void Test()
        {
            Console.WriteLine("Test");
        }
        static void Main(string[] args)
        {
            MyDeleg<double> del1 = Add;
            del1(2, 4);
            MyDeleg<string> del2 = Concat;
            del2("Hello", "Vlados - Kross!");
            MyDeleg<char> del3 = (char a, char b) => Console.WriteLine($"{a} and {b} : {Char.ToUpper(a)} and {Char.ToUpper(b)}");
            del3('a', 'b');
            //Action action = Test;
            //action?.Invoke();
            //action += ()=> Console.WriteLine("Lambda");
            //action();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Action<int, string> action2 = (number, str) => Console.WriteLine($"{number} == {str.Length} : {number == str.Length} ");
            action2(5, "Hello");

            Func<int, DateTime, string> func = (number, date) => $"New Date : {date.AddDays(number): dd-MMM-yyyy}";
            string resurlt = func(5, DateTime.Today);
            Console.WriteLine(resurlt);
            int value = new Random().Next(100);
            Predicate<int> predicate = (number) => number % 2 == 0;
            Console.WriteLine($"{value} : {predicate(value)}");

            Comparison<Persone> cmpAge = (e, e2) => e.Age.CompareTo(e2.Age);
            Persone[] persones =
            {
                new Persone(),
                new Persone {Name = "Vadim",Age = 17},
                new Persone {Name = "Alina",Age = 13}
            };
            Array.Sort(persones,cmpAge);
            foreach (var item in persones)
            {
                Console.WriteLine(item);
            }













        }
    }
}
