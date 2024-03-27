using System;

class Program
{
    List<string> videos = new List<string>();
    static void Main(string[] args)
    {
        Console.Clear();

        //Video 1 and comments
        Video v1 = new Video("How To Code in C#", "Bro. Keers", 1000);
        v1.GetComments("SuperCoolDude12", "AwesomeYoutuber", "Carguy200",
         "Great video! Very helpful", "I think I can use C# now.", "I still don't get it, can you make more videos?");
        
        Console.WriteLine();
        v1.Display();

        Console.WriteLine();

        //Video 2 and comments
        Video v2 = new Video("How to change your oil", "CarFixer2020", 1527);
        v2.GetComments("Amateur_Mechanic", "joey21090", "unknown_user",
         "What oil should I use for my car?", "Thanks for the help, I can do this on my own now!", "Very helpful!");

        Console.WriteLine();
        v2.Display();

        Console.WriteLine();

        //Video 3 and comments
        Video v3 = new Video("THE MOON LANDING WAS FAKED!!!!", "TinHatMan", 8910);
        v3.GetComments("NASA", "SpaceLuvr1969", "JakeTheSnake",
         "You're wrong", "I feel sorry for people who believe this", "What is this guy going on about?");

        Console.WriteLine();
        v3.Display();
    }
}