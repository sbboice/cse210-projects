class Customer
{
    private string _name = "";
    private List<string> _addressInfo = new List<string>();
    private string _address = "";
    private string _isDomestic = "";

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        Address a = new Address(street, city, state, country);
        _addressInfo = a.ReturnAddress();
        _address = _addressInfo[0];
        _isDomestic = _addressInfo[1];
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetDomestic()
    {
        return _isDomestic;
    }
}