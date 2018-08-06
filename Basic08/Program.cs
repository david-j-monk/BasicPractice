using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *  Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
             *  Test Data:
             *  Enter the number: 5
             *  Expected Output:
             *  5 * 0 = 0
             *  5 * 1 = 5
             *  5 * 2 = 10 
             *  5 * 3 = 15
             *  ....
             *  5 * 10 = 50
             */

            Console.WriteLine("Please enter a number to see its multiplication table");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How far should it multiply?");
            double timesMultiply = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < timesMultiply+1; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number*i);
            }

            Console.ReadLine();
        }
    }
}
