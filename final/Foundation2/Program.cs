using System;

class Program
{
    private List<List<string>> _products = new List<List<string>>();
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name.");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your street address:");
        string street = Console.ReadLine();

        Console.WriteLine("Please enter your city:");
        string city = Console.ReadLine();

        Console.WriteLine("Please enter your state:");
        string state = Console.ReadLine();

        Console.WriteLine("Please enter your country (type USA for United States):");
        string country = Console.ReadLine();
        
        Customer c = new Customer(name);
        c.SetAddress(street, city, state, country);

        string address = c.GetAddress();
        string domestic = c.GetDomestic();
        
           
    }
}