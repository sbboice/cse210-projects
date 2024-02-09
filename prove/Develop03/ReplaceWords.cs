using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class ReplaceWords
{
    private List<string> replacement = new List<string>();
    private List<int> replacedIndexes = new List<int>();

    public ReplaceWords(string scripture)
    {
        //Takes string input and splits into the individual words, and adds to the list
        string[] splitScripture = scripture.Split(" ");

        //Transfers information from splitScripture list into replacement list to be moved to a usable scope
        foreach (string word in splitScripture)
        {
            replacement.Add(word);
        }
    }

    public string Replace()
    {

        for (int i = 3; i != 0; i--)
        {
            //Chooses a random index
            Random rnd = new Random();
            int index = rnd.Next(0, replacement.Count);
            replacement[index] = "_____";
        }

        string replacementScripture = string.Join(" ", replacement);
        return replacementScripture;
    }
}