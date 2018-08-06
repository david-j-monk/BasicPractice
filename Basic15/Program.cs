using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Write a C# program remove the 1st, 2nd and last character from a string using index of a character. Go to the editor
             *  Test Data:
             *  w3resource
             *  Sample Output:
             *  wresource
             *  w3resourc
             *  3resource
             */
            string w3 = "w3resource";
            int str_Length = w3.Length - 1;
            Console.WriteLine(w3.Remove(0, 1));
            Console.WriteLine(w3.Remove(1, 1));
            Console.WriteLine(w3.Remove(str_Length, 1));
            Console.ReadLine();

        }
    }
}
