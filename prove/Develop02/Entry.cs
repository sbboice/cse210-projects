using System;

public class Entry
{
    public static List<string> entries = new List<string>();
    public static DateTime currentDate = DateTime.Now;

    public string date = currentDate.ToString("MM-dd-yyyy HH:mm");
    public string input;
    public string ShowPrompt()
    {
        Prompt p = new Prompt();
        string randomPrompt = p.GivePrompt();
        return randomPrompt;
    }

    public string GetInput()
    {
        string journalEntry = Console.ReadLine();
        return journalEntry;
    }
    
}