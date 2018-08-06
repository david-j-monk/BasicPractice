using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        class Person
        {
            public int age;
            string name;
            public void SayHi()
            {
                Console.WriteLine("Hi");
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
            p1.age = 4;
            Console.WriteLine(p1.age);
            Console.ReadKey();
        }//Outputs "Hi"
    }
}
