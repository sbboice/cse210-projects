using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Lecture : Event
{
    private string _eventType = "Lecture";
    private string _speaker = "";
    private int _capacity;
    public Lecture(string title, string desc, string date, string time, string address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;

        _fullDetails = "Event: " + _eventType + "\nSpeaker: " + _speaker + "\nCapacity: " + _capacity + "\n" + _fullDetails;
        _shortDescription = _eventType + ": " + _shortDescription;
    }
}