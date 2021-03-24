using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil_I
{
    class Pupil : IEnumerable
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();
        public List<int> Exams { get; set; } = new List<int>();

        public IEnumerable<int> GetAllExams() 
        {
            foreach (int item in Exams)
            {
                yield return item;
            }
            //return Exams.GetEnumerator();

        }
        public IEnumerable<int>GetMarksHigher(int limit)
        {
            foreach (var item in Marks)
            {
                if (item >= limit)
                    yield return item;
            }

        }
        public IEnumerator GetEnumerator() // реалiзацiя iнтерфейсу, неявний iтератор
        {
            //return Marks.GetEnumerator();
            foreach (int item in Marks)
            {
                yield return item;
            }
            foreach (int item in Exams)
            {
                yield return item;
            }
            //yield break; // exit
        }
    }
}
