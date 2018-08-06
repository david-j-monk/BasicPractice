using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.            *    Sample Output:
             *    Input a string : The quick brown fox jumps over the lazy dog.
             *    TThe quick brown fox jumps over the lazy dog.T
             */


            string text;

            Console.WriteLine("Please enter a string of text.");
            text = Console.ReadLine();
            Console.WriteLine($"Your text is {text}");
            Console.WriteLine("{0}{1}{0}", text[0], text);
            Console.ReadLine();

        }
    }
}
