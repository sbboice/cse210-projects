using System.Text.Json.Serialization;

class Reflection : Activity
{
    private string _prompt = "";
    private string _instructions = "\nThis activity will help you reflect on times in your life where you have shown strength and resilience.\nFor this activity, you will be shown a prompt, and then asked multiple questions relating to the prompt. Take a moment to ponder and think about your response to each question.\n";
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you were able to overcome a significant challenge.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
    {
        PrintStartMessage();
        Console.WriteLine(_instructions);

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
        //Displays the prompt and provides a waiting period
        Console.Clear();
        Console.WriteLine(_instructions);
        Console.WriteLine("Your prompt: " + _prompt);
        LoadingSpinner();

        //Determines when in the future the game should end
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        //Runs loop while future time has not arrived
        DateTime currentTime = DateTime.Now;

        int index = 0;
        while (currentTime <= futureTime)
        {
            //Displays the question at the current index
            string question = _questions[index];

            //Prints instructions, prompt, and question to the user with a countdown
            Console.Clear();
            string message = "Your prompt: " + _prompt + "\n\nYour question: " + question;
            Countdown(10, message);

            index += 1;
            currentTime = DateTime.Now;
        }

        //End message        
        Console.Clear();
        PrintEndMessage();
        Thread.Sleep(5000);
    }
}