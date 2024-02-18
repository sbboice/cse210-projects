class Reference
{
    private List<string> references = new List<string>
    {
        //Scripture references are added here
        "Matthew 6:24",
        "John 3:5",
        "James 1:5-6",
        "2 Nephi 2:25",
        "Alma 37:6-7",
        "Helamen 5:12",
        "Alma 32:21"
    };

    public string RandomReference()
    {
        //Chooses a random index and returns the string (reference) at that index
        Random rnd = new Random();
        int index = rnd.Next(0, references.Count - 1);
        string reference = references[index];   
        return reference;
    }
}