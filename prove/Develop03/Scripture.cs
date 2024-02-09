using System;
using System.Collections.Generic;

class Scripture
{
    //Create the scripture dictionary
    Dictionary<string, string> scripturesDict = new Dictionary<string, string>();

    public Scripture()
    {
        //Constructs dictionary by adding reference verse pairs
        scripturesDict.Add("","");
    }
    
    public void ChooseScripture()
    {
        //Calls Reference class to get random reference
        Reference r = new Reference();
        string scriptureReference = "";
        scriptureReference = r.randomReference();
        
        //Searches scriptureDict based on the returned reference to see if it exists
        //Reference is used as the key for search
        

    }
}