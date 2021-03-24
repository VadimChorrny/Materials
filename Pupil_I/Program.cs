using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil ann = new Pupil { Name = "Anya" };
            ann.Marks.Add(11);
            ann.Marks.Add(9);
            ann.Marks.Add(12);
            ann.Exams.Add(9);
            ann.Exams.Add(7);
            ann.Exams.Add(8);
            Console.WriteLine("Marks ");
            foreach (int item in ann)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Good marks");
            foreach (var item in ann.GetMarksHigher(9))
            {
                Console.WriteLine(item);
            }
                            

        }
    }
}
