using System;

namespace Snack_1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var split = input.Split(' ');
            var X = int.Parse(split[0]);
            var Y = int.Parse(split[1]);

            if(X == 1)
            {
                Console.WriteLine($"Total: R$ {string.Format("{0:0.00}", 4 * Y)}");
            }
            else if(X == 2)
            {

                Console.WriteLine($"Total: R$ {string.Format("{0:0.00}", 4.50 * Y)}");
            }
            else if (X == 3)
            {
                Console.WriteLine($"Total: R$ {string.Format("{0:0.00}", 5 * Y)}");
            }
            else if (X == 4)
            {
                Console.WriteLine($"Total: R$ {string.Format("{0:0.00}", 2 * Y)}");
            }
            else if (X == 5)
            {
                Console.WriteLine($"Total: R$ {string.Format("{0:0.00}", 1.50 * Y)}");
            }
        }
    }
}