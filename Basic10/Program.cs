using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
                Test Data:
                Enter first number - 5
                Enter second number - 6
                Enter third number - 7

                Expected Output:
                Result of specified numbers 5, 6 and 7, (x + y)*z is 77 and x*y + y*z is 72
                */

            decimal[] number_arr = new decimal[3];


            Console.WriteLine("Please enter 3 numbers");
            for (int i = 0; i < 3 ; i++)
            {
                while (!decimal.TryParse(Console.ReadLine(), out number_arr[i]))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            decimal x = number_arr[0];
            decimal y = number_arr[1];
            decimal z = number_arr[2];

            Console.WriteLine(  "({0}+{1})x{2}= {3} \n" +
                                "{0}x{1}+{1}x{2} = {4}",
                                x,y,z, (x+y)*z, x*y+y*z);

            Console.ReadLine();

        }
    }
}
