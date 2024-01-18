using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.WriteLine("Enter Number (0 to quit):");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}.");

        float average = sum / numbers.Count;

        Console.WriteLine($"The average is {average}.");

        int maximum = 0;

        foreach (int num in numbers)
        {
            if (num > maximum)
            {
                maximum = num;
            }
        }

        Console.WriteLine($"The maximum value is {maximum}.");

    }
}