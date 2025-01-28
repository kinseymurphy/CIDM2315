namespace Hmwk2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1, letter grades
        Console.WriteLine("Please input a letter grade (A, B, C, D, F): ");
        string letter = Console.ReadLine()?.ToUpper();
        
         // GPA based on letter grade
        if (letter == "A")
        {
            Console.WriteLine("A: 4");
        }
        else if (letter == "B")
        {
            Console.WriteLine("B: 3");
        }
        else if (letter == "C")
        {
            Console.WriteLine("C: 2");
        }
        else if (letter == "D")
        {
            Console.WriteLine("D: 1");
        }
        else if (letter == "F")
        {
            Console.WriteLine("F: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
   
        // Code for Q2, smallest number
        First number
        Console.Write("Please input the 1st number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        // Second number
        Console.Write("Please input the 2nd number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        // Third number
        Console.Write("Please input the 3rd number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        // Nested if statement, find smallest number
        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                Console.WriteLine("The smallest number is: " + num1);
            }
            else
            {
                Console.WriteLine("The smallest number is: " + num3);
            }
        }
        else
        {
            if (num2 <= num3)
            {
                Console.WriteLine("The smallest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The smallest number is: " + num3);
            }
        }

        // Code for Bonus Question, leap year
        Console.WriteLine("Is it a leap year? Please input a year:");
        string year = Console.ReadLine();
        int leap = Convert.ToInt16(year);

        // Nested if
        if (leap % 4 == 0){
            if (leap % 100 == 0){
                if (leap % 400 == 0){
                    Console.WriteLine($"{leap} is a leap year!");
                }
                else{
                Console.WriteLine($"{leap} is not a leap year.");
                }
            }
            else{
                Console.WriteLine($"{leap} is a leap year!");
            }
        }
        else{
                Console.WriteLine($"{leap} is not a leap year.");
        }
    }
}
