using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            Console.Write("Insert number of rolls: ");
            int n = int.Parse(Console.ReadLine());

            int[] rolls = new int [n];
            int total = 0;

            Console.WriteLine("\nYou rolled:");

            for (int i = 0; i < n; i++)
            {   
                rolls[i] = randNum.Next(1, 7);
                Console.Write(rolls[i]+"  ");
                total += rolls[i];
            }

            Console.WriteLine("\nTotal: " + total);
        }
    }
}
