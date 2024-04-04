using System.Runtime.Intrinsics.X86;

class Swimming : Activity
{
    private float _distanceSwimming;
    private float _laps;
    private int _lapLength = 50;

    public Swimming(string date, float time, float laps) : base(date, time)
    {
        _laps = laps;
        _activityType = "Swimming";

        this.CalculateDistance();
        _distance = _distanceSwimming;

        this.CalculateSpeed();
        this.CalculatePace();
        this.WriteSummary();
    }

    public override void CalculateDistance()
    {
        _distanceSwimming = _laps * _lapLength / 1000;
    }
}