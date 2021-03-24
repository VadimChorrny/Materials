using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer ann = new Customer { Name = "Ann" };
            Customer ivan = new Customer { Name = "Ivan" };



            Magazine magazine = new Magazine
            {
                Title = "Forbes"
            };
            magazine.NewPostAddedEvent += ann.Handler;
            magazine.NewPostAddedEvent += ivan.Handler;

            magazine.AddPost("Elon Mask has became richest man in the world !");
            magazine.NewPostAddedEvent -= ann.Handler;
            magazine.NewPostAddedEvent -= ivan.Handler;
            magazine.AddPost("Bill Gates has became lilte man !");
            magazine.NewPostAddedEvent += Worker.Handler;
            magazine.AddPost("Vlad Tluhovskiy has became very stupid man in the world !");
            //Console.WriteLine(magazine);
            
        }
    }
}
