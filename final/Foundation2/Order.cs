using System.Collections.Specialized;
using System.Globalization;
using System.Text.Json.Serialization;

class Order
{
    private string _shippingLabel = "";
    private string _packingList = "";
    private float _orderTotal;
    private string _domestic = "";
    private int _shipping;
    private List<string> _productList = new List<string>();
    private List<float> _priceList = new List<float>();
    
    public Order(string name, string address, string domestic, List<List<string>> info)
    {
        this.CreateShippingLabel(name, address);
        this.CreatePackingList(info);
        _domestic = domestic;
    }

    private void CreateShippingLabel(string name, string address)
    {
        _shippingLabel = name + "\n" + address;
    }

    private void CreatePackingList(List<List<string>> productInfo)
    {
        _packingList = "Product Name    ID     Unit Price   QTY  Total Price";

        int i = 0;
        while (i <= productInfo.Count - 1)
        {
            List<string> innerList = productInfo[i];

            float unitPrice = float.Parse(innerList[2], CultureInfo.InvariantCulture);
            int quantity = int.Parse(innerList[3]);

            float totalPrice = unitPrice * quantity;

            _packingList += "\n" + innerList[0] + "    " + innerList[1] + "    $" + unitPrice + "    " + quantity + "    $" + totalPrice;

            _priceList.Add(totalPrice);

            i += 1;
        }
        
        this.CalculateOrderTotal(_priceList);
        _packingList += "\nYour shipping total is $" + _shipping;
        _packingList += "\nYour order total is $" + _orderTotal;
    }

    private void CalculateOrderTotal(List<float> prices)
    {
        int i = 0;
        while (i <= prices.Count - 1)
        {
            _orderTotal += prices[i];

            i += 1;
        }

        _shipping = this.CalculateShippingCost();
        _orderTotal += _shipping;
    }

    private int CalculateShippingCost()
    {
        int shippingCost;
        if (_domestic == "Yes")
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