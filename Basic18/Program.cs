using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic18
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
            //  Sample Output:
            //  Input first integer:
            //  -5
            //  Input second integer:
            //  25
            //  Check if one is negative and one is positive: 
            //  True


            //variables
            int first_Number;
            int second_Number;
            bool check;

            //input
            Console.WriteLine("Input first number");
            while (!int.TryParse(Console.ReadLine(), out first_Number)) ;
            Console.WriteLine("Input second number");
            while (!int.TryParse(Console.ReadLine(), out second_Number)) ;

            //Process
            check = first_Number < 0 && second_Number > 0 || second_Number < 0 && first_Number > 0;

            //Output
            Console.WriteLine(check);
            Console.ReadKey();
        }
    }
}
