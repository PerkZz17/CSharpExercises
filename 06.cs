using System;

namespace _06
{
    internal class Program
    {
        enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        {
            Console.WriteLine("{0} = {0}", weekDays.Monday, (int)weekDays.Monday);

            weekDays favoriteDay = weekDays.Friday;
            Console.WriteLine("My favorite day of the week is {0}", favoriteDay);

            favoriteDay = (weekDays)6; //Will print Sunday since its in index 6
            Console.WriteLine("My favorite day of the week is {0}", favoriteDay);
        }
    }
}
