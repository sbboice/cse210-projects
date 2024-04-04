class Activity
{
    //Passed in via constructor
    protected string _activityType = "";
    private string _date = "";
    protected float _workoutLength;
    protected float _distance;

    //Calculated by internal methods
    private float _speed;
    private float _pace;
    private string _summary = "";

    public Activity(string date, float time, float distance = 0)
    {
        _date = date;
        _workoutLength = time;
        _distance = distance;
    }

    public virtual void CalculateSpeed()
    {
        _speed = (_distance / _workoutLength) * 60;
    }

    public virtual void CalculateDistance()
    {}
    

    public virtual void CalculatePace()
    {
        _pace = _workoutLength / _distance;
    }

    public virtual void WriteSummary()
    {
        _summary = _date + " " + _activityType + "(" + _workoutLength + " min): Distance: " + _distance + " km, Speed: " + _speed + " kph, Pace: " + _pace + " min per km.";
        Console.WriteLine("\n" + _summary + "\n");
    }
}