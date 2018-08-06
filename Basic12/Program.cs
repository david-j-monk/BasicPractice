using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in 
             *  the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. Go to the editor
             *   Test Data:
             *   Enter a digit: 25 
             *   Expected Output:
             *   25 25 25 25 
             *   25252525 
             *   25 25 25 25 
             *   25252525
             */
            decimal number;
            Console.WriteLine("Please enter a number");
            while (!decimal.TryParse(Console.ReadLine(), out number)) ;

            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(number);
                    if (i % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
