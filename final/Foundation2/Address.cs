using System.Text.Json.Serialization;

class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    private string _domestic;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;

        this.IsDomestic();
    }

    private void IsDomestic()
    {
        if (_country == "USA" || _country == "United States")
        {
            _domestic = "Yes";
        }

        else
        {
            _domestic = "No";
        }
    }

    public List<string> ReturnAddress()
    {
        List<string> returnList = new List<string>();
        string fullAddress = _streetAddress + ", " + _city + ", " + _state + ", " + _country + ".";
        returnList.Add(fullAddress);
        returnList.Add(_domestic);

        return returnList;
    }
}