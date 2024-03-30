using System.Collections.Specialized;
using System.Text.Json.Serialization;

class Order
{
    private string _shippingLabel = "";
    private string _packingList = "";
    private float _orderTotal;
    private string _domestic = "";
    private List<List<string>> _productList = new List<List<string>>();
    
    public Order(string name, string address, string domestic)
    {
        this.CreateShippingLabel(name, address);
        _domestic = domestic;
    }

    private void CreateShippingLabel(string name, string address)
    {
        _shippingLabel = name + "\n" + address;
    }

    private void CreatePackingList()
    {
    
    }

    private void CalculateOrderTotal()
    {

    }

    private int CalculateShippingCost(string isDomestic)
    {
        int shippingCost;
        if (isDomestic == "Yes")
        {
            shippingCost = 5;
            return shippingCost;
        }

        else
        {
            shippingCost = 35;
            return shippingCost;
        }
    }

    public string GetLabel()
    {
        return _shippingLabel;
    }

    public string GetList()
    {
        return _packingList;
    }

    public float GetTotal()
    {
        return _orderTotal;
    }
}