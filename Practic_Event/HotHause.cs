using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Event
{
    delegate void HotHouseDeleg(HotHouse house);
    class HotHouse
    {
        public readonly int MinTemperature = 10;
        public readonly int MaxTemperature = 20;
        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public int CurrentTemperature
        {
            get => CurrentTemperature;
            set
            {
                //CurrentTemperature = value;
                if(value > MaxTemperature)
                {
                    Console.WriteLine("Current temperature more max-temperature!");
                    TooHot?.Invoke(this);
                }
                else if( value < MinTemperature)
                {
                    Console.WriteLine("Current temperature smoller min-temperature");
                    TooCold?.Invoke(this);
                }
                else
                {
                    
                    Console.WriteLine("Well!");
                }
            }

        }
    }
    class Heather
    {
        public void Warm(HotHouse hotHouse)
        {
            if (hotHouse.CurrentTemperature != hotHouse.MaxTemperature // comment
                && hotHouse.CurrentTemperature != hotHouse.MinTemperature)
            {
                hotHouse.CurrentTemperature += 5;
                Console.WriteLine($"Heather added 5 degrees !");
            }
            else
            {
                throw new Exception("Error with Min Max temperature!");
            }

        }
    }
    class Cooler
    {
        public void Cold(HotHouse hotHouse)
        {
            if (hotHouse.CurrentTemperature != hotHouse.MaxTemperature
                && hotHouse.CurrentTemperature != hotHouse.MinTemperature)
            {
                hotHouse.CurrentTemperature -= 5;
                Console.WriteLine($"Heather minus 5 degrees !");
            }
            else
            {
                throw new Exception("Error with Min Max temperature!");
            }
        }
    }

}
