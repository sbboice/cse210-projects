class Breathing : Activity
{
    private string _instructions = "For this activity, please follow the directions on screen. Take deep, full breaths, and exhale fully.";

    public Breathing()
    {
        PrintStartMessage();
        Console.WriteLine("Please enter a duration for your activity:");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }
    public void Play()
    {
        Console.WriteLine(_instructions);
        LoadingSpinner();


        int timeElapsed = 0;
        int durationMilliseconds = _duration * 1000;
        while (timeElapsed < durationMilliseconds)
        {
            Countdown(7, "Breathe in...");
            Countdown(3, "Hold...");
            Countdown(5, "Breathe out..." );
            Countdown(3, "Hold...");
            
            timeElapsed += 12000;
        }

        Console.Clear();
        PrintEndMessage();
        Thread.Sleep(5000);
    }
}