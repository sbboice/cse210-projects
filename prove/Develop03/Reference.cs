class Reference
{
    private List<string> references = new List<string>
    {
        //Scripture references are added here
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""
    };

    public string randomReference()
    {
        //Chooses a random index and returns the string (reference) at that index
        Random rnd = new Random();
        int index = rnd.Next(0, references.Count);
        string reference = references[index];   
        return reference;
    }
}