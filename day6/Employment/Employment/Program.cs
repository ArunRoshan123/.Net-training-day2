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
        static void UC3(int a, int b)
        {
            int Wage_per_hour = a;
            int Part_Time_hour = b;
            Console.WriteLine($"Part time Employee Wage {Wage_per_hour * Part_Time_hour}");

        }

        static void UC4(string a)
        {
            switch (a)
            {
                case "full time":
                    UC2(20, 8);
                    break;
                case "part time":
                    UC3(20, 4);
                    break;
            }
        }

        static void Main(string[] args)
        {
            UC2(20, 8);
            UC3(20, 4);

            string a = Console.ReadLine();
            UC4(a);
            Console.ReadLine();
        }
    }
}
