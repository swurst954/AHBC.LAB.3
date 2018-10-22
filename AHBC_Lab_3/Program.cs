using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC_Method__Class_5_
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number between 1 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 != 0 && num <= 100)
                {
                    Console.WriteLine(num + " and odd");
                    Console.ReadLine();
                }
                else if (num % 2 == 0 && num >= 2 && num < 25)
                {
                    Console.WriteLine("Even and less than 25");
                    Console.ReadLine();
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even");
                    Console.ReadLine();
                }
                else if (num % 2 == 0 && num > 60 && num <= 100)
                {
                    Console.WriteLine(num + " and even");
                    Console.ReadLine();
                }
                else if (num % 2 != 0 && num > 60 && num <= 100)
                {
                    Console.WriteLine(num + " and odd");
                    Console.ReadLine();
                }
                else if (num > 100)
                {
                    Console.WriteLine("Try again, number between 1 and 100: ");
                }
                else
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                Console.WriteLine("Continue? (y/n)");
                string x = Console.ReadLine();

                if (x.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                else if (x.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Not y or n, Goodbye");
                    Console.ReadLine();
                    break;
                }
            }
        }

    }
}
