class Outdoor : Event
{
    private string _eventType = "Outdoor Event";
    private string _weatherReport = "";
    public Outdoor(string title, string desc, string date, string time, string address, string weather) : base(title, desc, date, time, address)
    {
        _weatherReport = weather;

        _fullDetails = "Event: " + _eventType + "\n" + _fullDetails + ".\nWeather: " + _weatherReport;
        _shortDescription = _eventType + ": " + _shortDescription;
    }
}