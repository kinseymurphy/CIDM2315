namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method() 
        int largestTwo = GetLargestNumber();
        Console.WriteLine($"The largest number is: {largestTwo}");

        // Call Q2_method()
        int largestFour = GetLargestOfFour();
        Console.WriteLine($"The largest number is: {largestFour}");

        // Call Q3_method()
        Console.WriteLine("\nQ3: Account Creation");
        CreateAccount();
    }
    // Q1_method
    static int GetLargestNumber()
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        return GetLargestNumber(num1, num2);
    }

    // Q1 Overload: Q2
    static int GetLargestNumber(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    // Q2_method
    static int GetLargestOfFour()
    {
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c = ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("d = ");
        int d = Convert.ToInt32(Console.ReadLine());

        int max1 = GetLargestNumber (a, b);
        int max2 = GetLargestNumber (c, d);
        int largest = GetLargestNumber (max1, max2);

        Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");
        return largest;
    }
    // Q3_method
    // 18 or older
        static bool CheckAge(int birth_year)
        {
            int current_year = DateTime.Now.Year; 
            int age = current_year - birth_year;
            return age >= 18;
        }

        // Create account
        static void CreateAccount()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Console.Write("Re-enter password: ");
            string confirmPassword = Console.ReadLine();

            Console.Write("Enter your birth year: ");
            int birth_year = Convert.ToInt32(Console.ReadLine());

            // Check age
            if (CheckAge(birth_year))
            {
                // Passwords match
                if (password == confirmPassword)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }
    }