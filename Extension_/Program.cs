using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_
{
    // ext methods : static method in static class
    static class ExtString
    {
        // first parametr = extention type with keyword this
        public static int CountWords(this string str,string word)
        {
            string[] words = str.Split("\t\n,-/\\.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return words.Count(x => x == word);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Demo line \t";
            Console.WriteLine(str.CountWords("line"));
        }
    }
}
