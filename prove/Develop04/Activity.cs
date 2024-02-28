using System.Reflection.Metadata.Ecma335;

class Activity
{
    private string _startMessage = "Please take a moment to complete the following activity to increase your mindfulness";
    private int _duration;
    private string _endMessage = "Thank you for participating. Come back frequently to continue to improve your mindfulness";

    public Activity(int time)
    {
        _duration = time;
    } 

    public string GetStartMessage()
    {
        return _startMessage;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetEndMessage()
    {
        return _endMessage;
    }
}