class Reflection : Activity
{
    private string _instructions = "";

    public Reflection()
    {
        PrintStartMessage();
        Console.WriteLine(_instructions);
        Console.WriteLine("Please enter a duration for your activity:");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }
}