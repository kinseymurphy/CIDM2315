using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Customer objects and customer_list
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // call Q1 method
        TotalCredits(customer_list);
        // call Q2 method
        AmarilloAverageAge(customer_list);
        // call Q3 method
        CanyonAge(customer_list);
    }

    // Q1. Total credit of all customers
    public static void TotalCredits(Customer[] customer_list)
    {
        double total = 0;
        foreach (Customer c in customer_list)
        {
            total += c.customerCredit;
        }
        Console.WriteLine("Q1: The total credits: " + total);
    }

    // Q2. Average age of customers in Amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int sum = 0;
        int count = 0;
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Amarillo")
            {
                sum += c.customerAge;
                count++;
            }
        }
        double avg = (double)sum / count;
        Console.WriteLine("Q2: The average age of customers in Amarillo: " + avg);
    }

    // Q3. Customers in Canyon and over 30 years old
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Canyon" && c.customerAge > 30)
            {
                Console.Write(c.customerName + ", ");
            }
        }
        Console.WriteLine();
    }
}

// Q0. Customer class
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
