using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("Insert your name: ");
            name = Console.ReadLine();

            Console.Write("Insert your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welcome {0}, you are {1} years old. Awesome!", name, age);
        }
    }
}
