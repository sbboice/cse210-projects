using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.IO;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static string Menu()
    {
        /*
        Displays menu options for user to select from
        and prompts user for input

        Returns user selection as a string
        */
        string selection = "";
        Console.WriteLine();
        Console.WriteLine("1. New Entry.");
        Console.WriteLine("2. Show Entries.");
        Console.WriteLine("3. Save Entry.");
        Console.WriteLine("4. Load Entries.");
        Console.WriteLine("5. Quit.");
        Console.WriteLine();
        Console.WriteLine("Choose Option: ");
        selection = Console.ReadLine();
        return selection;
    }

    static void NewEntry()
    {
        /*
        First calls class and method to display random prompt
        Calls class and method to display date
        Gets user input for their journal entry
        Writes user entry to local list
        */
        Entry entry = new Entry();
        string prompt = entry.ShowPrompt();
        string date = entry.date;
        Console.WriteLine($"\nPrompt for {date}: {prompt}");
        string promptResponse = entry.GetInput();
        Entry.entries.Add($"{date}:{prompt}\n{promptResponse}\n");
    }

    static void Display()
    {
        /*
        Displays all entries from today (from local list)
        */
        Entry entry = new Entry();
        Console.WriteLine(); //Create a blank line
        foreach (string e in Entry.entries)
        {
            Console.WriteLine($"{e}");
        }
    }

    static void SaveJournal()
    {
        /*
        Gets filename from user
        Saves today's entries (local list) to file
        */
        string filename;
        Entry entry = new Entry();
        Console.WriteLine("Enter a filename: ");
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in Entry.entries)
            {
                outputFile.WriteLine($"{line}");
            }
        }
    }
    static void LoadJournal()
    {
        /*
        Gets filename from user
        Loads all journal entries into 
        */
        Entry entry = new Entry();
        string filename;
        Console.WriteLine("Enter a filename: ");
        filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry.entries.Add(line);
        }
    }

    static void Main(string[] args)
    {
        while(true)
        {
            string selection = Program.Menu();

            if (selection == "1")
            {
                //Creates new prompt and new entry
                Program.NewEntry();
            }

            else if (selection == "2")
            {
                //Displays journal entries from local
                Program.Display();
            }

            else if (selection == "3")
            {
                //Save entries to file
                Program.SaveJournal();
            }

            else if (selection == "4")
            {
                //Loads saved entries from file
                Program.LoadJournal();
            }

            else if (selection == "5")
            {
                //Quits the program
                Console.WriteLine("Quitting Program.");
                break;
            }
        }
    }
}