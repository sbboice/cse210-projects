using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "1";

        //Main loop
        while (input != "4")
        {
            //Displays menu options
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Exercise Program.");
            Console.WriteLine("Please select an activity below:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit Program");

            //Collects input
            input = Console.ReadLine();

            //Runs Breathing activity
            if (input == "1")
            {
                Console.Clear();
                Breathing b = new Breathing();
                b.Play();
            }

            //Runs Reflection activity
            else if (input == "2")
            {
                Console.Clear();
                Reflection r = new Reflection();
                r.Play();
            }

            //Runs Listing Activity
            else if (input == "3")
            {
                Console.Clear();
                Listing l = new Listing();
                l.Play();
            }

            //Obliterates program
            else if (input == "4")
            {
                Console.Clear();
                Console.WriteLine("\nQuitting Program\n");
                break;
            }
        }
    } 
}