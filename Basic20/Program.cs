using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to get the absolute value of the difference between two given numbers. 
            //Return double the absolute value of the difference if the first number is greater than second number.
            Console.WriteLine("Please enter the two numbers");
            Console.Write($"The difference is {CalculateDifference(GetNumberInputs(), GetNumberInputs())}.");
            Console.ReadLine();
        }

        static double CalculateDifference(double firstNumber, double secondNumber)
        {
            double result;
            if (firstNumber>secondNumber)
            {
                result = (firstNumber - secondNumber) * 2;
            }
            else
            {
                result = secondNumber - firstNumber;
            }
            return result;
        }

        static double GetNumberInputs()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please use numbers only");
            }

            return number;
        }
    }

}
