using System;
using System.Globalization;

class Program
{
    
    static void Main(string[] args)
    {
        List<List<string>> _products = new List<List<string>>();

        //Gets all information to be passed into the Customer class
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
        
        //Creates new Customer class and passes in all parameters
        Customer c = new Customer(name);
        c.SetAddress(street, city, state, country);

        //Creates and runs Product class
        Product p1 = new Product();

        List<string> innerList1 = p1.GetProductInfo();
        _products.Add(innerList1);

        //Creates second product
        Product p2 = new Product();

        List<string> innerList2 = p2.GetProductInfo();
        _products.Add(innerList2);

        //Creates third product
        Product p3 = new Product();

        List<string> innerList3 = p3.GetProductInfo();
        _products.Add(innerList3);

        string address = c.GetAddress();
        string domestic = c.GetDomestic();

        Order o = new Order(name, address, domestic, _products);
        string shippingLabel = o.GetLabel();
        string packingList = o.GetList();

        //Print Statements
        Console.WriteLine(shippingLabel);
        Console.WriteLine(packingList);

    }
}