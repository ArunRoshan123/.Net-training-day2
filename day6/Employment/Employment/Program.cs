using System;
namespace ConsoleApp5
{
    class Program
    {
        static void UC3(int a, int b)
        {
            int Wage_per_hour = a;
            int Part_Time_hour = b;
            Console.WriteLine($"Part time Employee Wage {Wage_per_hour * Part_Time_hour}");

        }


        static void Main(string[] args)
        {
            UC3(20, 4);
            Console.ReadLine();
        }
    }
}
