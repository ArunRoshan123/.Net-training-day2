using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static int UC2()
        {
            Random rand = new Random();
            int number = rand.Next(1, 7);
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Player got number = {UC2()}");
            Console.ReadLine();
        }
    }
}
