using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Insert the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("The biggest number is {0}", num1);
            }
            else
                Console.WriteLine("The biggest number is {0}", num2);

        }
    }
}
