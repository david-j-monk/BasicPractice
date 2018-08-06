using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to swap two numbers. Go to the editor

            int firstNumber = 0;
            int secondnumber = 0;
            bool success = false;
            Console.WriteLine("Please type a number");
            while(!success)
            {
                success = int.TryParse(Console.ReadLine(), out firstNumber);
                if (!success)
                {
                    Console.WriteLine("Please enter a number");
                }
            }

            success = false;
            Console.WriteLine("Please type another number");
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out secondnumber);
                if (!success)
                {
                    Console.WriteLine("Please enter a number");
                }
            }

            success = false;
            Console.WriteLine("Before swap\n{0} - {1}", firstNumber, secondnumber);
            int temp = firstNumber;
            firstNumber = secondnumber;
            secondnumber = temp;

            Console.WriteLine("After swap\n{0} - {1}", firstNumber, secondnumber);
            Console.ReadLine();

        }
    }
}
