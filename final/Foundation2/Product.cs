class Product
{
    private string _name = "";
    private string _ID = "";
    private string _price = "";
    private string _quantity = "";

    public Product()
    {
        Console.WriteLine("Product Name: ");
        _name = Console.ReadLine();

        Console.WriteLine("Product ID: ");
        _ID = Console.ReadLine();

        Console.WriteLine("Price: ");
        _price = Console.ReadLine();

        Console.WriteLine("Quantity: ");
        _quantity = Console.ReadLine();
    }

    public List<string> GetProductInfo()
    {
        List<string> productInfo = new List<string>();
        productInfo.Add(_name);
        productInfo.Add(_ID);
        productInfo.Add(_price);
        productInfo.Add(_quantity);

        return productInfo;
    }

}