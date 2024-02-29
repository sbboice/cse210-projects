using System.Data;
using System.Reflection.Metadata.Ecma335;

class Activity
{
    private string _startMessage = "Please take a moment to complete the following activity to improve your mindfulness";
    protected int _duration = 30;
    private string _endMessage = "Thank you for participating. Come back frequently to continue to improve your mindfulness";

    public void PrintStartMessage()
    {
        //Displays the starting message for the program
        Console.WriteLine(_startMessage);
    }

    public void PrintEndMessage()
    {
        //Displays the final message for the program
        Console.WriteLine(_endMessage);
    }

    public void LoadingSpinner(int duration = 5)
    {
        //Gets current time and adds 5 seconds for comparison
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        //Gets current time again, for comparison
        DateTime currentTime = DateTime.Now;
        while (currentTime <= futureTime)
        {
            Console.Write("\b\b \b");
            Console.Write("=");

            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(300);

            Console.Write("\b\b  \b\b");
            Console.Write("||");

            Thread.Sleep(300);

            Console.Write("\b\b  \b\b");
            Console.Write("//");

            Thread.Sleep(300);

            //Adds above elapsed time to current time value
            currentTime = currentTime.AddMilliseconds(1200);
        }
    }

    public void Countdown(int duration = 5, string message = "")
    {
        /*
        Creates and displays a numerical countdown, as well as a message.
        */
        int i = duration;
        
        while (i >= 1)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine(duration);
            
            //Handles double digit values
            if (i < 10)
            {
                Console.Write("\b \b");
            }

            //Handles triple digit values in case someone ever decides to use a triple digit duration for some reason
            else if (i >= 10 && i < 100)
            {
                Console.Write("\b\b  \b\b");
            }

            //Delays for 1 second
            Thread.Sleep(1000);

            i -= 1;
            duration -= 1;
        }
    }
}