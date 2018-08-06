using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# program to create a new string from a given string where the first and last characters will change their positions.
             * Test Data:
             * w3resource
             * Python
             * Sample Output:
             * e3resourcw
             * nythoP 
             */

            string word = "Default";
            string first;
            string last;
            Console.WriteLine("Please enter a word");
            word = Console.ReadLine();
            int length = word.Length - 1;
            first = word.Substring(0, 1);
            last = word.Substring(length, 1);
            word = word.Remove(0,1);
            word = word.Insert(0, last);
            word = word.Remove(length,1);
            word = word.Insert(length, first);
            Console.WriteLine(word[0]);



            Console.ReadLine();


        }
    }
}
