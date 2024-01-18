using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int square = SquareNumber(favoriteNumber);

        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }  

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int num)
    {
        int sqrnum = num * num;
        return sqrnum;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
    }

}