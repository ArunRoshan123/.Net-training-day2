using System;
namespace ConsoleApp5
{
    class Program
    {
        static void UC2(int a, int b)
        {
            int Wage_per_hour = a;
            int Full_day_hour = b;
            Console.WriteLine($"Daily Employee Wage {Wage_per_hour * Full_day_hour}");

        }

        static void Main(string[] args)
        {
            UC2(20, 8);

            Console.ReadLine();
        }
    }
}
