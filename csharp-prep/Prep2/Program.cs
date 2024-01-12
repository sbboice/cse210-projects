using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade percent did you receive? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";


            if (grade >= 90)
            {
                letter = "A";
            }

            else if (grade >= 80 && grade < 90)
            {
                letter = "B";
            }
            
            else if (grade >= 70 && grade < 90)
            {
                letter = "C";
            }

            else if (grade >= 60 && grade < 70)
            {
                letter = "D";
            }

            else if (grade < 60)
            {
                letter = "F";
            }

        Console.WriteLine($"You received a {letter} in the class.");

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }

            else
            {
                Console.Write("Unfortunately, you did not pass. Keep working hard for it!");
            }
    }
}