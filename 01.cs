using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Whats your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}", name);
        }
    }
}
