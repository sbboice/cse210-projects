using System;

class Program
{
    static void Main(string[] args)
    {
        string date = "04 April 2024";
        float time = 6.8f;
        float distance = 1.9f;
        Running r = new Running(date, time, distance);

        date = "10 October 2022";
        time = 25.2f;
        distance = 9.75f;
        Bicycle b = new Bicycle(date, time, distance);

        date = "11 April 2024";
        time = 33.0f;
        float laps = 15.7f;
        Swimming s = new Swimming(date, time, laps);
    }
}