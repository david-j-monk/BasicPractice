using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to compute the sum of two given integers, 
            //if two values are equal then return the triple of their sum.

            //variables
            int first_Number;
            int second_Number;
            int total;

            //input
            Console.WriteLine("Please enter first number");
            while (!int.TryParse(Console.ReadLine(), out first_Number))
            {
                Console.WriteLine("Please type a valid number");
            }
            Console.WriteLine("Please enter second number");
            while (!int.TryParse(Console.ReadLine(), out second_Number))
            {
                Console.WriteLine("Please type a valid number");
            }

            //process
            if (first_Number==second_Number)
            {
                total = 3*(first_Number+second_Number);
                bool same_Number = true;
            }
            else
            {
                total = first_Number + second_Number;
            }

            //output
            Console.WriteLine("{0}");
        }
    }
}
