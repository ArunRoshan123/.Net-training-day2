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
            Random rand = new Random();

            int position = 0;
            int winningposition = 100;

            while (position < winningposition)
            {
                int number = rand.Next(1, 7);
                int option = rand.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine($"No Play. Player stays at position {position}");
                        break;
                    case 1:
                        if(position + number <= winningposition)
                        {
                        position += number;
                        Console.WriteLine($"Ladder! Player moves ahead to {position}");
                        }
                        break;
                    case 2:
                        position -= number;

                        if (position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine($"Snake! Player moves back to {position}");
                        break;


                }
            }
            Console.ReadLine();
        }
    }
}
