using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method
            Console.WriteLine("Q1: Find the largest number");
            int largest = Q1_method();
            Console.WriteLine($"The largest number is: {largest}\n");

            // Call Q2_method
            Console.WriteLine("Q2: Print a left or right-aligned triangle");
            Q2_method();
        }

        // Q1 Method: Returns the largest of two numbers
        static int Q1_method()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            return (num1 > num2) ? num1 : num2;
        }

        // Q2 Method: Prints a left or right triangle based on user input
        static void Q2_method()
        {
            Console.Write("Enter a number (N) for the triangle height: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose the shape (Left, Right): ");
            string shape = Console.ReadLine().Trim().ToLower();

            Console.WriteLine($"\nN = {N}, Shape = {shape}\n");

            if (shape == "left")
            {
                // Left-aligned triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape == "right")
            {
                // Right-aligned triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write("  "); // Print spaces for right alignment
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape choice. Please enter 'Left' or 'Right'.");
            }
        }
    }
}
