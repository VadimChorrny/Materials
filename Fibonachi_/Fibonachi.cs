using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_
{
    class Fibonachi : IEnumerable
    {
        public int First = 0;
        public int Second = 1;
        public int NumCurrent = 1;

        public IEnumerator GetEnumerator()
        {
            yield return 0;
            yield return 1;
            for (int i = 0; NumCurrent < 100; i++)
            {
                NumCurrent =  First + Second;
                First = Second;
                Second = NumCurrent;

                yield return NumCurrent;
            }
        }

       
    }
}
