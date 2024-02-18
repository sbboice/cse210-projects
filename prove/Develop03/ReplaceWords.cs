using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class ReplaceWords
{
    private Dictionary<int, List<string>> wordsDict = new Dictionary<int, List<string>>();
    private string scripture = "";

    public ReplaceWords(string scripture)
    {
        //Assigns the private attribute to be the same as the passed in argument
        this.scripture = scripture;

        //Takes string input and splits into the individual words, and adds to the list
        string[] splitScripture = scripture.Split(" ");

        //Transfers information from splitScripture list into wordsDict, with the attached string "Visible"
        int index = 0;
        foreach (string word in splitScripture)
        {
            List<string> internalList = new List<string>{word, "Visible"};
            // Console.WriteLine(internalList[0] + " - " + internalList[1]);
            wordsDict.Add(index, internalList);
            index += 1;
        }
    }

    public string Replace(int numToHide = 3)
    {
        /*
        Searches through the wordsDict dictionary, line by line, and checks
        whether the value of the word is "Visible" or "Hidden". If Visible, 
        there is a 30% chance that the word will be replaced, and the value will 
        be set to Hidden. 
        */

        //First determines how many words are still visible
        int visibleWords = 0;

        foreach (KeyValuePair<int, List<string>> entry in wordsDict)
        {
            List<string> internalList = wordsDict[entry.Key];
            string isVisible = internalList[1];

            if (isVisible == "Visible")
            {
                visibleWords += 1;
            }

            else if (isVisible == "Hidden")
            {
                visibleWords += 0;
            }

        }

        int j = 0;
        string hiddenScripture = "";
        numToHide = Math.Min(numToHide, visibleWords);

        //If there are no visible words left, return a message
        if (numToHide == 0)
        {
            string finish = "You have finished memorizing this scripture.";
            return finish;
        }

        //Iterates through each line of the dictionary

        foreach (KeyValuePair<int, List<string>> entry in wordsDict)
        {
            //Gets list from dictionary and gets individual values from within the list
            List<string> internalList = wordsDict[entry.Key];
            string text = internalList[0];
            string state = internalList[1];

            if (state == "Hidden")
            {
                string hiddenWord = this.HideWord(text);
                hiddenScripture += " " + hiddenWord;
            }

            else if (state == "Visible")
            {
                //As less words become visible, the chances that a word will be hidden become higher
                int highestValue = Math.Min(11, visibleWords);

                //Chooses a number between 1 and 20
                Random r = new Random();
                int percent = r.Next(0,highestValue);

                //If percent is 1 or less, the word status is set to "Hidden"
                if (percent <= 1)
                {
                    if (j >= numToHide)
                    {
                        hiddenScripture += " " + text;
                    }

                    else if (j < numToHide)
                    {
                        List<string> newInternalList = new List<string>{text, "Hidden"};
                        wordsDict[entry.Key] = newInternalList;
                        string hiddenWord = this.HideWord(text);
                        hiddenScripture += " " + hiddenWord;
                        
                        j += 1;
                    }
                    
                }

                //If percent is greater than 1, nothing is changed
                else if (percent > 1)
                {
                    hiddenScripture += " " + text;
                }
            }
        }
        return hiddenScripture;
    }

    private string HideWord(string word)
    {
        string underscore = "";
        int wordLength = word.Length;

        //Creates a placeholder word that replaces all letters with underscores
        while (wordLength > 0)
        {
            underscore += "_";
            wordLength -= 1;
        }

        return underscore;
    }
}