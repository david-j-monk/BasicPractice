using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
             * Test Data:
             * Input the first number: 25
             * Input the second number: 4
             * Expected Output:
             * 25 + 4 = 29
             * 25 - 4 = 21
             * 25 x 4 = 100 
             * 25 / 4 = 6
             * 25 mod 4 = 1
             */

            int first;
            int second;
            string restart = "n";
            Start:
            Console.WriteLine("Please input the first number");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}\n" +
                              "{0} - {1} = {3}\n" +
                              "{0} x {1} = {4}\n" +
                              "{0} / {1} = {5}\n" +
                              "{0} mod {1} = {6}", first, second, first+second, first-second, first*second, first/second, first%second);
            Console.WriteLine("Would you like to start again? Y/N");
            Retry:
            restart = Console.ReadLine().ToLower();
            switch (restart)
            {
                case "y":
                    goto Start;
                case "n":
                    break;
                default:
                    Console.WriteLine("Please enter y or n");
                    goto Retry;
            }
        }
    }
}
