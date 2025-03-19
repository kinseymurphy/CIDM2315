namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //Q1 and Q2
        //customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        //initial customer info
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        //change info
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        //print change
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        //compare
        customer1.CompareAge(customer2);
    }
}
class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    //constructor
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    //new id
    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    //print info
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }
    //compare and print
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine("Both customers are the same age.");
        }
    }

}
