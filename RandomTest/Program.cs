using System;

namespace RandomTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rand = new Random();

            Random r1 = new Random();
            Random r2 = new Random();

            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next());

            // Generate and display 5 random integers.
            Console.WriteLine("Five random integer values:");
            for (int i = 0; i <= 4; i++)
                Console.Write("{0,15:N0}", rand.Next());
            Console.WriteLine();

            // Generate and display 5 random integers between 0 and 100.
            Console.WriteLine("Five random integers between 0 and 100:");
            for (int i = 0; i <= 4; i++)
                Console.Write("{0,8:N0}", rand.Next(101));
            Console.WriteLine();

            // Generate and display 5 random integers from 1 to 6.
            Console.WriteLine("Five random integers between 1 and 6:");
            for (int i = 0; i <= 4; i++)
                Console.Write(" " + rand.Next(1, 7));
            Console.WriteLine();
        }
    }
}
