using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to check the sum of the two given integers
            //and return true if one of the integer is 20 or if their sum is 20
            Console.WriteLine("Please enter two numbers. True will display if either is 20 or if their sum is 20.");
            Console.WriteLine(IsOne20OrDoBothEqual20(GetNumberInputs(), GetNumberInputs()));
            Console.ReadLine();


            double GetNumberInputs()
            {
                double number;
                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please use numbers only");
                }

                return number;
            }

            bool IsOne20OrDoBothEqual20(double number1, double number2)
            {
                if (number1 == 20 || number2 == 20 || number1 + number2 == 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }





    }
}
