using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. 
             * Test Data:
             * Enter a number: 5
             * Expected Output:
             * 555
             * 5 5
             * 5 5
             * 5 5
             * 555
             */

            decimal number;
            Console.WriteLine("Please enter a number");
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter a number between 1 and 9");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int z = 0; z < number; z++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();

                for (int x = 0; x < number - 2; x++)
                {
                    if (i == 0)
                    {
                        Console.Write(number);
                        for (int y = 0; y < number - 2; y++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine(number);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
