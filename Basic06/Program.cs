using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
                Test Data:
            Input the first number to multiply: 2
            Input the second number to multiply: 3
            Input the third number to multiply: 6
            Expected Output:
            2 x 3 x 6 = 36*/

            int first;
            int second;
            int third;

            Console.WriteLine("Please enter the first number.");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number.");
            third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} x {1} x {2} = {3}", first, second, third, first*second*third);
            Console.ReadLine();

        }
    }
}
