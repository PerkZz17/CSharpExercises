using System;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.Write("Insert the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("The sum of {0} + {1} is {2}", num1, num2, sum);
        }
    }
}
