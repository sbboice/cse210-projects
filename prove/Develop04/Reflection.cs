using System.Text.Json.Serialization;

class Reflection : Activity
{
    private string _instructions = "";
    private List<string> _prompts = new List<string>
    {
        "",
    };
    private List<string> _questions = new List<string>
    {
        "",
    };

    public Reflection()
    {
        PrintStartMessage();
        Console.WriteLine(_instructions);
        Console.WriteLine();

        //Gets duration value from user
        Console.WriteLine("Please enter a duration for your activity:");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }
}