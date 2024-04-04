class Bicycle : Activity
{
    public Bicycle(string date, float time, float distance) : base(date, time, distance)
    {
        _activityType = "Cycling";

        this.CalculateSpeed();
        this.CalculatePace();
        this.WriteSummary();
    }
}