using System;

namespace Lame_age_printer
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older then " + age);
        }
    }
}
