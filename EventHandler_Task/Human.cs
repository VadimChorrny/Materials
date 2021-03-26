using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_Task
{
    class Human
    {
        public string Name { get; set; }

        public void Feed(Animal animal)
        {
            if(animal.CurrentEnergy < animal.MaxHitPoint
                && animal.CurrentEnergy > animal.MinHitPoint)
            {
                animal.CurrentEnergy += 10;
            }
            else
            {
                Console.WriteLine($"Pig is sleeping...!");
            }
        }
        public void Handler(object sender, EventArgs e) // covariance of delegate
        {
            Animal animal = sender as Animal;
            //animal.CurrentEnergy += 10;
            Feed(animal);
            Console.WriteLine();
        }
    }
}
