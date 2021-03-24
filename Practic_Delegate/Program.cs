using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Delegate
{
    delegate void FDelegate(ConsoleColor color, int height, char sy);
    
    class Program
    {
        static void drawTrian(ConsoleColor color, int height, char symbol)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
        static void Square(ConsoleColor color, int height, char symbol)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            FDelegate fd = Square;
            fd += drawTrian;
            fd(ConsoleColor.Red, 10, '*');
            
        }
    }
}
