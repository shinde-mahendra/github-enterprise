void Main()
{
    // This is a simple C# program that prints "Hello, World!" to the console.
    Console.WriteLine("Hello, World!");

    // create a method to calculate number of days between two dates
    int CalculateDaysBetween(DateTime startDate, DateTime endDate)
    {
        return (endDate - startDate).Days;
    }

    
}

// Model class for Customer
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    // Empty constructor
    public Customer()
    {
    }

    // Parameterized constructor
    public Customer(string firstName, string lastName, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }
}