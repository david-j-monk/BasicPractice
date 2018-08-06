using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Basic9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take 4 input numbers, display the average

            double total = 0;
            double[] numbers = new double[4];
            Console.WriteLine("Please input 4 numbers");
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                total += numbers[i];
            }

            Console.WriteLine(total);
            Console.WriteLine("The average of ");

            int arrayLength = numbers.Length;
            for (int i = 0; i < arrayLength; i++ )
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(total);
            Console.WriteLine(arrayLength);
            Console.WriteLine("is {0}", total/arrayLength);
            Console.ReadLine();
        }
    }
}