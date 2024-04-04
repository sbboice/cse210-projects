using System.ComponentModel;
using System.Runtime.CompilerServices;

class Event
{
    //For all events
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private string _address = "";

    //Detail messages
    protected string _standardDetails = "";
    protected string _fullDetails = "";
    protected string _shortDescription = "";

    public Event(string title, string desc, string date, string time, string address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address; 

        this.GetStandardDetails();
        this.GetFullDetails();
        this.GetShortDescription();
    }

    public void GetStandardDetails()
    {
        _standardDetails = _title + "\n" + _description + "\n" + _date + ", " + _time + "\n" + _address;
    }
    
    public void GetFullDetails()
    {
        _fullDetails = _title + "\n" + _description + "\n" + _date + ", " + _time + "\n" + _address;
    }

    public void GetShortDescription()
    {
        _shortDescription = _title + "\n" + _date;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(_standardDetails);
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(_fullDetails);
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(_shortDescription);
    }
}