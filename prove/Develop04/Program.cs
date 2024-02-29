using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "1";

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Exercise Program.");
            Console.WriteLine("Please select an activity below:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit Program");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Breathing b = new Breathing();
                b.Play();
            }

            else if (input == "2")
            {
                
            }

            else if (input == "3")
            {
                
            }

            else if (input == "4")
            {
                Console.Clear();
                Console.WriteLine("\nQuitting Program\n");
                break;
            }
        }
    } 
}