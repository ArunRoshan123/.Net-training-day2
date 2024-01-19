using System;
namespace ConsoleApp5
{
    class Program
    {
        static void UC5(string a)
        {
            int part_time_day = 20 * 4;
            int full_time_day = 20 * 8;
            int part_time_per_month = part_time_day * 20;
            int full_time_per_month = full_time_day * 20;

            if (a == "part time")
            {
                Console.WriteLine($"Wage per month for part time = {part_time_per_month}");

                //UC6
                Console.WriteLine($"Wage per year for part time = {part_time_per_month * 12}");
            }
            else if(a == "full time")
            {
                Console.WriteLine($"Wage per month for full time = {full_time_per_month}");

                //UC6
                Console.WriteLine($"Wage per year for full time = {full_time_per_month * 12}");
            }
        }

        static void Main(string[] args)
        {
            
            string a = Console.ReadLine();
            UC5(a);
            Console.ReadLine();
        }
    }
}
