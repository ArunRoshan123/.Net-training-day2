using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int position = 0;
            Random rand = new Random();
            int number = rand.Next(1, 7);
            int option = rand.Next(0, 3);

            switch(option)
            {
                case 0:
                    Console.WriteLine("Player stays in same location");
                    break;
                case 1:
                    Console.WriteLine(number + position);
                    break;
                case 2:
                    Console.WriteLine(position - number);
                    break;
            }
            Console.ReadLine();
        }
    }
}
