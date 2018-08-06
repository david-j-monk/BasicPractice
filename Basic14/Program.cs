using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
             *  Test Data:
             *  Enter the amount of celsius: 30
             *  Expected Output:
             *  Kelvin = 303
             *  Fahrenheit = 86
             */

            double celcius;
            double kelvin;
            double farenheit;

            Console.WriteLine("Enter the amount of celcius:");
            while (!double.TryParse(Console.ReadLine(), out celcius))
            {
                Console.WriteLine("Please enter a real number");
            }
            kelvin = celcius + 273.15;
            farenheit = celcius * 9 / 5 + 32;

            Console.WriteLine("Kelvin = {0}\nFarenheit = {1}", kelvin, farenheit);
            Console.ReadLine();
        }
    }
}
