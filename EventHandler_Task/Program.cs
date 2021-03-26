using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal { NamePet = "Pig - Vlad", CurrentEnergy = 60 };
            Console.WriteLine(animal);
            Human human = new Human { Name = "Vadim" };
            animal.Run();

        }
    }
}
