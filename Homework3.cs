using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
// Q1 Code; Is it prime?
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt16(Console.ReadLine());
            
            if (IsPrime(N))
            {
                Console.WriteLine($"{N} is prime");
            }
            else
            {
                Console.WriteLine($"{N} is non-prime");
            }

//Q2 Code; Square pattern, equal columns and rows
        Console.Write("\nEnter a number (N) for square patter:");
        int M = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("\nSquare Patter:");
        for (int i=0; i<M; i++)
        {
            for (int j=0; j<M; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

//Q3 Code; triangle pattern, equal rows
        Console.WriteLine("\nEnter a number (N)");
        int P = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("\nRow triangle pattern");
        for (int i=0; i<P; i++)
        {
            for (int j=0; j<=i; j++)
            {Console.Write("* ");}
        Console.WriteLine();
        }

 //Bonus Question
        Console.Write("\nEnter a number (N) for number triangle pattern: ");
            short B = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nNumber Triangle Pattern:");
            for (int i = 1; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        //prime method
        static bool IsPrime(int num)
        {
            if (num<2) return false;
            for (int i=2; i<num; i++)
            {
                if (num % i == 0)
                {
                    return false; // Found a divisor, not prime
                }
            }
            return true; // No divisors found, number is prime
        }
    }
}