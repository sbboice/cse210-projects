class Listing : Activity
{
    private string _prompt = "";
    private string _instructions = "\nFor this activity, you will be given a prompt, and asked to list as many things as you can for the given prompt.\nWhen you are prompted, type your answer and press enter to log your reply.";
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing()
    {
        PrintStartMessage();
        Console.WriteLine(_instructions);
        Console.WriteLine();

        //Gets duration value from user
        Console.WriteLine("Please enter a duration for your activity:");
        string input = Console.ReadLine();
        _duration = int.Parse(input);

        //Chooses a random prompt to display
        Random r = new Random();
        int index = r.Next(0, _prompts.Count - 1);
        _prompt = _prompts[index];
    }

    public void Play()
    {
        Console.Clear();
        Console.WriteLine(_instructions);
        LoadingSpinner();

        int entries = 0;

        //Determines when in the future the game should end
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        //Runs loop while future time has not arrived
        DateTime currentTime = DateTime.Now;
        while (currentTime <= futureTime)
        {
            Console.Clear();
            Console.WriteLine("Your Prompt: " + _prompt);
            Console.WriteLine("Respond here (press enter to log entry):");
            Console.ReadLine();

            entries += 1; 
            currentTime = DateTime.Now;
        }

        //End message
        Console.Clear();
        Console.WriteLine("You logged " + entries + " entries in " + _duration + " seconds. Good job!");
        PrintEndMessage();
        Thread.Sleep(5000);
    }
}