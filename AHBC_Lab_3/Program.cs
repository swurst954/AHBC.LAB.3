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
            // James - I love that you put your whole app in a while true!
            while (true)
            {
                // James - I see you are working with the Convert.ToInt32, not the worse thing to use
                // but I'll explain why you may want to avoid it in this case... Convert does not handle a non existing 
                // string.  so basically if you do something like 
                // string word = null;
                // Convert.ToInt32(word);
                // this will make int into its base value, which is 0.
                // Parse will not handle a null, which is not a bad thing, because if you use
                // TryParse instead, you can deal with if a string is null.
                Console.Write("Enter a number between 1 and 100: ");
                // James - in addition, I would try to handle if the user is not providing a actual number, again like using
                // int.TryParse();
                int num = Convert.ToInt32(Console.ReadLine());

                // James - pretty sweet that you were able to do this all within the same scope, I would try 
                // for extra challenge and readablity to use a switch/case instead. 
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

                // James - nice way to continue or leave the program
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
                    // James - I like that you considered the edge case of using 
                    Console.WriteLine("Not y or n, Goodbye");
                    Console.ReadLine();
                    break;
                }
            }
            // James - right now your program is not handling negative numbers.  this is an edge 
            // case worth considering.
        }

    }
}
