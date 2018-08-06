using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
             *  Test Data:
             *  Enter your age - 25
             *  Expected Output:
             *  You look older than 25
             */

            Console.WriteLine("Enter your age");
            Console.WriteLine("You look older than {0}", Console.ReadLine());
            Console.ReadLine();

        }
    }
}
