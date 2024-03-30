class Product
{
    private string _name = "";
    private string _ID = "";
    private string _price = "";
    private string _quantity = "";

    public Product(string name, string ID, string price, string qty)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = qty;
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