using System;

class Program
{
    static void Main(string[] args)
    {
        string title = "American History Since 1867";
        string desc = "This lecture will cover topics and information about American history as far back as 1867.";
        string date = "October 10, 2024.";
        string time = "6:00 PM";
        string address = "538 S 2ND W, Rexburg, ID, 83440";
        string speaker = "Seth Boice";
        int capacity = 150;

        Lecture l = new Lecture(title, desc, date, time, address, speaker, capacity);
        l.DisplayStandardDetails();
        l.DisplayFullDetails();
        l.DisplayShortDescription();

        title = "Jane Doe Bridal Shower";
        desc = "Come help us celebrate the recently engaged Jane Doe! Lunch provided.";
        date = "April 12, 2024";
        time = "12:00 PM";
        address = "Porter Park, S 2nd W & 3rd W, Rexburg, ID 83440";
        string email = "janedoe@gmail.com";

        Reception r = new Reception(title, desc, date, time, address, email);
        r.DisplayStandardDetails();
        r.DisplayFullDetails();
        r.DisplayShortDescription();

        title = "St. Anthony Dunes Retreat";
        desc = "Celebrate the end of the semester by having a fun evening at the sand dunes!";
        date = "April 11, 2024";
        time = "5:00 PM";
        address = "St. Anthony Sand Dunes, 8 mi. west of St. Anthony off Red Rd.";
        string weather = "Clear skies, high of 63 degrees, low of 33 degrees. 10% chance of light rain.";

        Outdoor o = new Outdoor(title, desc, date, time, address, weather);
        o.DisplayStandardDetails();
        o.DisplayFullDetails();
        o.DisplayShortDescription();
    }
}