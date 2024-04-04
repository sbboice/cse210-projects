class Reception : Event
{
    private string  _eventType = "Reception";
    private string _email = "";
    public Reception(string title, string desc, string date, string time, string address, string email) : base(title, desc, date, time, address)
    {
        _email = email;

        _fullDetails = "Event: " + _eventType + "\n" + _fullDetails + ". To RSVP, please email: " + _email;
        _shortDescription = _eventType + ": " + _shortDescription;
    }
}