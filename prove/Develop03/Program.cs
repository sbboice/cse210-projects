using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //Instantiates new Reference class
        Reference r = new Reference();

        //Gets a scripture reference from the RandomReference() method
        string reference = r.RandomReference();

        //Instantiates new Scripture class
        Scripture script = new Scripture();

        //Gets a scripture verse from ChooseScripture class, passing in reference as a argument
        string scripture = script.ChooseScripture(reference);

        //Instantiates a new ReplaceWords class
        ReplaceWords replace = new ReplaceWords(scripture);

        //Prints the reference and full scripture
        Console.WriteLine(reference + ": " + scripture);
        
        //Main loop for memorization process
        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'Quit' to exit");
            string input = Console.ReadLine();

            //If enter key is pressed (empty input)
            if (input == "")
            {
                Console.Clear();

                //Calls the Replace() method of the ReplaceWords() class
                string newScripture = replace.Replace();

                //Prints the scripture reference, and the new hidden verse
                Console.WriteLine(reference + ": " + newScripture);
            }


            //If "quit" is typed
            else if (input == "quit" || input == "Quit")
            {
                Console.Clear();

                //Displays a quit message, ends the program
                Console.WriteLine("Quitting Program");
                break;
            }

            //In case of invalid input
            else
            {
                Console.WriteLine("Please select a valid option");
            }
        }
    }
}