using System;
using System.Collections.Generic;
using System.Xml.Serialization;

class Scripture
{
    //Create the scripture dictionary
    private Dictionary<string, string> scripturesDict = new Dictionary<string, string>();

    public Scripture()
    {
        //Constructs dictionary by adding reference verse pairs
        scripturesDict.Add("Matthew 6:24","No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon.");
        scripturesDict.Add("John 3:5","Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        scripturesDict.Add("James 1:5-6","If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        scripturesDict.Add("2 Nephi 2:25","Adam fell that men might be; and men are, that they might have joy.");
        scripturesDict.Add("Alma 37:6-7","Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes; and by very small meeans the Lord doth confound the wise and bringeht about the salvation of many souls.");
        scripturesDict.Add("Helamen 5:12","And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundations; that when the Devil shall send forth his mighty winds, yea, his shafts in the whirlwhind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fail.");
        scripturesDict.Add("Alma 32:21","And now as I said concerning faith - faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
    }
    
    public string ChooseScripture(string reference)
    {
        //Calls Reference class to get random reference
        string scriptureReference = reference;
        
        //Searches scriptureDict based on the returned reference to see if it exists
        //Reference is used as the key for search
        string verse = "";
        if (scripturesDict.ContainsKey(scriptureReference))
        {
            verse = scripturesDict[scriptureReference];
        }
        return verse;

    }
}