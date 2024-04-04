class Running : Activity
{
    public Running(string date, float time, float distance) : base(date, time, distance)
    {
        _activityType = "Running";

        this.CalculateSpeed();
        this.CalculatePace();
        this.WriteSummary();
    }
}